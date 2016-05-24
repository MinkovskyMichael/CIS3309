using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_demo
{
   public class Patient
    {
        int recordNumber;
        string firstName;
        string lastName;
        DateTime birthDay;
        string address;
        string phoneNumber;
        string socialSecurity;
        string state;
        string city;
        int zipCode;
        string sex ;
        string diagnosis;
        string assignedTo = "";
        DateTime bDay;
        string admitted ;
        string released ;

        public Patient(){}

        // constractor for inheretance
        public Patient(int RecordNumber, string FirstName, string LastName,
            string Address, string PhoneNumber, string State, string City, int ZipCode )
        {
            recordNumber = RecordNumber;
            firstName = FirstName;
            lastName = LastName;
            address = Address;
            phoneNumber = PhoneNumber;
            state = State;
            city = City;
            zipCode = ZipCode;
        }
        // constractor for list
        public Patient(int RecordNumber, string FirstName, string LastName,
            DateTime Birthday, string Address, string PhoneNumber, string SocialSecurity, string State,
            string City, int ZipCode, string Sex, string Diagnosis, string AssignedTo, string Admitted, string Released)
        {
            recordNumber = RecordNumber;
            firstName = FirstName;
            lastName = LastName;
            birthDay = Birthday;
            address = Address;
            phoneNumber = PhoneNumber;
            socialSecurity = SocialSecurity;
            state = State;
            city = City;
            zipCode = ZipCode;
            sex = Sex;
            diagnosis = Diagnosis;
            assignedTo = AssignedTo;
            admitted = Admitted;
            released = Released;
        }

        //constractor for appoitment
        public Patient(string FirstName, string LastName, string Diagnosis, string AssignedTo)
        {
            firstName = FirstName;
            lastName = LastName;
            diagnosis = Diagnosis;
            assignedTo = AssignedTo;
        }

        public int RecordNumber
        {
            get {return recordNumber;}
            set { recordNumber = value; }
        }

        public string FirstName
        {
            get {return firstName ;}
            set {firstName = value ;}
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
   
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }
        public DateTime Birthday
        {
            get { return birthDay; }
            set {
                  birthDay = value; 
                }
        }

        public DateTime BDay
        {
            get { return bDay; }
            set { bDay = value; }
        }
        public string SocialSecurity
        {
            get { return socialSecurity; }
            set { socialSecurity = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { PhoneNumber = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string AssignedTo
        {
            get { return assignedTo; }
            set { assignedTo = value; }
        }

        public string Admitted
        {
            get { return admitted; }
            set { admitted = value; }
        }

        public string Released
        {
            get { return released; }
            set { released = value; }
        }
    }
}
