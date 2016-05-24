using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Hospital_demo
{
    public static class UpdateDatabase
    {
        static string connection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                 "Data Source=MyDatabase.accdb;";
        public static string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        //updating patient
        public static void UpdatePatient(int Id, string fName, string lName, DateTime age, string address,
                   string phoneNumber, string ssn, string state, string city, int zip, string sex, string Diagnosis, string docsName, string admited, string released)
        {
            string UpdatestrSQL = "UPDATE Patient SET FirstName='" + fName + "'," +

                "LastName='" + lName + "'," +
                "Age='" + age + "'," +
                "Address='" + address + "'," +
                "City='" + city + "'," +
                "State='" + state + "'," +
                "Sex='" + sex + "'," +
                "SSN='" + ssn + "'," +
                "PhoneNumber='" + phoneNumber + "'," +
                "ZipCode=" + zip + "," +
                "Diagnosis='" + Diagnosis + "'," +
                "DoctorName='" + docsName + "'," + 
                "Admitted='" + admited + "',"+
                "Released='" + released + "'"+
                "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        public static void UpdateAdmitedReleased(int Id,  string diag, string admited, string released)
        {
            string UpdatestrSQL = "UPDATE Patient SET Diagnosis='" + diag + "'," +
                "Admitted='"  + admited + "'," +
                "Released='" + released + "'" +
                "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        public static void UpdatePatientDiagnosis(int Id, string diag)
        {
            string UpdatestrSQL = "UPDATE Patient SET Diagnosis='" + diag + "'," +
                "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //updating doctor
        public static void UpdateDoctorInfo(int Id, string fName, string lName, string address,
          string phoneNumber, string state, string city, int zip, string speciality)
        {
            string UpdatestrSQL = "UPDATE Doctor SET FirstName='" + fName + "'," +

                "LastName='" + lName + "'," +
                "Address='" + address + "'," +
                "City='" + city + "'," +
                "State='" + state + "'," +
                "ZipCode=" + zip + "," +
                "PhoneNumber='" + phoneNumber + "'," +
                "Specialty='" + speciality + "'" + "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }


        //updating admittance
        public static void UpdateAdmittance(int Id, string FirstName, string LastName, string docsName, string department,
            string diagnosis, int room, DateTime apps)
        {
            string UpdatestrSQL = "UPDATE Admission SET FirstName='" + FirstName + "'," +

                "LastName='" + LastName + "'," +
                "DoctorsName='" + docsName + "'," +
                "Department='" + department + "'," +
                "Diagnosis='" + diagnosis + "'," +
                "Room=" + room + "," +
                "Appoitment='" + apps + "'" + "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //updates when name of patient or diagnosis changed
        public static void UpdateAdmittance1(int Id, string FirstName, string LastName, string diagnosis)
        {
            string UpdatestrSQL = "UPDATE Admission SET FirstName='" + FirstName + "'," +

                "LastName='" + LastName + "'," +
                "Diagnosis='" + diagnosis + "'" + "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        public static void UpdateTheRoom(int Id, int room)
        {
            string UpdatestrSQL = "UPDATE Admission SET Room=" + room + "" +
                                  "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }
        // update release in database
        public static void UpdateRelease(int Id, string FirstName, string LastName, string diagnosis, 
            string docsName, DateTime releaseTime, int Duration, string medicine)
        {
            string UpdatestrSQL = "UPDATE Release SET FirstName='" + FirstName + "'," +

                "LastName='" + LastName + "'," +
                "Diagnosis='" + diagnosis + "',"  +
                "DoctorName='" + docsName + "'," +
                "ReleaseTime='" + releaseTime + "'," +
                "Duration=" + Duration + "," +
                "Medicine='" + medicine + "'" + "WHERE ID=" + Convert.ToInt32(Id);

            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(UpdatestrSQL, myconnection);
            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }
    }
}
