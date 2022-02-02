using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student student1 = new Student("Michal", "Sima", " Harry Potter 1");
            Student student2 = new Student("Janka", "Novakova", " Harry Potter 2");
            Student student3 = new Student("Andrej", "Potocnak", " Harry Potter 3");
            Student student4 = new Student("Matej", "Seman", " Harry Potter 4");

            Teacher teacher1 = new Teacher("Janko", "Hrasko", 1000);
            Teacher teacher2 = new Teacher("Jozef", "Mrkvicka", 1500);
            Teacher teacher3 = new Teacher("Jane", "Doe", 1250);

            Console.WriteLine("Students: ");
            Console.WriteLine(student1.DisplayName());
            Console.WriteLine(student2.DisplayName());
            Console.WriteLine(student3.DisplayName());
            Console.WriteLine(student4.DisplayName());

            Console.WriteLine();

            Console.WriteLine("Teachers: ");
            Console.WriteLine(teacher1.DisplayName());
            Console.WriteLine(teacher2.DisplayName());
            Console.WriteLine(teacher3.DisplayName());
            */
        //    Console.WriteLine();
        //    student1.DisplayToConsoleDirectly();

            /*som chcel aby uzivatel zadal udaje ale nepodarilo sa mi spravit pole pre datovy typ Student 
             * plus som chcel aby cez for loop sa spravili vypisy aby som nemusel kazdeho jedneho cloveka osobitne kodovat
             * 
             */ 
            Student[] student = new Student[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter first name of {0}. student: ", i + 1);
                string FirstName = Console.ReadLine();
                Console.Write("Enter last name of {0}. student: ", i + 1);
                string LastName = Console.ReadLine();
                student[i] = new Student(FirstName, LastName);
                Console.WriteLine();
            }

            Console.WriteLine();

            Teacher[] teacher = new Teacher[3];
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter first name of {0}. teacher: ", j + 1);
                string FirstName = Console.ReadLine();
                Console.Write("Enter last name of {0}. teacher: ", j + 1);
                string LastName = Console.ReadLine();
                teacher[j] = new Teacher(FirstName, LastName);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Students are: ");
            for(int i = 0; i < 4 ; i++)
            {
                student[i].DisplayToConsoleDirectly();
            }

            Console.WriteLine();
            Console.WriteLine("Teachers are: ");
            for (int j = 0; j < 3; j++)
            {
                teacher[j].DisplayToConsoleDirectly();
            }
            Console.ReadKey();
        }
    }
}
