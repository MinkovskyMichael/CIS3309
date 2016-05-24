using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_demo
{
   public class Doctor : Patient
    {

       string specialty;
       int id;

        public Doctor(int ID, string FirstName, string LastName,
             string Address, string PhoneNumber, string State, string City, int ZipCode, string Specialty)
            : base(ID, FirstName, LastName, Address, PhoneNumber, State, City, ZipCode)
        {
            id = ID;
            specialty = Specialty;
        }

        public Doctor() { }

        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
