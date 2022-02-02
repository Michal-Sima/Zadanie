using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{ 
    public class Teacher: Person
    {

        public int Salary { get; set; }

        public Teacher(string FirstName, string LastName, int Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary; // momentally not used
        }

        public Teacher(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

    }
}
