using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System.ComponentModel;

using System.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text;
using System.Reflection;
using DesktopApp.HelperClass;
using DesktopApp.Model;
using DocumentFormat.OpenXml.Bibliography;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
namespace DesktopApp.UserControls
{
    public partial class TemplateEditor : UserControl
    {
        private const string defaultFilePath = @"Document\DefaultTemplate.docx";
        SharedDataModel sharedDataModel;
        public TemplateEditor(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();


        }

        public void InitCalculate()
        {
            string assemblyDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string relativeFilePath = System.IO.Path.Combine(assemblyDirectory, defaultFilePath);
            DisplayFileContents(relativeFilePath);
        }
        private void LoadPdf(string filePath)
        {
            try
            {
                using (PdfReader reader = new PdfReader(filePath))
                {
                    string text = "";
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text += PdfTextExtractor.GetTextFromPage(reader, i);
                    }
                    richTextBox1.Text = text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDF: " + ex.Message);
            }
        }


        private void TemplateEditor_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to restrict the file types to documents only
            openFileDialog.Filter = "Word Documents|*.docx;*.doc";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Call method to read and display the contents of the selected file
                DisplayFileContents(filePath);
            }
        }

        private void DisplayFileContents(string filePath)
        {
            richTextBox1.Clear();

            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
                {
                    Body body = doc.MainDocumentPart.Document.Body;

                    foreach (var paragraph in body.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>())
                    {
                        string paragraphText = "";

                        foreach (var run in paragraph.Elements<Run>())
                        {
                            string runText = "";

                            foreach (var text in run.Elements<Text>())
                            {
                                runText += text.Text;
                            }

                            // Apply formatting to the text
                            ApplyFormatting(run, richTextBox1);

                            paragraphText += runText;
                        }

                       // Handle numbering
                        var numberingLevel = GetNumberingLevel(paragraph);
                        if (numberingLevel > 0)
                        {
                            paragraphText = $"{new string('\t', numberingLevel - 1)}{paragraphText}";
                        }


                        richTextBox1.AppendText(paragraphText);
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                }

                //Now bind the calculed values 
                PlaceholderReplacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }
      
        private void ApplyFormatting(Run run, RichTextBox richTextBox)
        {
            // Get font size
            string fontSize = run.RunProperties?.FontSize?.Val?.Value;
            if (!string.IsNullOrEmpty(fontSize))
            {
                float size;
                if (float.TryParse(fontSize, out size))
                {
                    richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, size);
                }
            }

            // Get font style
            FontStyle fontStyle = FontStyle.Regular;
            if (run.RunProperties?.Bold != null && run.RunProperties.Bold.Val != null && run.RunProperties.Bold.Val.Value)
            {
                fontStyle |= FontStyle.Bold;
            }
            if (run.RunProperties?.Italic != null && run.RunProperties.Italic.Val != null && run.RunProperties.Italic.Val.Value)
            {
                fontStyle |= FontStyle.Italic;
            }

            // Check if underline property is available and is not 'None'
            if (run.RunProperties?.Underline != null && run.RunProperties.Underline.Val != null && run.RunProperties.Underline.Val != UnderlineValues.None)
            {
                fontStyle |= FontStyle.Underline;
            }

            if (run.RunProperties?.Strike != null && run.RunProperties.Strike.Val != null && run.RunProperties.Strike.Val.Value)
            {
                fontStyle |= FontStyle.Strikeout;
            }
            richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont, fontStyle);


            ////// Apply alignment
            JustificationValues? justification = GetParagraphJustification(run);
            if (justification != null)
            {
                if (justification == JustificationValues.Center)
                {
                    richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                }
                else if (justification == JustificationValues.Right)
                {
                    richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                }
                //else if (justification == JustificationValues.Left)
                //{
                //    richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                //}
                else
                {
                    richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                }
            }

        }


        private int GetNumberingLevel(Paragraph paragraph)
        {
            int level = 0;
            var numberingProperties = paragraph.Descendants<NumberingProperties>().FirstOrDefault();
            if (numberingProperties != null)
            {
                var levelIndex = numberingProperties.GetFirstChild<NumberingLevelReference>().Val;
                int.TryParse(levelIndex, out level);
            }
            return level;
        }
        private JustificationValues? GetParagraphJustification(Run run)
        {
            // Get the parent paragraph
            DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = run.Parent as DocumentFormat.OpenXml.Wordprocessing.Paragraph;
            if (paragraph != null)
            {
                // Get the paragraph properties
                ParagraphProperties paragraphProperties = paragraph.ParagraphProperties;
                if (paragraphProperties != null)
                {
                    // Get the justification
                    Justification justification = paragraphProperties.Justification;
                    if (justification != null)
                    {
                        return justification.Val;
                    }
                }
            }
            return null;
        }

        private void PlaceholderReplacer()
        {
            PlaceholderReplacer replacer = new PlaceholderReplacer();

            // Add placeholders and values
            replacer.AddPlaceholder("frontage", sharedDataModel.Frontage.ToString());
            replacer.AddPlaceholder("depth", sharedDataModel.Depth.ToString());
            replacer.AddPlaceholder("antiTank", sharedDataModel.Anti_Tank_Mines.ToString());
            replacer.AddPlaceholder("barMine", sharedDataModel.Anit_Pers_Mines.ToString());
            replacer.AddPlaceholder("Influence", sharedDataModel.M_16_frag.ToString());
            replacer.AddPlaceholder("NMM", sharedDataModel.Nmm_14.ToString());
            replacer.AddPlaceholder("M16", sharedDataModel.M_16_frag.ToString());

            // Replace placeholders with actual values
           replacer.ReplacePlaceholders(richTextBox1.Text,ref richTextBox1);
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            upload_Click(sender, e);
        }

        private void print_click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, ev.MarginBounds.X, ev.MarginBounds.Y);
            };
            printDocument.Print();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document document = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(document, fileStream);

                    document.Open();

                    // Create a Font object to store the formatting
                  //  iTextSharp.text.Font font = new iTextSharp.text.Font();

                    // Iterate over the content of the RichTextBox
                    foreach (string line in richTextBox1.Lines)
                    {

                        // Create a Paragraph object for each line
                        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();

                        // Iterate over the characters in the line
                        foreach (char c in line)
                        {
                            Phrase phrase = new Phrase();
                            // Apply formatting based on the current character's properties
                            if (richTextBox1.SelectionFont != null)
                            {
                                // Apply font family
                                iTextSharp.text.Font font = FontFactory.GetFont(richTextBox1.SelectionFont.FontFamily.Name);

                                // Apply font style
                                if (richTextBox1.SelectionFont.Bold)
                                    font.SetStyle(iTextSharp.text.Font.BOLD);
                                if (richTextBox1.SelectionFont.Italic)
                                    font.SetStyle(iTextSharp.text.Font.ITALIC);

                                // Apply font size
                                font.Size = richTextBox1.SelectionFont.Size;

                                // Apply color
                                font.Color = new BaseColor(richTextBox1.SelectionColor);

                                // Create a Chunk with the character and the applied font
                                Chunk chunk = new Chunk(c.ToString(), font);

                                // Add the Chunk to the Phrase
                                phrase.Add(chunk);
                            }
                            else
                            {
                                // If no font is selected, create a Chunk with only the character
                                Chunk chunk = new Chunk(c.ToString());
                                phrase.Add(chunk);
                            }

                            // Add the character to the Paragraph object with the applied formatting
                            paragraph.Add(phrase);
                        }

                        // Add the Paragraph object to the Document
                        document.Add(paragraph);
                    }

                    document.Close();
                }
            }
        }

        private void TemplateChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox1.Text))
            {
                printDownload_panel.Visible = true;
            }
        }

        private void PrintRichTextBoxContent(RichTextBox richTextBox)
        {
            // Create a new document
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter writer = null;
            string filePath = "output.pdf";
            try
            {
                // Create a PdfWriter instance to write the PDF document
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    // Open the document
                    doc.Open();

                    // Create a new Paragraph instance to hold the text from the RichTextBox
                    iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(richTextBox.Text);

                    // Add the paragraph to the document
                    doc.Add(paragraph);

                    writer.Close();
                }

                // Print the PDF document
                PrintDocument printDoc = new PrintDocument();
                int currentPage = 0;
                printDoc.PrintPage += (sender, e) =>
                    {
                        PdfReader pdfReader = new PdfReader("output.pdf");
                        PdfImportedPage pdfPage = writer.GetImportedPage(pdfReader, ++currentPage);

                        PdfTemplate pdfTemplate = writer.DirectContent.CreateTemplate(pdfPage.Width, pdfPage.Height);
                        pdfTemplate.AddTemplate(pdfPage, 0, 0);

                        // Convert PdfTemplate to Bitmap
                        Bitmap bmp = new Bitmap((int)pdfPage.Width, (int)pdfPage.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.Clear(System.Drawing.Color.White); // Set background color to white
                            g.DrawImage(bmp, 0, 0); // Draw the PdfTemplate onto the Bitmap
                        }
                        e.Graphics.DrawImage(bmp, e.MarginBounds.Location);
                        pdfReader.Close();

                    };
                printDoc.Print();


            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the document
                doc.Close();
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintRichTextBoxContent(richTextBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Print_Click(sender, e);
        }


    }
}
