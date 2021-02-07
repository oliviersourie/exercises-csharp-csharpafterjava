using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLib
{
   
    public class Teacher : Person
    {
        public int TeacherID { get; set; }
            
        public Teacher(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            TeacherID = id;
        }

        public Teacher()
        {

        }
    }
 
}
