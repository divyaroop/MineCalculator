using PdfSharp.Pdf.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.HelperClass
{
    public static class PDFHelper
    {

    }
    public class PlaceholderReplacer
    {
        private Dictionary<string, string> placeholderDictionary;

        public PlaceholderReplacer()
        {
            // Initialize the placeholder dictionary
            placeholderDictionary = new Dictionary<string, string>();
        }

        // Add a placeholder and its corresponding value to the dictionary
        public void AddPlaceholder(string placeholder, string value)
        {
            placeholderDictionary[placeholder] = value;
        }

        // Replace placeholders in the input string with their corresponding values
        public void ReplacePlaceholders(string input,ref RichTextBox richTextBox)
        {
            string rtfContent = richTextBox.Rtf;
            foreach (var placeholder in placeholderDictionary)
            {
                string pattern = $"@@{placeholder.Key}@@";
                rtfContent = Regex.Replace(rtfContent, pattern, placeholder.Value, RegexOptions.IgnoreCase);
            }
            richTextBox.Rtf = rtfContent;
        }
    }
}
