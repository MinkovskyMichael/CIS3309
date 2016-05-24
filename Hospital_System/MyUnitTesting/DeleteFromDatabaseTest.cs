using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for DeleteFromDatabaseTest and is intended
    ///to contain all DeleteFromDatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DeleteFromDatabaseTest
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
        ///A test for DeleteAdmittance
        ///</summary>
        [TestMethod()]
        public void DeleteAdmittanceTest()
        {
            int id = 1000; 
            DeleteFromDatabase.DeleteAdmittance(id);
            int expected = 2;
            int actual = ReadFromDatabase.readAdmittanceFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DeleteDoctor
        ///</summary>
        [TestMethod()]
        public void DeleteDoctorTest()
        {
            int id = 1000; 
            DeleteFromDatabase.DeleteDoctor(id);
            int expected = 0;
            int actual = ReadFromDatabase.readDoctorFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DeletePatient
        ///</summary>
        [TestMethod()]
        public void DeletePatientTest()
        {
            int id = 1000;
            DeleteFromDatabase.DeletePatient(id);
            int expected = 2;
            int actual = ReadFromDatabase.readPatientsFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DeleteRelease
        ///</summary>
        [TestMethod()]
        public void DeleteReleaseTest()
        {
            int id = 1000; 
            DeleteFromDatabase.DeleteRelease(id);
            int expected = 2;
            int actual = ReadFromDatabase.readReleaseFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

    }
}
