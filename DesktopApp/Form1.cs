using DesktopApp.HelperClass;
using DesktopApp.Model;
using DesktopApp.UserControls;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {

        bool SideBarExpend = true;
        NavigationControl navigationControl;
        private Button activeButton;
        SharedDataModel sharedDataModel = new SharedDataModel();
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> list = new List<UserControl>() { new MineCalculationControl(sharedDataModel), new AccessoriesControl(sharedDataModel) };
            navigationControl = new NavigationControl(list, mainPanel);
            activeButton = MineCalculation_btn;
            SetActiveButton(0, activeButton);
        }

        private void SetActiveButton(int displayControlIndex, Button button)
        {
            navigationControl.Display(displayControlIndex);
            button.BackColor = SystemColors.Control;
            activeButton = button;
        }

        private void SetInactiveButton(Button button)
        {
            button.BackColor = Color.Transparent;
        }
        private void menuToggleTick(object sender, EventArgs e)
        {
            if (SideBarExpend)
            {
                sidePanel.Width -= 10;
                if (sidePanel.MinimumSize.Width == sidePanel.Width)
                {
                    SideBarExpend = false;
                    sidebar_Timer.Stop();
                }
            }
            else
            {
                sidePanel.Width += 10;
                if (sidePanel.MaximumSize.Width == sidePanel.Width)
                {
                    SideBarExpend = true;
                    sidebar_Timer.Stop();
                }
            }
        }

        private void menu_toggle_btn_Click(object sender, EventArgs e)
        {
            sidebar_Timer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            SetInactiveButton(activeButton);
            SetActiveButton(0, clickedButton);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            AccessoriesControl userControl = GetInstance<AccessoriesControl>();

            if (userControl != null)
            {
                userControl.CalculateAccessories();
            }
            SetInactiveButton(activeButton);
            SetActiveButton(1, clickedButton);
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            MineCalculationControl userControl = GetInstance<MineCalculationControl>();
            if (userControl != null)
            {
                userControl.Run_btn_Click();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            MineCalculationControl userControl = GetInstance<MineCalculationControl>();
            if (userControl != null)
            {
                userControl.Reset_btn_Click();
            }
        }

        private T GetInstance<T>() where T : UserControl
        {
            foreach (Control control in navigationControl.userControlList)
            {
                if (control is T userControl)
                {
                    return userControl;
                }
            }
            return null;
        }
    }
}