using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Model
{
    internal class UtilModel
    {
    }
    public class DropDownModel
    {
        public string Label { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Label;
        }
    }

    public class dataGridTabelColumns {
        public string DistanceFrom { get; set; }
        public string DistanceTo { get; set; }
        public string Distance { get; set; }
        public string GRef { get; set; }
        public string Bearing { get; set; }
    }

}
