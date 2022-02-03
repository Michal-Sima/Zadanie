using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Director: Teacher
    {
        string Title { get; set; }

        public Director(string FirstName, string LastName, int Salary, string Title)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
            this.Title = Title;
        }
    }
}
