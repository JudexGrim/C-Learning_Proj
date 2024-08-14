using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Learning_Proj.Sections
{
    internal class Inheritence
    {
        
    }

    internal class ParentClass
    {
        public int Prop1 { get; set; }
        public string Prop2 { get; set; }

        public ParentClass(int prop1, string prop2)
        {
            Prop1 = prop1;
            Prop2 = prop2;
            Console.WriteLine("Parent Class Constructor Called, " + Prop1 + " - " + Prop2);
        }
    }

    internal class ChildClass1: ParentClass
    {
        public ChildClass1(int childProp1, string childProp2): base(childProp1, childProp2)
        {
            Console.WriteLine("Child1 Class Constructor Called, " + Prop1 + " - " + Prop2);
        }
    }

    internal class ChildClass2: ParentClass
    {
        public ChildClass2(int childProp1, string childProp2) : base(childProp1, childProp2)
        {
            Prop1 = childProp1;
            Console.WriteLine("Child1 Class Constructor Called, " + this.Prop1 + " - " + this.Prop2);
        }
    }
}
