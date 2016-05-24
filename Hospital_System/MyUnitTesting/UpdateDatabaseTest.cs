using Hospital_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTesting
{
    
    
    /// <summary>
    ///This is a test class for UpdateDatabaseTest and is intended
    ///to contain all UpdateDatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UpdateDatabaseTest
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
        ///A test for UpdateAdmitedReleased
        ///</summary>
        [TestMethod()]
        public void UpdateAdmitedReleasedTest()
        {
            int Id = 1000; 
            string diag = "very sick"; 
            string admited = "YES"; 
            string released = "NO"; 
            UpdateDatabase.UpdateAdmitedReleased(Id, diag, admited, released);
            string expected = "very sick"; 
            string expected1= "YES"; 
            string expected2 = "NO"; 
            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                if (item.ID == Id)
                {
                    Assert.AreEqual(expected, item.Diagnosis);
                    Assert.AreEqual(expected1, item.Admitted);
                    Assert.AreEqual(expected2, item.Released);
                }
            }

        }

        /// <summary>
        ///A test for UpdateAdmittance
        ///</summary>
        [TestMethod()]
        public void UpdateAdmittanceTest()
        {
            int Id = 1001; 
            string FirstName = "Moisha"; 
            string LastName = "Mink"; 
            string docsName = "Boris Russian"; 
            string department = "ksjnf"; 
            string diagnosis = "lkjfdngsd"; 
            int room = 505;
            DateTime apps = new DateTime(2015, 11, 12); 
            UpdateDatabase.UpdateAdmittance(Id, FirstName, LastName, docsName, department, diagnosis, room, apps);
            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                if (item.ID == Id)
                {
                    Assert.AreEqual(FirstName, item.FirstName);
                    Assert.AreEqual(LastName, item.LastName);
                    Assert.AreEqual(docsName, item.AssignedTo);
                    Assert.AreEqual(department, item.Department);
                    Assert.AreEqual(diagnosis, item.Diagnosis);
                    Assert.AreEqual(room, item.Room);
                }
            }
        }

        /// <summary>
        ///A test for UpdateAdmittance1
        ///</summary>
        [TestMethod()]
        public void UpdateAdmittance1Test()
        {
            int Id = 1001; 
            string FirstName = "Abdullah"; 
            string LastName = "Abdullah"; 
            string diagnosis = "Super sick"; 
            UpdateDatabase.UpdateAdmittance1(Id, FirstName, LastName, diagnosis);
            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                if (item.ID == Id)
                {
                    Assert.AreEqual(FirstName, item.Diagnosis);
                    Assert.AreEqual(LastName, item.Admitted);
                    Assert.AreEqual(diagnosis, item.Released);
                }
            }
        }

        /// <summary>
        ///A test for UpdateDoctorInfo
        ///</summary>
        [TestMethod()]
        public void UpdateDoctorInfoTest()
        {
            int Id = 1000; 
            string fName = "Abdullah"; 
            string lName = "Alwabel"; 
            string address = "Whocares"; 
            string phoneNumber = "2156666666"; 
            string state = "PA"; 
            string city = "Philadelphia"; 
            int zip = 19115; 
            string speciality = "Super"; 
            UpdateDatabase.UpdateDoctorInfo(Id, fName, lName, address, phoneNumber, state, city, zip, speciality);
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
            {
                if (item.ID == Id)
                {
                    Assert.AreEqual(fName, item.FirstName);
                    Assert.AreEqual(lName, item.LastName);
                    Assert.AreEqual(address, item.Address);
                    Assert.AreEqual(phoneNumber, item.PhoneNumber);
                    Assert.AreEqual(state, item.State);
                    Assert.AreEqual(city, item.City);
                    Assert.AreEqual(zip, item.ZipCode);
                    Assert.AreEqual(speciality, item.Specialty);

                }
            }
        }

        /// <summary>
        ///A test for UpdatePatient
        ///</summary>
        [TestMethod()]
        public void UpdatePatientTest()
        {
            int Id = 1000;
            string fName = "Jane";
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
            string docsName = "Doctor";
            string admited = "Yes";
            string released = "no"; 
            UpdateDatabase.UpdatePatient(Id, fName, lName, age, address, phoneNumber, ssn, state, city, zip, sex, Diagnosis, docsName, admited, released);

            foreach (Patient target in ReadFromDatabase.readPatientsFromDatabase())
            {
                if (target.RecordNumber == Id)
                {
                    Assert.AreEqual(fName, target.FirstName);
                    Assert.AreEqual(lName, target.LastName);
                    Assert.AreEqual(age, target.Birthday);
                    Assert.AreEqual(address, target.Address);
                    Assert.AreEqual(phoneNumber, target.PhoneNumber);
                    Assert.AreEqual(ssn, target.SocialSecurity);
                    Assert.AreEqual(state, target.State);
                    Assert.AreEqual(city, target.City);
                    Assert.AreEqual(zip, target.ZipCode);
                    Assert.AreEqual(sex, target.Sex);
                    Assert.AreEqual(Diagnosis, target.Diagnosis);
                    Assert.AreEqual(docsName, target.AssignedTo);
                    Assert.AreEqual(admited, target.Admitted);
                    Assert.AreEqual(released, target.Released);
                }
            }
        }

        /// <summary>
        ///A test for UpdatePatientDiagnosis
        ///</summary>
        [TestMethod()]
        public void UpdatePatientDiagnosisTest()
        {
            int Id = 1000;
            string diag = "MerryCristmas";
            UpdateDatabase.UpdatePatientDiagnosis(Id, diag);
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
	{ if (item.RecordNumber == Id)
	{
        Assert.AreEqual(diag, item.Diagnosis);
         }
	}
          
        }

        /// <summary>
        ///A test for UpdateRelease
        ///</summary>
        [TestMethod()]
        public void UpdateReleaseTest()
        {
            int Id = 1000; 
            string FirstName = "Moisha"; 
            string LastName = "Mink"; 
            string diagnosis = "HealthyAsABool";
            string docsName = "Abdullah";
            DateTime releaseTime = new DateTime(2015, 11, 12); 
            int Duration = 40; 
            string medicine = "None"; 
            UpdateDatabase.UpdateRelease(Id, FirstName, LastName, diagnosis, docsName, releaseTime, Duration, medicine);
            foreach (Release item in ReadFromDatabase.readReleaseFromDatabase())
            {
                if (item.RecordNumber == Id)
                {
                    Assert.AreEqual(FirstName, item.FirstName);
                    Assert.AreEqual(LastName, item.LastName);
                    Assert.AreEqual(diagnosis, item.Diagnosis);
                    Assert.AreEqual(docsName, item.DoctorName);
                    Assert.AreEqual(releaseTime, item.ReleaseTime);
                    Assert.AreEqual(Duration, item.Duration);
                    Assert.AreEqual(medicine, item.Medicine);
                }
            }
        }

        /// <summary>
        ///A test for UpdateTheRoom
        ///</summary>
        [TestMethod()]
        public void UpdateTheRoomTest()
        {
            int Id = 1000; 
            int room = 500; 
            UpdateDatabase.UpdateTheRoom(Id, room);

            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                if (item.ID == Id)
                    Assert.AreEqual(room, item.Room);
            }


        }

    }
}
