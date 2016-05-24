using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for AdmittanceTest and is intended
    ///to contain all AdmittanceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AdmittanceTest
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
        ///A test for Admittance Constructor
        ///</summary>
        [TestMethod()]
        public void AdmittanceConstructorTest1()
        {
            int ID = 10; 
            string FirstName = "Jane"; 
            string LastName = "Doe"; 
            string AssignedTo = "Doctor"; 
            string Department = "Radialogy"; 
            int Room = 500; 
            string Diagnosis = "Nothing"; 
            DateTime AdmittanceDate = DateTime.Now; 
            Admittance target = new Admittance(ID, FirstName, LastName, AssignedTo, Department, Room, Diagnosis, AdmittanceDate);
            Assert.AreEqual(ID, target.ID);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(LastName, target.LastName);
            Assert.AreEqual(AssignedTo, target.AssignedTo);
            Assert.AreEqual(Department, target.Department);
            Assert.AreEqual(Room, target.Room);
            Assert.AreEqual(Diagnosis, target.Diagnosis);
            Assert.AreEqual(AdmittanceDate, target.AdmittanceDate);
        }

        /// <summary>
        ///A test for Admittance Constructor
        ///</summary>
        [TestMethod()]
        public void AdmittanceConstructorTest2()
        {
            int ID = 50; 
            string FirstName = "Jane"; 
            string LastName = "Done"; 
            string AssignedTo = "noOne"; 
            string Department = "department"; 
            string Diagnosis = "C# sicness"; 
            DateTime AdmittanceDate = DateTime.Now; 
            Admittance target = new Admittance(ID, FirstName, LastName, AssignedTo, Department, Diagnosis, AdmittanceDate);
            Assert.AreEqual(ID, target.ID);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(LastName, target.LastName);
            Assert.AreEqual(AssignedTo, target.AssignedTo);
            Assert.AreEqual(Department, target.Department);
            Assert.AreEqual(Diagnosis, target.Diagnosis);
            Assert.AreEqual(AdmittanceDate, target.AdmittanceDate);
        }

        /// <summary>
        ///A test for AdmittanceDate
        ///</summary>
        [TestMethod()]
        public void AdmittanceDateTest()
        {
            Admittance target = new Admittance(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.AdmittanceDate = expected;
            actual = target.AdmittanceDate;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Department
        ///</summary>
        [TestMethod()]
        public void DepartmentTest()
        {
            Admittance target = new Admittance(); 
            string expected = "C# Department"; 
            string actual;
            target.Department = expected;
            actual = target.Department;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Admittance target = new Admittance(); 
            int expected = 500; 
            int actual;
            target.ID = expected;
            actual = target.ID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Room
        ///</summary>
        [TestMethod()]
        public void RoomTest()
        {
            Admittance target = new Admittance(); 
            int expected = 110; 
            int actual;
            target.Room = expected;
            actual = target.Room;
            Assert.AreEqual(expected, actual);
        }
    }
}
