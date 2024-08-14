using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.Sections
{
    internal class Dependancy1
    {
        public string DependacyName { get; set; }

        public void Method()
        {
            Console.WriteLine("Dependancy1 method");
        }
    }

    internal class Dependancy2
    {
        public int DependancyInt { get; set; }  

        public void Method()
        {
            Console.WriteLine("Dependancy2 method");
        }
    }

    internal class DIExample
    {
        public  Dependancy1 Dep1 { get; set; }
        public Dependancy2 Dep2 { get; set; }
        public void SetterExample()
        {
            Console.WriteLine(Dep1.DependacyName);
            Console.WriteLine(Dep2.DependancyInt);
        }
    }

    
}
