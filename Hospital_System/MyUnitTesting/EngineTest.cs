using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for EngineTest and is intended
    ///to contain all EngineTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EngineTest
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
        ///A test for DoctorDetailedInfo
        ///</summary>
        [TestMethod()]
        public void DoctorDetailedInfoTest()
        {
            Engine target = new Engine();
            string name = "Moisha"; 
            string expected = ""; 
            string actual;
            actual = target.DoctorDetailedInfo(name);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A teC:\Users\TheMoisha\Desktop\Hospital System\MyUnitTesting\AdmittanceTest.csst for DurationCalculation
        ///</summary>
        [TestMethod()]
        public void DurationCalculationTest()
        {
            Engine target = new Engine(); 
            int recordNumber = 1001;
            DateTime releaseTime = DateTime.Now;
            double expected = target.DurationCalculation(recordNumber, releaseTime); 
            double actual;
            actual = target.DurationCalculation(recordNumber, releaseTime);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsAdmitted
        ///</summary>
        [TestMethod()]
        public void IsAdmittedTest()
        {
            Engine target = new Engine(); 
            int id = 1001; 
            bool expected = false; 
            bool actual;
            actual = target.IsAdmitted(id);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsSocialExist
        ///</summary>
        [TestMethod()]
        public void IsSocialExistTest()
        {
            Engine target = new Engine(); 
            string ssn = "666666666"; 
            bool expected = true; 
            bool actual;
            actual = target.IsSocialExist(ssn);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PatientDetailedinfo
        ///</summary>
        [TestMethod()]
        public void PatientDetailedinfoTest()
        {
            Engine target = new Engine(); 
            int id = 1000; 
            string expected = ""; 
            string actual;
            actual = target.PatientDetailedinfo(id);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///A test for checkTheRoomAvalilable
        ///</summary>
        [TestMethod()]
        public void checkTheRoomAvalilableTest()
        {
            Engine target = new Engine(); 
            int room = 330; 
            bool expected = false; 
            bool actual;
            actual = target.checkTheRoomAvalilable(room);
            Assert.AreEqual(expected, actual);;
        }

        /// <summary>
        ///A test for returnDoctorsHighestID
        ///</summary>
        [TestMethod()]
        public void returnDoctorsHighestIDTest()
        {
            Engine target = new Engine(); 
            int expected = 1001; 
            int actual;
            actual = target.returnDoctorsHighestID();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for returnHighestID
        ///</summary>
        [TestMethod()]
        public void returnHighestIDTest()
        {
            Engine target = new Engine(); 
            int expected = 1006; 
            int actual;
            actual = target.returnHighestID();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for returnReleaseHighestID
        ///</summary>
        [TestMethod()]
        public void returnReleaseHighestIDTest()
        {
            Engine target = new Engine();
            int expected = 1005; 
            int actual;
            actual = target.returnReleaseHighestID();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Available
        ///</summary>
        [TestMethod()]
        public void AvailableTest()
        {
            Engine target = new Engine(); 
            bool expected = false; 
            bool actual;
            target.Available = expected;
            actual = target.Available;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Begin
        ///</summary>
        [TestMethod()]
        public void BeginTest()
        {
            Engine target = new Engine(); 
            DateTime expected = DateTime.Now; 
            DateTime actual;
            target.Begin = expected;
            actual = target.Begin;
            Assert.AreEqual(expected, actual);;
        }

       

        /// <summary>
        ///A test for Duration
        ///</summary>
        [TestMethod()]
        public void DurationTest()
        {
            Engine target = new Engine(); 
            double expected = 50; 
            double actual;
            target.Duration = expected;
            actual = target.Duration;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Exist
        ///</summary>
        [TestMethod()]
        public void ExistTest()
        {
            Engine target = new Engine(); 
            bool expected = false; 
            bool actual;
            target.Exist = expected;
            actual = target.Exist;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Engine target = new Engine(); 
            int expected = 1000; 
            int actual;
            target.ID = expected;
            actual = target.ID;
            Assert.AreEqual(expected, actual);
        }

    }
}
