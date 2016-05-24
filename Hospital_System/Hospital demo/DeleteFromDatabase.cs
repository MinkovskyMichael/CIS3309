using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Hospital_demo
{
    public static class DeleteFromDatabase
    {

        static string connection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=MyDatabase.accdb;";
        public static string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        //delete patient from database
        public static void DeletePatient(int id)
        {
            string strSQL = "DELETE FROM Patient WHERE ID=" + id;
            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //delete doctor from database
        public static void DeleteDoctor(int id)
        {
            string strSQL = "DELETE FROM Doctor WHERE ID=" + id;
            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //delete Admittance from database

        public static void DeleteAdmittance(int id)
        {
            string strSQL = "DELETE FROM Admission WHERE ID=" + id;
            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(strSQL, myconnection);

            try
            {
                myconnection.Open();
                UpdateCommand.ExecuteNonQuery();
            }
            catch (OleDbException) { }
            catch (SystemException) { }
            finally { myconnection.Close(); }
        }

        //delete release from database
        public static void DeleteRelease(int id)
        {
            string strSQL = "DELETE FROM Release WHERE ID=" + id;
            OleDbConnection myconnection = new OleDbConnection(connection);
            OleDbCommand UpdateCommand = new OleDbCommand(strSQL, myconnection);

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
