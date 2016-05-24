using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_demo
{
    public class Admittance : Patient
    {
        int id;
        DateTime admittanceDate;
        string department;
        int room;

            public Admittance()
            {
                
            }
            public Admittance(int ID, string FirstName, string LastName, string AssignedTo, string Department, int Room,
                string Diagnosis, DateTime AdmittanceDate)
                : base(FirstName, LastName, Diagnosis, AssignedTo)
            {
                id = ID;
                admittanceDate = AdmittanceDate;
                room = Room;
                department = Department;
            }

            public Admittance(int ID, string FirstName, string LastName, string AssignedTo, string Department,
                    string Diagnosis, DateTime AdmittanceDate)
                : base(FirstName, LastName, Diagnosis, AssignedTo)
            {
                id = ID;
                admittanceDate = AdmittanceDate;
                department = Department;
            }


            public string Department
            {
                get { return department; }
                set { department = value; }
            }

            public DateTime AdmittanceDate
            {
                get { return admittanceDate; }
                set { admittanceDate = value; }
            }

            public int ID
            {
                get { return id; }
                set {id = value;}
            }

            public int Room
            {
                get { return room; }
                set { room = value; }
            }
    }
}
