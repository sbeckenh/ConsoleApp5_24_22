using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5_24_22;

namespace ConsoleApp5_24_22
{
    public class Person : ConsoleApp5._24._22.FirstName
    {
        // properties
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string Email { get; set; }

        //methods {behavior}
        public void DisplayName()
        {
            Console.WriteLine("Hello, my name is: " + firstName + " " + lastName);
        }

        public void DisplayEmail()
        {
            Console.WriteLine("Email address: " + "{" + Email + "}");
        }
    }
}








