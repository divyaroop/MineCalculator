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
    public partial class NavigationStoreControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        const double SAIPs = 50;
        public NavigationStoreControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void InitCalculate()
        {
            try
            {
                SafetyLine_lbl.Text = CalculateSafteLine() + " m";
                GuideTape_Lbl.Text = CalculateGuide() + " m";
                TotalUnMarked_Lbl.Text = CalculateTotalUnmarked() + " m";
                SAIPNavParty_lbl.Text = CalculateSAIPNavParty() + " Nos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CalculateSAIPNavParty()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(double.Parse(CalculateTotalUnmarked()) / SAIPs);

            // Display the result
            return _result.ToString();

        }
        private string CalculateTotalUnmarked()
        {

            // Calculate the result using the formula
            double _result = double.Parse(CalculateSafteLine()) + double.Parse(CalculateGuide());

            // Display the result
            return _result.ToString();

        }
        private string CalculateGuide()
        {

            // Calculate the result using the formula
            double value = 2 * sharedDataModel.Depth + sharedDataModel.Frontage + 100;
            double _result = value + (value * 0.1);

            // Display the result
            return _result.ToString();

        }
        private string CalculateSafteLine()
        {

            // Calculate the result using the formula
            double value = sharedDataModel.Frontage * (sharedDataModel.Assumed_strips - 1);
            double _result = value + (value * 0.1);

            // Display the result
            return _result.ToString();

        }
    }
}
