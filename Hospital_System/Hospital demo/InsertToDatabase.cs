using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Hospital_demo
{
    public static class InsertToDatabase
    {

        static string connection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                 "Data Source=MyDatabase.accdb;";
        public static string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        //adding patient to database
        public static void AddPatientIntoDatabase(int Id, string fName, string lName, DateTime age, string address,
            string phoneNumber, string ssn, string state, string city, int zip, string sex, string Diagnosis, string docsName, string admition, string released)
        {
            string strSQL = "INSERT INTO Patient (ID, FirstName, LastName, Age, Address, City, State, Sex, SSN, PhoneNumber, ZipCode, Diagnosis, DoctorName, Admitted, Released) " +
                "VALUES ('" +
                 Id + "','" +
                 fName + "','" +
                 lName + "','" +
                 age + "','" +
                 address + "','" +
                 city + "','" +
                 state + "','" +
                 sex + "','" +
                 ssn + "','" +
                 phoneNumber + "'," +
                 zip + ",'" +
                 Diagnosis + "','" +
                 docsName + "','"+
                 admition + "','"+
                 released + "')";


            OleDbConnection myconnection = new OleDbConnection(Connection);
            OleDbCommand InsertCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //adding doctor to database 

        public static void AddDoctorIntoDatabase(int Id, string fName, string lName, string address,
           string phoneNumber, string state, string city, int zip, string speciality)
        {
            string strSQL = "INSERT INTO Doctor (ID, FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Specialty) " +
                "VALUES ('" +
                 Id + "','" +
                 fName + "','" +
                 lName + "','" +
                 address + "','" +
                 city + "','" +
                 state + "'," +
                 zip + ",'" +
                 phoneNumber + "','" +
                 speciality + "')";


            OleDbConnection myconnection = new OleDbConnection(Connection);
            OleDbCommand InsertCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }


        //adding Admittance to database
        public static void AddAdmittanceToDatabase(int Id, string FirstName, string LastName, string docsName, string department, string diagnosis, int room, DateTime apps)
        {
            string strSQL = "INSERT INTO Admission (ID, FirstName, LastName, DoctorsName, Department, Room, Diagnosis, Appoitment) " +
                "VALUES ('" +
                 Id + "','" +
                 FirstName + "','" +
                 LastName + "','" +
                 docsName + "','" +
                 department + "'," +
                 room + ",'" +
                 diagnosis + "','" +
                 apps + "')";


            OleDbConnection myconnection = new OleDbConnection(Connection);
            OleDbCommand InsertCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        public static void AddReleaseToDatabase(int Id, string FirstName, string LastName, string diagnosis, string docsName, DateTime releaseTime, int Duration, string medicine, DateTime admitTime)
        {
            string strSQL = "INSERT INTO Release (ID, FirstName, LastName, Diagnosis, DoctorName, AdmitedTime, ReleaseTime, Duration, Medicine) " +
                "VALUES ('" +
                 Id + "','" +
                 FirstName + "','" +
                 LastName + "','" +
                 diagnosis + "','" +
                 docsName + "','" +
                 admitTime + "','" +
                 releaseTime + "'," +
                 Duration + ",'" +
                 medicine + "')";


            OleDbConnection myconnection = new OleDbConnection(Connection);
            OleDbCommand InsertCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }
    }
}
