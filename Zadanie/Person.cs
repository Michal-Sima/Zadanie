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


        // metoda public string DisplayName() ma velmi podobnu funkcionalitu ako public void DisplayToConsoleDirectly(),
        // preto ju netreba
        /*public string DisplayName() // momentally not used
        {
            return (FirstName + " " + LastName);
        }*/

        public void DisplayToConsoleDirectly()
        {
            Console.WriteLine("This is print from under the hood: ");
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine();
        }

    }
}
