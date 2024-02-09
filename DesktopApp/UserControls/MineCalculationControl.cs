using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.UserControls
{
    public partial class MineCalculationControl : UserControl
    {
        SharedDataModel sharedDataModel;
        public MineCalculationControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }


        public void Run_btn_Click()
        {
            try
            {
                Resul_panel.Visible = true;

                //Number of mines formula
                Anit_Pers_Mines_Lbl.Text = CalculateNoOfMine(A_Pers_tb.Text, frontage_tb.Text);
                sharedDataModel.Anit_Pers_Mines = double.Parse(Anit_Pers_Mines_Lbl.Text);
                Anti_Tank_Mines_lbl.Text = CalculateNoOfMine(A_Tk_tb.Text, frontage_tb.Text);
                sharedDataModel.Anti_Tank_Mines = double.Parse(Anti_Tank_Mines_lbl.Text);
                Anit_Mines_16_lbl.Text = CalculateNoOfMine(Frag_tb.Text, frontage_tb.Text);
                sharedDataModel.Anit_Mines_16 = double.Parse(Anit_Mines_16_lbl.Text);

                //Time and Resources 
                No_of_Mine_lbl.Text = CalculateTotalMines();
                sharedDataModel.No_of_Mine = double.Parse(No_of_Mine_lbl.Text);
                Rate_Of_Laying_lbl.Text = Rate_of_Laying_tb.Text + " MINES/24 HR CYCLE BY EMLP";
                sharedDataModel.Rate_Of_Laying = double.Parse(Rate_of_Laying_tb.Text);
                MLPs_Required_lbl.Text = CalculateMLP() + " Nos";
                sharedDataModel.MLPs_Required = double.Parse(CalculateMLP());

                // Avaiable Mines 
                Nmm_14_lbl.Text = Anit_Pers_Mines_Lbl.Text;
                sharedDataModel.Nmm_14 = double.Parse(Nmm_14_lbl.Text);
                ND_Mk_1_lbl.Text = Anti_Tank_Mines_lbl.Text;
                sharedDataModel.ND_Mk_1 = double.Parse(ND_Mk_1_lbl.Text);
                M_16_frag_lbl.Text = Anit_Mines_16_lbl.Text;
                sharedDataModel.M_16_frag = double.Parse(M_16_frag_lbl.Text);

                //No of strips 
                strips_A_Per_Lbl.Text = CalculateStrips("A_PER");
                sharedDataModel.strips_A_Per = double.Parse(strips_A_Per_Lbl.Text);
                A_tk_strips_lbl.Text = CalculateStrips("A_TK");
                sharedDataModel.A_tk_strips = double.Parse(A_tk_strips_lbl.Text);
                frag_strips_lbl.Text = CalculateStrips("FRAG");
                sharedDataModel.frag_strips = double.Parse(frag_strips_lbl.Text);

                sharedDataModel.IsMineCalculated = true;
            }
            catch (Exception ex)
            {
                Resul_panel.Visible = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        private string CalculateStrips(string calType)
        {
            if (calType == "A_PER")
            {
                if (double.TryParse(A_Pers_tb.Text, out double A_Pers))
                {
                    // Calculate the result using the formula
                    double _result = (A_Pers / 1);

                    // Display the result
                    return _result.ToString();
                }
                else
                {
                    throw new Exception("Please enter valid data for A/Pers.");
                }
            }
            if (calType == "A_TK")
            {
                if (double.TryParse(A_Tk_tb.Text, out double A_tk))
                {
                    // Calculate the result using the formula
                    double _result = (A_tk / (1.0 / 3.0));

                    // Display the result
                    return _result.ToString();
                }
                else
                {

                    throw new Exception("Please enter valid data for A/TK.");
                }
            }
            if (calType == "FRAG")
            {
                if (double.TryParse(Frag_tb.Text, out double Frag))
                {
                    // Calculate the result using the formula
                    double _result = (Frag / (1.0 / 12.0));

                    // Display the result
                    return _result.ToString();
                }
                else
                {

                    throw new Exception("Please enter valid data for Frag.");
                }
            }
            return "Error";
        }



        private string CalculateMLP()
        {
            if (double.TryParse(No_of_Mine_lbl.Text, out double noOfMines) & double.TryParse(Rate_of_Laying_tb.Text, out double rateofLaying))
            {
                // Calculate the result using the formula
                double _result = Math.Ceiling(noOfMines / rateofLaying);

                // Display the result
                return _result.ToString();
            }
            else
            {

                throw new Exception("Please enter valid data for Rate of Laying.");
            }

        }
        private string CalculateTotalMines()
        {
            if (double.TryParse(Anit_Pers_Mines_Lbl.Text, out double Anti_Pers) &&
                double.TryParse(Anti_Tank_Mines_lbl.Text, out double Anti_Tank) &&
                double.TryParse(Anit_Mines_16_lbl.Text, out double Anti_Mines))
            {
                // Calculate the result using the formula
                double _result = Anti_Pers + Anti_Tank + Anti_Mines;

                // Display the result
                return _result.ToString();
            }
            else
            {
                throw new Exception("Error while calculation total mines");
            }

        }
        private string CalculateNoOfMine(string _density, string _frontage)
        {
            if (double.TryParse(_density, out double density) &&
                double.TryParse(_frontage, out double frontage))
            {
                // Calculate the result using the formula
                double _result = (density * frontage) + (0.1 * density * frontage);

                // Display the result
                return _result.ToString();
            }
            else
            {

                throw new Exception("Please enter valid data for Mines density and frontage.");
            }

        }



        public void Reset_btn_Click()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset data? You may lost your calculated value.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Resul_panel.Visible = false;
                frontage_tb.Text = "";
                A_Pers_tb.Text = "";
                A_Tk_tb.Text = "";
                Frag_tb.Text = "";
                sharedDataModel.Reset();
            }

        }

        private void SetErrorProvider(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) )
            {
                // Display error if input is empty
                errorProvider.SetError(textBox, "Input Required.");
            }else if( !double.TryParse(textBox.Text, out _))
            {
                errorProvider.SetError(textBox, "Enter Valid data");
            }
            else
            {
                // Clear error if input is valid
                errorProvider.SetError(textBox, "");
            }
        }
        private void frontage_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void A_Pers_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void A_Tk_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Frag_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }

        private void Rate_of_Laying_tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetErrorProvider(textBox);
        }
    }
}
