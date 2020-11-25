using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class PersonModel
    {
        //init allows you to change only when creating object, or by constructor. After that is is readonly
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public PersonModel(int id)
        {
            Id = id;
        }

        public PersonModel()
        {

        }

        public PersonModel(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = LastName;

        }
    }
}
