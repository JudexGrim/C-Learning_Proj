using Learning_Proj.PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj.Validator
{
    internal class PersonValidator
    {
        public bool ValidateName (Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName)) return true;
            else ReturnInvalid("First Name");

            if (string.IsNullOrWhiteSpace(person.LastName))  return true; 
            else ReturnInvalid("Last Name");

            return false;
        }

        
    }
}
