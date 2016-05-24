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
    public partial class frmAddDoctor : Form
    {
        Engine eng = new Engine();
        public frmAddDoctor(string x, string y, string z, string w, string q, string r, string t, string p, string v)
        {
            InitializeComponent();
            lblID.Text = x;
            txtFName.Text = y;
            txtLname.Text = z;
            mTxtPNumber.Text = w;
            txtAddress.Text = q;
            cmbState.Text = r;
            txtCity.Text = t;
            mTxtZip.Text = p;
            txtSpeciality.Text  = v;
        }
        public frmAddDoctor()
        {
            InitializeComponent();
            lblID.Text = eng.returnDoctorsHighestID().ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLname.Text == "" || mTxtPNumber.Text == "" || txtAddress.Text == "" || cmbState.Text == "" ||
                txtCity.Text == "" || mTxtZip.Text == "" || txtSpeciality.Text == "")
            { MessageBox.Show("Please fill all the required information!"); }
            else
            {
                int id = Convert.ToInt32(lblID.Text);
                string fName = txtFName.Text;
                string lName = txtLname.Text;
                string Pnumber = mTxtPNumber.Text;
                string address = txtAddress.Text;
                string state = cmbState.SelectedItem.ToString();
                string city = txtCity.Text;
                int zip = Convert.ToInt32(mTxtZip.Text);
                string specialty = txtSpeciality.Text;
                InsertToDatabase.AddDoctorIntoDatabase(id, fName, lName, address, Pnumber, state, city, zip, specialty);
                UpdateDatabase.UpdateDoctorInfo(id, fName, lName, Pnumber, address, state, city, zip, specialty);
                MessageBox.Show("Doctor information was successfully add/modified!");
            }

        }

        private void frmTxtBox_Validating(object sender, CancelEventArgs e)
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

        private void mskBox_Validating(object sender, CancelEventArgs e)
        {
            int value;
            MaskedTextBox Tbox = (MaskedTextBox)sender;
            
            if (int.TryParse(Tbox.Text, out value) == false || Tbox.Text.Length < 5)
            {
                MyErrorProvider.SetError(Tbox, "This field can not be empty or have less than 5 digits! " );
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

            if(long.TryParse(mTxtPNumber.Text, out value) == true || GetDigits(mTxtPNumber.Text).Length != 10)
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

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {

            if (txtAddress.Text == ""  )
            {
                MyErrorProvider.SetError(txtAddress, "This field can not be empty");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(txtAddress, "");
                e.Cancel = false;
            }
        }

        private void cmbState_Validating(object sender, CancelEventArgs e)
        {
            if (cmbState.Text == "")
            {
                MyErrorProvider.SetError(cmbState, "This field can not be empty");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(cmbState, "");
                e.Cancel = false;
            }
        }

    }
}
