using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Proj
{
    internal class StandardMessaging
    {
        public static void EntryMessage(string entry)
        {
            Console.WriteLine($"Please Enter {entry}");
        }
        public static void EndMessage()
        {
            Console.WriteLine("Perss Any Key to Exit");
        }
        public void ReturnInvalid(string term)
        {
            Console.WriteLine($"Invalid {term}");
        }
    }
}
