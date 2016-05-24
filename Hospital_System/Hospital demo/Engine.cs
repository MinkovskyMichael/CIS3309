using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace Hospital_demo
{
   public class Engine
    {
        Patient customer = new Patient();
        Doctor doctor = new Doctor();
        Admittance admittance = new Admittance();
        Release release = new Release();
       List<Release> rel= new List<Release>();
         List<Patient> custy = new List<Patient>();
        List<Doctor> doc = new List<Doctor>();
        List<Admittance> app = new List<Admittance>();
 

       
        int id;
        double duration;
        DateTime begin;
        bool available = false;
        bool exist = false;


       public bool Available
       {
           get { return available; }
           set {available = value; }
       }

       public bool Exist
       {
           get { return exist; }
           set { exist = value; }
       }

        public List<Release> Rel
        {
            get { return rel; }
        }

        public DateTime Begin
        {
            get { return begin; }
            set { begin = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public List<Patient> Custy
        {
            get { return custy; }
        }

        public List<Doctor> Doc
        {
            get { return doc; }
        }

        public List<Admittance> App
        {
            get { return app; }
        }

        

        public string PatientDetailedinfo(int id)
        {
            string patientInfo = "";
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
            {
                if (item.RecordNumber == id)
                {
                    patientInfo += "Record Number: " + item.RecordNumber + " " + "\n" + "First Name: " + item.FirstName + " " + "\n" + "Last Name: " + 
                        item.LastName + " " + "\n" +"DOB: " + item.Birthday.ToShortDateString() + " " + "\n" + "Sex: " + item.Sex + "\n" + "SSN " + item.SocialSecurity +  "\n" +
                       "Street Name: " + item.Address + "\n" + "State: " +  item.State + "\n" +"City: " + item.City + "\n"+ "Zip Code: " +
                       item.ZipCode + "\n"+ "Diagnosis: " + item.Diagnosis + "\n" +
                        "Doctor's Name:"+" " + item.AssignedTo + "\n" + "Patient Admitted: " + item.Admitted + "\n" + "Patient Released: "+ item.Released;
                  }
            }
            return patientInfo;
        }
        public int returnHighestID()
        {
            int num = 999;
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
            {
                if (item.RecordNumber >= num) { num = item.RecordNumber; }  
            }
            return num + 1;
        }

        public bool IsSocialExist(string ssn)
        {
            exist = false;
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
            {
                if (item.SocialSecurity.Equals(ssn))
                {
                    exist = true; break;
                }
            }
            return exist;
        }

        public bool IsAdmitted(int id)
        {
            available = false;
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
            {
                if (item.RecordNumber == id && item.Admitted == "YES" && item.Released == "NO") { available = true; break; }
            }

            return available;
        }
       // doctors code is here

       

        public string DoctorDetailedInfo(string name)
        {
            string text = "";
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
            {

                if (item.FirstName + " " + item.LastName == name)
                {
                    text += "ID: " + item.ID + "\n" + "First Name: " + item.FirstName + "\n" + "Last Name: " + item.LastName
                       + "\n" + "Street Name: " + item.Address + "\n" + "City: " + item.City + "\n" + "State: " + item.State +
                       "\n" + "Zip Code: " + item.ZipCode + "\n" + "Phone Number: " + item.PhoneNumber + "\n" + "Spaciality: " + item.Specialty;
                }

            }

            return text;
        }

        public int returnDoctorsHighestID()
        {
            int num = 999;
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
            {
                if (item.RecordNumber >= num) num = item.RecordNumber;
            }
            return num + 1;
        }



        //admittance programing starts from here:
       
       public bool checkTheRoomAvalilable(int room)
       {
           available = false;
           foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
           {
               if (item.Room == room) { available = true; break; }
           }
           return available;
       }



       // release programming start here

        public int returnReleaseHighestID()
        {
            int num = 999;
            foreach (Release item in ReadFromDatabase.readReleaseFromDatabase())
            {
                if (item.RecordNumber >= num) num = item.RecordNumber;
            }
            return num + 1;
        }

        public double DurationCalculation(int recordNumber, DateTime releaseTime)
        {
            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                if (item.ID == recordNumber)
                {
                    begin = item.AdmittanceDate;
                    break;
                }
            }

            double duration = (releaseTime - begin).TotalDays;
            return duration;
        }
    
    }
}
