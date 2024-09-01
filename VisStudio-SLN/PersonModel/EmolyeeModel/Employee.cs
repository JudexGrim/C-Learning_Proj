using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.PersonModel.EmolyeeModel
{
    internal class Employee : Person
    {
        public string Role { get; set; }
        public float Salary { get; set; }

        public Employee(string firstName, string lastName, string role, float salary) : base(firstName, lastName)
        {
            Role = role;
            Salary = salary;
        }
    }
   
}
