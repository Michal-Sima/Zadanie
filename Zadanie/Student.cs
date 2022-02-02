using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    public class Student: Person
    {
        public string FavouriteBookName{ get; set; }

        public Student(string FirstName, string LastName, string FavouriteBookName) //konstruktory odovodenych tried nefunguju v zakladnych triedach, preto ich treba manualne napisat do odvodenych tried 
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

    }

}
