using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universities
{
    public class University
    {
        public string name;
        public string city;
        public string? imagePath;
        
        public University(string name, string city) 
        {
            this.name = name;
            this.city = city;
        }

        public University(string name, string city, string filePath)
        {
            this.name = name;
            this.city = city;
            imagePath = filePath;
        }
    }
}
