using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Universities
{
    public delegate void UniversityChanger(University university, int id);
    public delegate void UniversityCreator(University university);

    public struct University
    {
        public static int counter;
        public int id { get; set; }
        public string name { get; set; }
        public string cityName { get; set; }
        public string imagePath { get; set; }
    }
}
