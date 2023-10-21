using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Universities
{

    public struct University
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cityName { get; set; }
    }
}
