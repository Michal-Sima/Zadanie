using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName()
        {
            return (FirstName + " " + LastName);
        }

        public void DisplayToConsoleDirectly()
        {
            //Console.WriteLine("This is print from under the hood: ");
            Console.WriteLine(DisplayName());
            Console.WriteLine();
        }

    }
}
