using DesktopApp.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.HelperClass
{
    public class NavigationControl
    {
        public List<UserControl> userControlList = new List<UserControl>();
        Panel panel;
        UserControl notfoundControl = new ViewNotFound();
        public NavigationControl(List<UserControl> _userControlList,Panel _panel)
        {
            this.userControlList = _userControlList;
            this.panel = _panel;
            AddContorls();
        }

        private void AddContorls()
        {
            for(int i = 0; i < this.userControlList.Count; i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]); 
            }
            notfoundControl.Dock = DockStyle.Fill;
            panel.Controls.Add(notfoundControl);
        }
        public void Display(int index)
        {
            if(index<userControlList.Count)
            {
                userControlList[index].BringToFront();
            }
            else
            {
                notfoundControl.BringToFront();
            }
        }
        
    }
}
