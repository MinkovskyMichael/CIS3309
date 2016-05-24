using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for InsertToDatabaseTest and is intended
    ///to contain all InsertToDatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InsertToDatabaseTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AddAdmittanceToDatabase
        ///</summary>
        [TestMethod()]
        public void AddAdmittanceToDatabaseTest()
        {
            int Id = 1005;
            string FirstName = "John";
            string LastName = "Doe";
            string docsName = "Abramovich";
            string department = "nothing";
            string diagnosis = "Sick";
            int room = 300;
            DateTime apps = DateTime.Now;
            InsertToDatabase.AddAdmittanceToDatabase(Id, FirstName, LastName, docsName, department, diagnosis, room, apps);
            int expected = 2;
            int actual = ReadFromDatabase.readAdmittanceFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddDoctorIntoDatabase
        ///</summary>
        [TestMethod()]
        public void AddDoctorIntoDatabaseTest()
        {
            int Id = 1000;
            string fName = "Abromovich";
            string lName = "Moisha";
            string address = "unknown";
            string phoneNumber = "2156666666";
            string state = "PA";
            string city = "Philadelphia";
            int zip = 23224;
            string speciality = "awesome";
            InsertToDatabase.AddDoctorIntoDatabase(Id, fName, lName, address, phoneNumber, state, city, zip, speciality);
            int expected = 1;
            int actual = ReadFromDatabase.readDoctorFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddPatientIntoDatabase
        ///</summary>
        [TestMethod()]
        public void AddPatientIntoDatabaseTest()
        {
            int Id = 1005;
            string fName = "John";
            string lName = "Doe";
            DateTime age = DateTime.Now;
            string address = "Unknown ave";
            string phoneNumber = "2156666666";
            string ssn = "666666666";
            string state = "PA";
            string city = "Philadelphia";
            int zip = 19116;
            string sex = "f";
            string Diagnosis = "Sick";
            string docsName = "Abramovich";
            string admition = "Yes";
            string released = "No";
            InsertToDatabase.AddPatientIntoDatabase(Id, fName, lName, age, address, phoneNumber, ssn, state, city, zip, sex, Diagnosis, docsName, admition, released);
            int expected = 2;
            int actual = ReadFromDatabase.readPatientsFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AddReleaseToDatabase
        ///</summary>
        [TestMethod()]
        public void AddReleaseToDatabaseTest()
        {
            int Id = 1004;
            string FirstName = "Michael";
            string LastName = "Abdullah";
            string diagnosis = "Sick";
            string docsName = "Abram";
            DateTime releaseTime = new DateTime(2015, 11, 12);
            int Duration = 0;
            string medicine = "Suck";
            DateTime admitTime = new DateTime(2015, 11, 12);
            InsertToDatabase.AddReleaseToDatabase(Id, FirstName, LastName, diagnosis, docsName, releaseTime, Duration, medicine, admitTime);
            int expected = 2;
            int actual = ReadFromDatabase.readReleaseFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
