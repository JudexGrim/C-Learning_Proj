using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.PersonModel
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;
        }

    }
}
