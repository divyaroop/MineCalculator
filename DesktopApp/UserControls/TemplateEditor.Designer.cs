namespace DesktopApp.UserControls
{
    partial class TemplateEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditor));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            printDownload_panel = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            SettingPanel = new Panel();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            printDownload_panel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(0, 85);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1145, 624);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += TemplateChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(printDownload_panel);
            panel1.Controls.Add(SettingPanel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 86);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // printDownload_panel
            // 
            printDownload_panel.Controls.Add(panel3);
            printDownload_panel.Controls.Add(panel2);
            printDownload_panel.Location = new Point(662, 3);
            printDownload_panel.Name = "printDownload_panel";
            printDownload_panel.Size = new Size(471, 80);
            printDownload_panel.TabIndex = 6;
            printDownload_panel.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Turquoise;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(260, 12);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 63);
            panel3.TabIndex = 6;
            panel3.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(56, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 59);
            button3.TabIndex = 1;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Print_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(22, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 63);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(56, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(150, 59);
            button2.TabIndex = 1;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Download_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SettingPanel
            // 
            SettingPanel.BackColor = Color.DodgerBlue;
            SettingPanel.Controls.Add(button1);
            SettingPanel.Controls.Add(pictureBox3);
            SettingPanel.Location = new Point(263, 15);
            SettingPanel.Margin = new Padding(3, 4, 3, 4);
            SettingPanel.Name = "SettingPanel";
            SettingPanel.Size = new Size(208, 63);
            SettingPanel.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(56, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 59);
            button1.TabIndex = 1;
            button1.Text = "Change Document";
            button1.UseVisualStyleBackColor = false;
            button1.Click += upload_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 27);
            label1.TabIndex = 3;
            label1.Text = "Template Preview";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // TemplateEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "TemplateEditor";
            Size = new Size(1145, 709);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            printDownload_panel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel SettingPanel;
        private Button button1;
        private PictureBox pictureBox3;
        private Panel printDownload_panel;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button button3;
        private PictureBox pictureBox2;
    }
}
