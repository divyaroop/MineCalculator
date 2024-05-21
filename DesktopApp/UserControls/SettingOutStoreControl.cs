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
    public partial class SettingOutStoreControl : UserControl
    {
        SharedDataModel sharedDataModel = new SharedDataModel();
        
        public SettingOutStoreControl(SharedDataModel _sharedDataModel)
        {
            this.sharedDataModel = _sharedDataModel;
            InitializeComponent();
        }
        public void InitCalculate()
        {
            try
            {

                MarkedTape_lbl.Text = CalculateMarkedTape() + " m";
                UnMarkedTape_lbl.Text = CalculateUnMarkedTape() + " Nos";
                SSM_ESM_Lbl.Text = sharedDataModel.Assumed_strips.ToString();
                TP_Lbl.Text = CalculateTP();
                DP_Lbl.Text = TP_Lbl.Text;
                IP_Lbl.Text = CalculateIP();
                totat_sum_SAIP_lbl.Text = CalculateTotalSum() + " Nos";
                sharedDataModel.totat_sum_SAIP = double.Parse(CalculateTotalSum());
                Total_SAIP_Lbl.Text = CalculateTotalSAIP() + " Nos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalculateMarkedTape()
        {

            // Calculate the result using the formula
            double value = ((sharedDataModel.Assumed_strips + 1) * sharedDataModel.Frontage);
            double _result = value + (value * 0.1);

            // Display the result
            return _result.ToString();

        }
        private string CalculateTotalSAIP()
        {

            // Calculate the result using the formula
            double value = sharedDataModel.totat_sum_SAIP * sharedDataModel.Assumed_strips;
            double _result = Math.Ceiling(value + (value * 0.1));

            // Display the result
            return _result.ToString();

        }
        private string CalculateTotalSum()
        {

            // Calculate the result using the formula
            double _result = double.Parse(TP_Lbl.Text) + double.Parse(SSM_ESM_Lbl.Text) + double.Parse(DP_Lbl.Text) + double.Parse(IP_Lbl.Text);

            // Display the result
            return _result.ToString();

        }
        private string CalculateTP()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(((sharedDataModel.Frontage / 150) - 1));

            // Display the result
            return _result.ToString();

        }
        private string CalculateIP()
        {

            // Calculate the result using the formula
            double _result = Math.Ceiling(((sharedDataModel.Frontage / 150) * 2));

            // Display the result
            return _result.ToString();

        }
        private string CalculateUnMarkedTape()
        {

            // Calculate the result using the formula
            double value = ((sharedDataModel.Inf_Safe_Line + sharedDataModel.VSL) * sharedDataModel.Depth);
            double _result = Math.Ceiling(value + (value * 0.1));

            // Display the result
            return _result.ToString();

        }
    }
}
