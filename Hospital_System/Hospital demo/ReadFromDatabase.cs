using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Hospital_demo
{
   public static class ReadFromDatabase
    {
       static List<Patient> custy;
       static List<Doctor> doc;
       static List<Admittance> app;
       static List<Release> rel;



        static string connection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=MyDatabase.accdb;";
        public static string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public static List<Release> Rel
        {
            get { return rel; }
        }

        public static List<Patient> Custy
        {
            get { return custy; }
        }

        public static List<Doctor> Doc
        {
            get { return doc; }
        }

        public static List<Admittance> App
        {
            get { return app; }
        }

       //read from patient database
        public static List<Patient> readPatientsFromDatabase()
        {
            custy = new List<Patient>();
            string sstrSQL = "SELECT * FROM Patient ORDER BY ID";
            OleDbConnection myConnection = new OleDbConnection(Connection);
            OleDbCommand selectCommand = new OleDbCommand(sstrSQL, myConnection);
            OleDbDataReader myDataReader;
            Patient newPatient;
            try
            {
                myConnection.Open();
                myDataReader = selectCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    int Id = Convert.ToInt32(myDataReader["ID"]);
                    string FirstName = myDataReader["FirstName"].ToString();
                    string LastName = myDataReader["LastName"].ToString();
                    DateTime age = Convert.ToDateTime(myDataReader["Age"]);
                    string address = myDataReader["Address"].ToString();
                    string city = myDataReader["City"].ToString();
                    string state = myDataReader["State"].ToString();
                    string sex = myDataReader["Sex"].ToString();
                    string ssn = myDataReader["SSN"].ToString();
                    string phoneNumber = myDataReader["PhoneNumber"].ToString();
                    int zip = Convert.ToInt32(myDataReader["ZipCode"]);
                    string diagnosis = myDataReader["Diagnosis"].ToString();
                    string doc = myDataReader["DoctorName"].ToString();
                    string admited = myDataReader["Admitted"].ToString();
                    string released = myDataReader["Released"].ToString();

                    newPatient = new Patient(Id, FirstName, LastName, age, address, phoneNumber, ssn, state, city, zip,
                        sex, diagnosis, doc, admited, released);
                    Custy.Add(newPatient);
                }
            }
            catch (OleDbException)
            { }
            finally { myConnection.Close(); }

            return Custy;
        }

       //read from doctor database
        public static List<Doctor> readDoctorFromDatabase()
        {
            doc = new List<Doctor>();
            string sstrSQL = "SELECT * FROM Doctor ORDER BY ID";
            OleDbConnection myConnection = new OleDbConnection(Connection);
            OleDbCommand selectCommand = new OleDbCommand(sstrSQL, myConnection);
            OleDbDataReader myDataReader;
            Doctor newDoctor;
            try
            {
                myConnection.Open();
                myDataReader = selectCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    int Id = Convert.ToInt32(myDataReader["ID"]);
                    string FirstName = myDataReader["FirstName"].ToString();
                    string LastName = myDataReader["LastName"].ToString();
                    string address = myDataReader["Address"].ToString();
                    string city = myDataReader["City"].ToString();
                    string state = myDataReader["State"].ToString();
                    string phoneNumber = myDataReader["PhoneNumber"].ToString();
                    int zip = Convert.ToInt32(myDataReader["ZipCode"]);
                    string specialty = myDataReader["Specialty"].ToString();

                    newDoctor = new Doctor(Id, FirstName, LastName, address, phoneNumber, state, city, zip,
                        specialty);
                    doc.Add(newDoctor);
                }
            }
            catch (OleDbException)
            { }
            finally { myConnection.Close(); }

            return doc;
        }

        //read admittance from database
        public static List<Admittance> readAdmittanceFromDatabase()
        {
            app = new List<Admittance>();
            string sstrSQL = "SELECT * FROM Admission ORDER BY ID";
            OleDbConnection myConnection = new OleDbConnection(Connection);
            OleDbCommand selectCommand = new OleDbCommand(sstrSQL, myConnection);
            OleDbDataReader myDataReader;
            Admittance newAppoitment;
            try
            {
                myConnection.Open();
                myDataReader = selectCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    int Id = Convert.ToInt32(myDataReader["ID"]);
                    string FirstName = myDataReader["FirstName"].ToString();
                    string LastName = myDataReader["LastName"].ToString();
                    string docsName = myDataReader["DoctorsName"].ToString();
                    string department = myDataReader["Department"].ToString();
                    int room = Convert.ToInt32(myDataReader["Room"].ToString());
                    string diagnosis = myDataReader["Diagnosis"].ToString();
                    DateTime apps = Convert.ToDateTime(myDataReader["Appoitment"]);
                    newAppoitment = new Admittance(Id, FirstName, LastName, docsName, department, room, diagnosis, apps);
                    app.Add(newAppoitment);
                }
            }
            catch (OleDbException)
            { }
            finally { myConnection.Close(); }

            return app;
        }

       //read from Realease table

        public static List<Release> readReleaseFromDatabase()
        {
            rel = new List<Release>();
            string sstrSQL = "SELECT * FROM Release ORDER BY ID";
            OleDbConnection myConnection = new OleDbConnection(Connection);
            OleDbCommand selectCommand = new OleDbCommand(sstrSQL, myConnection);
            OleDbDataReader myDataReader;
            Release newRelease;
            try
            {
                myConnection.Open();
                myDataReader = selectCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    int Id = Convert.ToInt32(myDataReader["ID"]);
                    string FirstName = myDataReader["FirstName"].ToString();
                    string LastName = myDataReader["LastName"].ToString();
                    string diagnosis = myDataReader["Diagnosis"].ToString();
                    string docsName = myDataReader["DoctorName"].ToString();
                    DateTime admitionTime = Convert.ToDateTime(myDataReader["AdmitedTime"]);
                    DateTime releaseTime = Convert.ToDateTime(myDataReader["ReleaseTime"]);
                    int duration = Convert.ToInt32(myDataReader["Duration"]);
                    string medicine = myDataReader["Medicine"].ToString();
                    newRelease = new Release(Id, FirstName, LastName, diagnosis,docsName, releaseTime, duration, medicine, admitionTime);
                    rel.Add(newRelease);
                }
            }
            catch (OleDbException)
            { }
            finally { myConnection.Close(); }

            return rel;
        }
    }
}
