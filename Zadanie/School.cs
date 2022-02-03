using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    class School
    {
        int MaximumNumberOfStudents;
        int ActualNumberOfStudents;
        string NameOfSchool;

        public School(string NameOfSchool, int MaximumNumberOfStudents)
        {
            this.NameOfSchool = NameOfSchool;
            this.MaximumNumberOfStudents = MaximumNumberOfStudents;
        }

        void AddNewStudent()
        {
            if (ActualNumberOfStudents == MaximumNumberOfStudents)
            {
                Console.WriteLine("School have full capacity of students, so I do not add new student to school!");
            }
            else
            {
                ActualNumberOfStudents++;
            }          
        }
        void RemoveStudent()
        {
            ActualNumberOfStudents--;
        }

        int GetNumberOfStudentsMultipliedByX()
        {
            this.ActualNumberOfStudents = ActualNumberOfStudents;
            Console.WriteLine("Actual number of student is: {0}.", ActualNumberOfStudents);
            Console.WriteLine("Enter number to multiplication: ");
            int x = Int32.Parse(Console.ReadLine());
            return x * ActualNumberOfStudents;
        }

        void DisplayAllStudents()
        {

        }

        void DisplayNameAndMaxNumberOfStudents()
        {
            Console.WriteLine("Name of school is: {0}.", NameOfSchool);
            Console.WriteLine("Maximum capacity of number of students is: {0}.", MaximumNumberOfStudents);
        }
    }
}
