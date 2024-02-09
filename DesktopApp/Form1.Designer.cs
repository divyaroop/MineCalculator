namespace DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            menu_toggle_btn = new Button();
            Reset_btn = new Button();
            MineLayingCalculation = new Label();
            Run_btn = new Button();
            sidePanel = new Panel();
            AccessoriesPanel = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            MineNavpanel = new Panel();
            MineCalculation_btn = new Button();
            pictureBox1 = new PictureBox();
            sidebar_Timer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            sidePanel.SuspendLayout();
            AccessoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            MineNavpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(menu_toggle_btn);
            panel1.Controls.Add(Reset_btn);
            panel1.Controls.Add(MineLayingCalculation);
            panel1.Controls.Add(Run_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1319, 56);
            panel1.TabIndex = 0;
            // 
            // menu_toggle_btn
            // 
            menu_toggle_btn.BackgroundImage = (Image)resources.GetObject("menu_toggle_btn.BackgroundImage");
            menu_toggle_btn.BackgroundImageLayout = ImageLayout.Stretch;
            menu_toggle_btn.Location = new Point(218, 5);
            menu_toggle_btn.Margin = new Padding(3, 4, 3, 4);
            menu_toggle_btn.Name = "menu_toggle_btn";
            menu_toggle_btn.Size = new Size(46, 44);
            menu_toggle_btn.TabIndex = 28;
            menu_toggle_btn.UseVisualStyleBackColor = true;
            menu_toggle_btn.Click += menu_toggle_btn_Click;
            // 
            // Reset_btn
            // 
            Reset_btn.BackColor = Color.Gray;
            Reset_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Reset_btn.ForeColor = SystemColors.ButtonHighlight;
            Reset_btn.Location = new Point(1173, 7);
            Reset_btn.Name = "Reset_btn";
            Reset_btn.Size = new Size(143, 47);
            Reset_btn.TabIndex = 27;
            Reset_btn.Text = "Reset";
            Reset_btn.UseVisualStyleBackColor = false;
            Reset_btn.Click += Reset_btn_Click;
            // 
            // MineLayingCalculation
            // 
            MineLayingCalculation.AutoSize = true;
            MineLayingCalculation.BackColor = Color.DarkBlue;
            MineLayingCalculation.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point);
            MineLayingCalculation.ForeColor = Color.WhiteSmoke;
            MineLayingCalculation.Location = new Point(3, 3);
            MineLayingCalculation.Name = "MineLayingCalculation";
            MineLayingCalculation.Padding = new Padding(3);
            MineLayingCalculation.Size = new Size(197, 47);
            MineLayingCalculation.TabIndex = 0;
            MineLayingCalculation.Text = "Calculator";
            // 
            // Run_btn
            // 
            Run_btn.BackColor = SystemColors.Highlight;
            Run_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Run_btn.ForeColor = SystemColors.ButtonHighlight;
            Run_btn.Location = new Point(1023, 5);
            Run_btn.Name = "Run_btn";
            Run_btn.Size = new Size(143, 47);
            Run_btn.TabIndex = 26;
            Run_btn.Text = "Run";
            Run_btn.UseVisualStyleBackColor = false;
            Run_btn.Click += Run_btn_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.MintCream;
            sidePanel.Controls.Add(AccessoriesPanel);
            sidePanel.Controls.Add(MineNavpanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 56);
            sidePanel.MaximumSize = new Size(222, 800);
            sidePanel.MinimumSize = new Size(61, 740);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(222, 740);
            sidePanel.TabIndex = 1;
            // 
            // AccessoriesPanel
            // 
            AccessoriesPanel.Controls.Add(button2);
            AccessoriesPanel.Controls.Add(pictureBox2);
            AccessoriesPanel.Location = new Point(8, 87);
            AccessoriesPanel.Margin = new Padding(3, 4, 3, 4);
            AccessoriesPanel.Name = "AccessoriesPanel";
            AccessoriesPanel.Size = new Size(205, 64);
            AccessoriesPanel.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(50, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(153, 59);
            button2.TabIndex = 1;
            button2.Text = "Accessories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(-5, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MineNavpanel
            // 
            MineNavpanel.BackColor = Color.Transparent;
            MineNavpanel.Controls.Add(MineCalculation_btn);
            MineNavpanel.Controls.Add(pictureBox1);
            MineNavpanel.Location = new Point(3, 15);
            MineNavpanel.Margin = new Padding(3, 4, 3, 4);
            MineNavpanel.Name = "MineNavpanel";
            MineNavpanel.Size = new Size(208, 63);
            MineNavpanel.TabIndex = 2;
            // 
            // MineCalculation_btn
            // 
            MineCalculation_btn.BackColor = Color.Transparent;
            MineCalculation_btn.BackgroundImageLayout = ImageLayout.Stretch;
            MineCalculation_btn.FlatAppearance.BorderSize = 0;
            MineCalculation_btn.FlatStyle = FlatStyle.Flat;
            MineCalculation_btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            MineCalculation_btn.Location = new Point(55, 0);
            MineCalculation_btn.Margin = new Padding(0);
            MineCalculation_btn.Name = "MineCalculation_btn";
            MineCalculation_btn.Size = new Size(151, 59);
            MineCalculation_btn.TabIndex = 1;
            MineCalculation_btn.Text = "Mine Calculation ";
            MineCalculation_btn.UseVisualStyleBackColor = false;
            MineCalculation_btn.Click += button1_Click;
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
            // sidebar_Timer
            // 
            sidebar_Timer.Interval = 10;
            sidebar_Timer.Tick += menuToggleTick;
            // 
            // panel2
            // 
            panel2.Controls.Add(mainPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(222, 56);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1097, 740);
            panel2.TabIndex = 4;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1097, 740);
            mainPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1319, 796);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DesktopApp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidePanel.ResumeLayout(false);
            AccessoriesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            MineNavpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidePanel;
        private Label MineLayingCalculation;
        private Button MineCalculation_btn;
        private PictureBox pictureBox1;
        private Button Run_btn;
        private Button Reset_btn;
        private Label MessageBox_lbl;
        private Panel MineNavpanel;
        private Panel AccessoriesPanel;
        private Button button2;
        private PictureBox pictureBox2;
        private Button menu_toggle_btn;
        private System.Windows.Forms.Timer sidebar_Timer;
        private Panel panel2;
        private Panel mainPanel;
    }
}