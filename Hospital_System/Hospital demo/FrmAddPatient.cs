using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_demo
{
    public partial class FrmAddPatient : Form
    {
        Engine eng = new Engine();
        
        public FrmAddPatient()
        {
            InitializeComponent();
            lblID.Text = eng.returnHighestID().ToString();
            AddDoctorToDropBox();
            mTxtSSN.PasswordChar = '*';
        }
        
        public FrmAddPatient(string a, string b, string c, string d, string s, string f, string g,
            string h, string i, string j, string k, string l, string m)
        {
            InitializeComponent();
            mTxtSSN.PasswordChar = '*';
            lblID.Text = a;
            txtFName.Text = b;
            txtLname.Text = c;
            mTxtDOB.Text = s;
            mTxtSSN.Text = f;
            mTxtPNumber.Text = g;
            txtAddress.Text = h;
            cmbState.Text = j;
            txtCity.Text = i;
            mTxtZip.Text = k.ToString();
            RadioButtonCheck(d);
            AddDoctorToDropBox();
        }
        private void RadioButtonCheck(string d)
        {
            if (d.Equals("F"))
            { this.rdnF.Checked = true; }
            else { this.rdnM.Checked = true; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDoctorToDropBox()
        {
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
            {
                cmbDocName.Items.Add(item.FirstName + " " + item.LastName);
            }

        }
        private char getradiobutton()
        {
            char sex = ' ';
            bool isChecked = rdnF.Checked;
            if (isChecked)
                sex = Convert.ToChar(rdnF.Text);
            else
                sex = Convert.ToChar(rdnM.Text);
            return sex;
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            TextBox Tbox = (TextBox)sender;

            if (int.TryParse(Tbox.Text, out value) == true || Tbox.Text == "")
            {
                MyErrorProvider.SetError(Tbox, "This field can not be empty or have numbers!");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(Tbox, "");
                e.Cancel = false;
            }
        }
        private void mTxtPNumber_Validating(object sender, CancelEventArgs e)
        {
            long value;

            if (long.TryParse(mTxtPNumber.Text, out value) == true || GetDigits(mTxtPNumber.Text).Length != 10)
            {
                MyErrorProvider.SetError(mTxtPNumber, "This field can not be empty or less than 10 digits");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(mTxtPNumber, "");
                e.Cancel = false;
            }
        }

        private string GetDigits(string phoneNumber)
        {
            string PhoneNumber = "";

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (Char.IsDigit(phoneNumber[i]))
                    PhoneNumber += phoneNumber[i];
            }

            return PhoneNumber;
        }

        private void mTxtDOB_Validating(object sender, CancelEventArgs e)
        {
            DateTime a = Convert.ToDateTime(mTxtDOB.Text);
            DateTime today = DateTime.Today;
            int duration = today.Year - a.Year;

            if (a > DateTime.Now || duration > 120)
            {
                MyErrorProvider.SetError(mTxtDOB, "Date can not be in the past");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(mTxtDOB, "");
                e.Cancel = false;
            }
        }

        private void mTxtSSN_Validating(object sender, CancelEventArgs e)
        {
            if (eng.IsSocialExist(mTxtSSN.Text) == true || mTxtSSN.Text == "")
            {
                MyErrorProvider.SetError(mTxtSSN, "SSN can't be empty or it already exists");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(mTxtSSN, "");
                e.Cancel = false;
            }
        }

        private void comBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.Text == "")
            {
                MyErrorProvider.SetError(combo, "This field can not be empty");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(combo, "");
                e.Cancel = false;
            }
        }

        private void mskZip_Validating(object sender, CancelEventArgs e)
        {
            int value;
            MaskedTextBox Tbox = (MaskedTextBox)sender;

            if (int.TryParse(Tbox.Text, out value) == false || Tbox.Text.Length < 5 || Tbox.Text == "")
            {
                MyErrorProvider.SetError(Tbox, "This field can not be empty or have less than 5 digits! ");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(Tbox, "");
                e.Cancel = false;
            }
        }

        private void rdnButton_Validating(object sender, CancelEventArgs e)
        {
            bool isChecked = rdnF.Checked;
            bool isChecked1 = rdnM.Checked;
            if (isChecked ==false && isChecked1 == false )
            {
                MyErrorProvider.SetError(gBoxSex, "Please selecy sex!");
                e.Cancel = true;
            }

            else
            {
                MyErrorProvider.SetError(gBoxSex, "");
                e.Cancel = false;
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLname.Text == "" || mTxtDOB.Text == "" || mTxtSSN.Text == "" || mTxtPNumber.Text == "" ||
                txtAddress.Text == "" || cmbState.Text == "" || txtCity.Text == "" || mTxtZip.Text == "")
            { MessageBox.Show("Fields: First Name, Last Name , Date of Birthday, SSN, Phone Number, Address, State, City , Zip Code, Sex: ARE REQUIERED FIELDS"); }
            else
            {
                int id = Convert.ToInt32(lblID.Text);
                string fName = txtFName.Text;
                string lName = txtLname.Text;
                DateTime dob = Convert.ToDateTime(mTxtDOB.Text);
                DateTime age = dob.Date;
                string ssn = mTxtSSN.Text;
                string Pnumber = mTxtPNumber.Text;
                char Sex = getradiobutton();
                string sex = Sex.ToString();
                string address = txtAddress.Text;
                string state = cmbState.SelectedItem.ToString();
                string city = txtCity.Text;
                int zip = Convert.ToInt32(mTxtZip.Text);
                string diag;
                if (txtDiagnosis.Text == null) { diag = " "; }
                else { diag = txtDiagnosis.Text; }
                string doc;
                if (cmbDocName.SelectedIndex > 0) { doc = cmbDocName.SelectedItem.ToString(); }
                else { doc = " "; }
                string admition = "NO";
                string released = "NO";
                InsertToDatabase.AddPatientIntoDatabase(id, fName, lName, age, address, Pnumber, ssn, state, city, zip, sex, diag, doc, admition, released);
                MessageBox.Show("Patient added/modified to database!");
                int ID = Convert.ToInt32(lblID.Text);
                lblID.Text = eng.returnHighestID().ToString();
                UpdateDatabase.UpdatePatient(id, fName, lName, age, address, Pnumber, ssn, state, city, zip, sex, diag, doc, admition, released);
                UpdateDatabase.UpdateAdmittance1(id, fName, lName, diag);
                ClearAllTheFields();
            }
        }

        public void ClearAllTheFields()
        {
            txtFName.Text = ""; 
            txtLname.Text = "" ; 
            mTxtDOB.Text = ""; 
            mTxtSSN.Text = "" ; 
            mTxtPNumber.Text = "" ;
            txtAddress.Text = ""; 
            cmbState.Text = "";
            txtCity.Text = ""; 
            mTxtZip.Text = "";
            txtDiagnosis.Text = "";
            cmbDocName.Text ="";
        }
    }
}
