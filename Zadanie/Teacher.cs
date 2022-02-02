using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{ 
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Teacher(string FirstName, string LastName, int Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
        }

        public Teacher(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string DisplayName()
        {
            return (FirstName + " " + LastName);
        }

        public void DisplayToConsoleDirectly()
        {
            Console.WriteLine("This is print from under the hood: ");
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine();
        }

    }
}
