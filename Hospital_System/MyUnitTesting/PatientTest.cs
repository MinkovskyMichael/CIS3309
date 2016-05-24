using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for PatientTest and is intended
    ///to contain all PatientTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PatientTest
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
        [TestMethod()]
        public void PatientConstructorTest1()
        {
            int RecordNumber = 1; 
            string FirstName = "John"; 
            string LastName = "Doe"; 
            string Address = "Unknwon ave"; 
            string PhoneNumber = "2156666666"; 
            string State = "PA"; 
            string City = "Philadelphia"; 
            int ZipCode = 19116; 
            Patient target = new Patient(RecordNumber, FirstName, LastName, Address, PhoneNumber, State, City, ZipCode);
            Assert.AreEqual(RecordNumber,target.RecordNumber);
            Assert.AreEqual(FirstName,target.FirstName);
            Assert.AreEqual(Address,target.Address);
            Assert.AreEqual(PhoneNumber,target.PhoneNumber);
            Assert.AreEqual(State,target.State);
            Assert.AreEqual(City,target.City);
            Assert.AreEqual(ZipCode,target.ZipCode);
        }

        /// <summary>
        ///A test for Patient Constructor
        ///</summary>
        [TestMethod()]
        public void PatientConstructorTest2()
        {
            int RecordNumber = 1; 
            string FirstName = "Jane"; 
            string LastName = "Doe"; 
            DateTime Birthday = DateTime.Now;
            string Address = "Unknown ave"; 
            string PhoneNumber = "2156666666"; 
            string SocialSecurity = "666666666";
            string State = "PA"; 
            string City = "Philadelphia"; 
            int ZipCode = 19116; 
            string Sex = "f"; 
            string Diagnosis = "Sick"; 
            string AssignedTo = "Doctor"; 
            string Admitted = "Yes"; 
            string Released = "no"; 
            Patient target = new Patient(RecordNumber, FirstName, LastName, Birthday, Address, PhoneNumber, SocialSecurity, State, City, ZipCode, Sex, Diagnosis, AssignedTo, Admitted, Released);
            Assert.AreEqual(RecordNumber, target.RecordNumber);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(LastName, target.LastName);
            Assert.AreEqual(Birthday, target.Birthday);
            Assert.AreEqual(Address, target.Address);
            Assert.AreEqual(PhoneNumber, target.PhoneNumber);
            Assert.AreEqual(SocialSecurity, target.SocialSecurity);
            Assert.AreEqual(State, target.State);
            Assert.AreEqual(City, target.City);
            Assert.AreEqual(ZipCode, target.ZipCode);
            Assert.AreEqual(Sex, target.Sex);
            Assert.AreEqual(Diagnosis, target.Diagnosis);
            Assert.AreEqual(AssignedTo, target.AssignedTo);
            Assert.AreEqual(Admitted, target.Admitted);
            Assert.AreEqual(Released, target.Released);
        }

        /// <summary>
        ///A test for Patient Constructor
        ///</summary>
        [TestMethod()]
        public void PatientConstructorTest3()
        {
            string FirstName = "Unknown"; 
            string LastName = "Xaxaxa"; 
            string Diagnosis = "Dedish";
            string AssignedTo = "Some doctor";
            Patient target = new Patient(FirstName, LastName, Diagnosis, AssignedTo);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(LastName, target.LastName);
            Assert.AreEqual(Diagnosis, target.Diagnosis);
            Assert.AreEqual(AssignedTo, target.AssignedTo);
        }

        /// <summary>
        ///A test for Address
        ///</summary>
        [TestMethod()]
        public void AddressTest()
        {
            Patient target = new Patient();
            string expected = "John Doe";
            string actual;
            target.Address = expected;
            actual = target.Address;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Admitted
        ///</summary>
        [TestMethod()]
        public void AdmittedTest()
        {
            Patient target = new Patient(); 
            string expected = "Yes"; 
            string actual;
            target.Admitted = expected;
            actual = target.Admitted;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for AssignedTo
        ///</summary>
        [TestMethod()]
        public void AssignedToTest()
        {
            Patient target = new Patient();
            string expected = "Doctor";
            string actual;
            target.AssignedTo = expected;
            actual = target.AssignedTo;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for BDay
        ///</summary>
        [TestMethod()]
        public void BDayTest()
        {
            Patient target = new Patient(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.BDay = expected;
            actual = target.BDay;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Birthday
        ///</summary>
        [TestMethod()]
        public void BirthdayTest()
        {
            Patient target = new Patient(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.Birthday = expected;
            actual = target.Birthday;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for City
        ///</summary>
        [TestMethod()]
        public void CityTest()
        {
            Patient target = new Patient();
            string expected = "Philadelphia";
            string actual;
            target.City = expected;
            actual = target.City;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Diagnosis
        ///</summary>
        [TestMethod()]
        public void DiagnosisTest()
        {
            Patient target = new Patient();
            string expected = "sick"; 
            string actual;
            target.Diagnosis = expected;
            actual = target.Diagnosis;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            Patient target = new Patient();
            string expected = "John doe";
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            Patient target = new Patient(); 
            string expected = "Unknown";
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PhoneNumber
        ///</summary>
        [TestMethod()]
        public void PhoneNumberTest()
        {
            Patient target = new Patient();
            string expected = "2156666666";
            string actual;
            target.PhoneNumber = expected;
            actual = target.PhoneNumber;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for RecordNumber
        ///</summary>
        [TestMethod()]
        public void RecordNumberTest()
        {
            Patient target = new Patient(); 
            int expected = 1; 
            int actual;
            target.RecordNumber = expected;
            actual = target.RecordNumber;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Released
        ///</summary>
        [TestMethod()]
        public void ReleasedTest()
        {
            Patient target = new Patient();
            string expected = "Today";
            string actual;
            target.Released = expected;
            actual = target.Released;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Sex
        ///</summary>
        [TestMethod()]
        public void SexTest()
        {
            Patient target = new Patient();
            string expected = "M";
            string actual;
            target.Sex = expected;
            actual = target.Sex;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SocialSecurity
        ///</summary>
        [TestMethod()]
        public void SocialSecurityTest()
        {
            Patient target = new Patient();
            string expected = "666666666";
            string actual;
            target.SocialSecurity = expected;
            actual = target.SocialSecurity;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for State
        ///</summary>
        [TestMethod()]
        public void StateTest()
        {
            Patient target = new Patient();
            string expected = "PA"; ;
            string actual;
            target.State = expected;
            actual = target.State;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ZipCode
        ///</summary>
        [TestMethod()]
        public void ZipCodeTest()
        {
            Patient target = new Patient();
            int expected = 19115;
            int actual;
            target.ZipCode = expected;
            actual = target.ZipCode;
            Assert.AreEqual(expected, actual);
        }
    }
}
