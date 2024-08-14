using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_Reader
{
    internal class Entry
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Salary { get; set; }

        public void DisplayEntry() 
        {
            Console.WriteLine(ID + "\t" + Name+ "\t\t\t" + Role + "\t\t\t\t" + Salary);
        }
    
    }
    
}
