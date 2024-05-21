namespace DesktopApp.UserControls
{
    partial class TPTControl
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
            label1 = new Label();
            panel1 = new Panel();
            Fragment_lbl = new Label();
            label12 = new Label();
            TotalMines_Lbl = new Label();
            AntiPers_Lbl = new Label();
            Anti_tk_lbl = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Perimeter_lbl = new Panel();
            Total_lbl = new Label();
            TpCarriage = new Label();
            label17 = new Label();
            TpCarriage_lbl = new Label();
            label3 = new Label();
            totalVEH_lbl = new Label();
            lorryLD_lbl = new Label();
            perimeter = new Label();
            label7 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel1.SuspendLayout();
            Perimeter_lbl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 27);
            label1.TabIndex = 3;
            label1.Text = "TPT";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Fragment_lbl);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(TotalMines_Lbl);
            panel1.Controls.Add(AntiPers_Lbl);
            panel1.Controls.Add(Anti_tk_lbl);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(55, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 217);
            panel1.TabIndex = 17;
            // 
            // Fragment_lbl
            // 
            Fragment_lbl.AutoSize = true;
            Fragment_lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Fragment_lbl.Location = new Point(209, 130);
            Fragment_lbl.Name = "Fragment_lbl";
            Fragment_lbl.Size = new Size(97, 21);
            Fragment_lbl.TabIndex = 15;
            Fragment_lbl.Text = "Placeholder";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(13, 130);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(181, 22);
            label12.TabIndex = 14;
            label12.Text = "FRAGMENTATION ";
            // 
            // TotalMines_Lbl
            // 
            TotalMines_Lbl.AutoSize = true;
            TotalMines_Lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TotalMines_Lbl.Location = new Point(209, 169);
            TotalMines_Lbl.Name = "TotalMines_Lbl";
            TotalMines_Lbl.Size = new Size(97, 21);
            TotalMines_Lbl.TabIndex = 13;
            TotalMines_Lbl.Text = "Placeholder";
            TotalMines_Lbl.Click += TotalMines_Lbl_Click;
            // 
            // AntiPers_Lbl
            // 
            AntiPers_Lbl.AutoSize = true;
            AntiPers_Lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AntiPers_Lbl.Location = new Point(209, 99);
            AntiPers_Lbl.Name = "AntiPers_Lbl";
            AntiPers_Lbl.Size = new Size(97, 21);
            AntiPers_Lbl.TabIndex = 12;
            AntiPers_Lbl.Text = "Placeholder";
            // 
            // Anti_tk_lbl
            // 
            Anti_tk_lbl.AutoSize = true;
            Anti_tk_lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Anti_tk_lbl.Location = new Point(209, 64);
            Anti_tk_lbl.Name = "Anti_tk_lbl";
            Anti_tk_lbl.Size = new Size(97, 21);
            Anti_tk_lbl.TabIndex = 9;
            Anti_tk_lbl.Text = "Placeholder";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(13, 169);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 22);
            label8.TabIndex = 10;
            label8.Text = "TOTAL ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 98);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(177, 22);
            label9.TabIndex = 9;
            label9.Text = "ANTI PERS MINES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 63);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(152, 22);
            label10.TabIndex = 9;
            label10.Text = "ANTI TK MINES";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(13, 16);
            label11.Name = "label11";
            label11.Size = new Size(147, 26);
            label11.TabIndex = 5;
            label11.Text = "MINE LORRY";
            // 
            // Perimeter_lbl
            // 
            Perimeter_lbl.BorderStyle = BorderStyle.FixedSingle;
            Perimeter_lbl.Controls.Add(Total_lbl);
            Perimeter_lbl.Controls.Add(TpCarriage);
            Perimeter_lbl.Controls.Add(label17);
            Perimeter_lbl.Controls.Add(TpCarriage_lbl);
            Perimeter_lbl.Controls.Add(label3);
            Perimeter_lbl.Controls.Add(totalVEH_lbl);
            Perimeter_lbl.Controls.Add(lorryLD_lbl);
            Perimeter_lbl.Controls.Add(perimeter);
            Perimeter_lbl.Controls.Add(label7);
            Perimeter_lbl.Controls.Add(label14);
            Perimeter_lbl.Controls.Add(label15);
            Perimeter_lbl.Controls.Add(label16);
            Perimeter_lbl.Location = new Point(55, 321);
            Perimeter_lbl.Name = "Perimeter_lbl";
            Perimeter_lbl.Size = new Size(1003, 305);
            Perimeter_lbl.TabIndex = 18;
            // 
            // Total_lbl
            // 
            Total_lbl.AutoSize = true;
            Total_lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Total_lbl.Location = new Point(209, 204);
            Total_lbl.Name = "Total_lbl";
            Total_lbl.Size = new Size(97, 21);
            Total_lbl.TabIndex = 18;
            Total_lbl.Text = "Placeholder";
            // 
            // TpCarriage
            // 
            TpCarriage.AutoSize = true;
            TpCarriage.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TpCarriage.Location = new Point(209, 170);
            TpCarriage.Name = "TpCarriage";
            TpCarriage.Size = new Size(97, 21);
            TpCarriage.TabIndex = 17;
            TpCarriage.Text = "Placeholder";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Maroon;
            label17.Location = new Point(13, 203);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(75, 22);
            label17.TabIndex = 16;
            label17.Text = "TOTAL";
            // 
            // TpCarriage_lbl
            // 
            TpCarriage_lbl.AutoSize = true;
            TpCarriage_lbl.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            TpCarriage_lbl.Location = new Point(13, 169);
            TpCarriage_lbl.Margin = new Padding(4, 0, 4, 0);
            TpCarriage_lbl.Name = "TpCarriage_lbl";
            TpCarriage_lbl.Size = new Size(156, 22);
            TpCarriage_lbl.TabIndex = 15;
            TpCarriage_lbl.Text = "TPs CARRIAGE ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(891, 22);
            label3.TabIndex = 14;
            label3.Text = "ONE LORRY FOR SETTING OUT STORES, NAVIGATION STORES , TOTAL NO OF VEH REQUIRED";
            // 
            // totalVEH_lbl
            // 
            totalVEH_lbl.AutoSize = true;
            totalVEH_lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            totalVEH_lbl.Location = new Point(901, 131);
            totalVEH_lbl.Name = "totalVEH_lbl";
            totalVEH_lbl.Size = new Size(97, 21);
            totalVEH_lbl.TabIndex = 13;
            totalVEH_lbl.Text = "Placeholder";
            // 
            // lorryLD_lbl
            // 
            lorryLD_lbl.AutoSize = true;
            lorryLD_lbl.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lorryLD_lbl.Location = new Point(209, 99);
            lorryLD_lbl.Name = "lorryLD_lbl";
            lorryLD_lbl.Size = new Size(97, 21);
            lorryLD_lbl.TabIndex = 12;
            lorryLD_lbl.Text = "Placeholder";
            // 
            // perimeter
            // 
            perimeter.AutoSize = true;
            perimeter.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            perimeter.Location = new Point(209, 64);
            perimeter.Name = "perimeter";
            perimeter.Size = new Size(97, 21);
            perimeter.TabIndex = 9;
            perimeter.Text = "Placeholder";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(13, 169);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 22);
            label7.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(13, 98);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(106, 22);
            label14.TabIndex = 9;
            label14.Text = "LORRY LD";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(13, 63);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(128, 22);
            label15.TabIndex = 9;
            label15.Text = "PERIMETER ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(13, 16);
            label16.Name = "label16";
            label16.Size = new Size(280, 26);
            label16.TabIndex = 5;
            label16.Text = "MARKING STORE LORRY";
            // 
            // TPTControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Perimeter_lbl);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "TPTControl";
            Size = new Size(1103, 695);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Perimeter_lbl.ResumeLayout(false);
            Perimeter_lbl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label Fragment_lbl;
        private Label label12;
        private Label TotalMines_Lbl;
        private Label AntiPers_Lbl;
        private Label Anti_tk_lbl;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel Perimeter_lbl;
        private Label TpCarriage_lbl;
        private Label label3;
        private Label totalVEH_lbl;
        private Label lorryLD_lbl;
        private Label perimeter;
        private Label label7;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label Total_lbl;
        private Label TpCarriage;
        private Label label17;
    }
}
