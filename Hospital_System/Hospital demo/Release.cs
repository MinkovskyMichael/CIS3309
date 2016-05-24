using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_demo
{
    public class Release 
    {
        int recordNumber;
        DateTime admittedTime;
        DateTime releaseTime;
        int duration;
        string medicine;
        string firstName;
        string lastName;
        string diagnosis;
        string doctorName;


        public DateTime ReleaseTime
        {
            get { return releaseTime; }
            set { releaseTime = value; }
        }

        public DateTime AdmitedTime
        {
            get { return admittedTime; }
            set { admittedTime = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public int RecordNumber
        {
            get { return recordNumber; }
            set { recordNumber = value; }
        }

        public string Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        public Release() { }

        public Release(int RecordNumber, string FirstName, string LastName, string Diagnosis, string DoctorName, DateTime ReleaseTime, int Duration, string Medicine, DateTime AdmittedTime )
        {
            recordNumber = RecordNumber;
            firstName = FirstName;
            lastName = LastName;
            diagnosis = Diagnosis;
            doctorName = DoctorName;
            releaseTime = ReleaseTime;
            duration = Duration;
            medicine = Medicine;
            admittedTime = AdmittedTime;
        }
    }
}
