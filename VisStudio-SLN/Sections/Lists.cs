using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Learning_Proj.Sections
{
    internal class Lists

    {
        public List<string> defaultList { get; set; }
        public Lists()
        {
            defaultList = new List<string>();
        }
      
    }

    internal class Dictionaries 
    {
        public Dictionary<int, string> defaultDictionary { get; set; }
        public Dictionaries()
        {
            defaultDictionary = new Dictionary<int, string>();
        }
    }

    internal class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public Students(string name, int id, int grade)
        {
            Name = name; ID = id; Grade = grade;
        }
    }
    
}
    