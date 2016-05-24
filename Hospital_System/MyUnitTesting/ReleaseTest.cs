using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for ReleaseTest and is intended
    ///to contain all ReleaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ReleaseTest
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
        ///A test for Release Constructor
        ///</summary>
        [TestMethod()]
        public void ReleaseConstructorTest1()
        {
            int RecordNumber = 10;
            string FirstName = "John";
            string LastName = "Doe";
            string Diagnosis = "Sick";
            string DoctorName = "Unknown";
            DateTime ReleaseTime = DateTime.Now;
            int Duration = 50;
            string Medicine = "Cocain";
            DateTime AdmittedTime = DateTime.Now; 
            Release target = new Release(RecordNumber, FirstName, LastName, Diagnosis, DoctorName, ReleaseTime, Duration, Medicine, AdmittedTime);
            Assert.AreEqual(RecordNumber, target.RecordNumber);
            Assert.AreEqual(FirstName, target.FirstName);
            Assert.AreEqual(Diagnosis, target.Diagnosis);
            Assert.AreEqual(DoctorName, target.DoctorName);
            Assert.AreEqual(ReleaseTime, target.ReleaseTime);
            Assert.AreEqual(Duration, target.Duration);
            Assert.AreEqual(Medicine, target.Medicine);
            Assert.AreEqual(AdmittedTime, target.AdmitedTime);
        }

        /// <summary>
        ///A test for AdmitedTime
        ///</summary>
        [TestMethod()]
        public void AdmitedTimeTest()
        {
            Release target = new Release(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.AdmitedTime = expected;
            actual = target.AdmitedTime;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Diagnosis
        ///</summary>
        [TestMethod()]
        public void DiagnosisTest()
        {
            Release target = new Release();
            string expected = "Sick";
            string actual;
            target.Diagnosis = expected;
            actual = target.Diagnosis;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for DoctorName
        ///</summary>
        [TestMethod()]
        public void DoctorNameTest()
        {
            Release target = new Release(); 
            string expected ="unknwon"; 
            string actual;
            target.DoctorName = expected;
            actual = target.DoctorName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Duration
        ///</summary>
        [TestMethod()]
        public void DurationTest()
        {
            Release target = new Release(); 
            int expected = 50; 
            int actual;
            target.Duration = expected;
            actual = target.Duration;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            Release target = new Release(); 
            string expected = "John"; 
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
            Release target = new Release(); 
            string expected = "Doe"; 
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Medicine
        ///</summary>
        [TestMethod()]
        public void MedicineTest()
        {
            Release target = new Release(); 
            string expected = "SickAsShit"; 
            string actual;
            target.Medicine = expected;
            actual = target.Medicine;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for RecordNumber
        ///</summary>
        [TestMethod()]
        public void RecordNumberTest()
        {
            Release target = new Release();
            int expected = 1000; 
            int actual;
            target.RecordNumber = expected;
            actual = target.RecordNumber;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ReleaseTime
        ///</summary>
        [TestMethod()]
        public void ReleaseTimeTest()
        {
            Release target = new Release(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.ReleaseTime = expected;
            actual = target.ReleaseTime;
            Assert.AreEqual(expected, actual);
        }
    }
}
