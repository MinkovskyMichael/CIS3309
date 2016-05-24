using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for DoctorTest and is intended
    ///to contain all DoctorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoctorTest
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
        ///A test for Doctor Constructor
        ///</summary>
        [TestMethod()]
        public void DoctorConstructorTest()
        {
            int ID = 0; 
            string FirstName = "Doctor"; 
            string LastName = "Last Name"; 
            string Address = "Unknown ave"; 
            string PhoneNumber = "2156666666"; 
            string State = "NJ"; 
            string City = "Trenton"; 
            int ZipCode = 23224; 
            string Specialty = "Shitty one"; 
            Doctor target = new Doctor(ID, FirstName, LastName, Address, PhoneNumber, State, City, ZipCode, Specialty);
            Assert.AreEqual(ID, target.ID);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(Address, target.Address);
            Assert.AreEqual(PhoneNumber, target.PhoneNumber);
            Assert.AreEqual(State, target.State);
            Assert.AreEqual(City, target.City);
            Assert.AreEqual(ZipCode, target.ZipCode);
            Assert.AreEqual(Specialty, target.Specialty);
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Doctor target = new Doctor(); 
            int expected = 1000; 
            int actual;
            target.ID = expected;
            actual = target.ID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Specialty
        ///</summary>
        [TestMethod()]
        public void SpecialtyTest()
        {
            Doctor target = new Doctor(); 
            string expected = "NONE";
            string actual;
            target.Specialty = expected;
            actual = target.Specialty;
            Assert.AreEqual(expected, actual);
        }
    }
}
