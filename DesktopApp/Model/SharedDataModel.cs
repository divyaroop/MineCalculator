using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Model
{
    public class SharedDataModel
    {
        public bool IsMineCalculated { get; set; }
        public double Anit_Pers_Mines { get; set; }
        public double Anti_Tank_Mines { get; set; }
        public double Anit_Mines_16 { get; set; }
        public double No_of_Mine { get; set; }
        public double Rate_Of_Laying { get; set; }
        public double MLPs_Required { get; set; }
        public double Nmm_14 { get; set; }
        public double ND_Mk_1 { get; set; }
        public double M_16_frag { get; set; }
        public double strips_A_Per { get; set; }
        public double A_tk_strips { get; set; }
        public double frag_strips { get; set; }

        public void Reset()
        {
            IsMineCalculated = false;
            Anit_Mines_16 = 0;
            Anit_Pers_Mines = 0;
            Anti_Tank_Mines = 0;
            No_of_Mine = 0;
            Rate_Of_Laying = 0;
            MLPs_Required = 0;
            Nmm_14 = 0;
            ND_Mk_1 = 0;
            M_16_frag = 0;
            strips_A_Per = 0;
            A_tk_strips = 0;
            frag_strips = 0;
        }

    }
}
