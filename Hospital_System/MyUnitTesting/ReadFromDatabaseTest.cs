using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for ReadFromDatabaseTest and is intended
    ///to contain all ReadFromDatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ReadFromDatabaseTest
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
        ///A test for readAdmittanceFromDatabase
        ///</summary>
        [TestMethod()]
        public void readAdmittanceFromDatabaseTest()
        {
            int expected = 2;
            int actual;
            actual = ReadFromDatabase.readAdmittanceFromDatabase().Count;
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for readDoctorFromDatabase
        ///</summary>
        [TestMethod()]
        public void readDoctorFromDatabaseTest()
        {
            int expected = 1;
            int actual;
            actual = ReadFromDatabase.readDoctorFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for readPatientsFromDatabase
        ///</summary>
        [TestMethod()]
        public void readPatientsFromDatabaseTest()
        {
            int expected = 2;
            int actual;
            actual = ReadFromDatabase.readPatientsFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for readReleaseFromDatabase
        ///</summary>
        [TestMethod()]
        public void readReleaseFromDatabaseTest()
        {
            int expected = 2; 
            int actual;
            actual = ReadFromDatabase.readReleaseFromDatabase().Count;
            Assert.AreEqual(expected, actual);
        }

    }
}
