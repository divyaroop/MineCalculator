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
    public partial class NiSignControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        public NiSignControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void InitCalculate()
        {
            try
            {
                Ssm_Lbl.Text = sharedDataModel.Assumed_strips.ToString();
                Esm_lbl.Text = sharedDataModel.Assumed_strips.ToString();
                shortstrip_displaylbl.Text = $"Short Strip (Assume {sharedDataModel.Assumed_strips.ToString()} Nos)";
                Total_lbl.Text = CalculateTotal() + " Nos";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalculateTotal()
        {

            // Calculate the result using the formula
            double value = double.Parse(Ssm_Lbl.Text) + double.Parse(Esm_lbl.Text) + double.Parse(Rap_lbl.Text) + double.Parse(RestArea_Lbl.Text) + double.Parse(AlarmPaost_Lbl.Text) + double.Parse(StoreDump_Lbl.Text) + double.Parse(ComdPost_lbl.Text) + double.Parse(ShortStrip_lbl.Text) + double.Parse(IslAndVsl_lbl.Text);
            double _result = Math.Ceiling(value + (value * 0.1));
            // Display the result
            return _result.ToString();

        }
    }
}
