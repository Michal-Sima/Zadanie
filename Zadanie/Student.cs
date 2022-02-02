using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavouriteBookName{ get; set; }

        public Student(string FirstName, string LastName, string FavouriteBookName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FavouriteBookName = FavouriteBookName;
        }

        public Student(string FirstName, string LastName)
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
