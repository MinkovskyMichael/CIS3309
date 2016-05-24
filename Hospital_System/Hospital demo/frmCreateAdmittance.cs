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
    public partial class frmCreateAdmittance : Form
    {
        Engine eng = new Engine();

        public frmCreateAdmittance(string a, string y, string z, string w, string q, string r, string t, string p)
        {
            InitializeComponent();
            AddDoctorToDropBox();
            lblID.Text = a.ToString() ;
            txtFName.Text = y.ToString();
            txtLname.Text = z.ToString();
            cobDocName.Text = r.ToString();
            maskedTxtRoom.Text = q.ToString();
            mTxtDOA.Text = p.ToString();
            comBoxDepartment.Text = w.ToString();
            txtDiagnosis.Text = t.ToString();
            AddDoctorToDropBox();
        }
        public frmCreateAdmittance(string a, string b, string c)
        {
            InitializeComponent();
            AddDoctorToDropBox();
            lblID.Text = a;
            txtFName.Text = b;
            txtLname.Text = c;
        }

        private void AddDoctorToDropBox()
        {
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
            {
                cobDocName.Items.Add(item.FirstName + " " + item.LastName);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            string diag = txtDiagnosis.Text;
            int id = Convert.ToInt32(lblID.Text);
            if (txtFName.Text == "" || txtLname.Text == "" || cobDocName.Text == "" || comBoxDepartment.Text == "" || maskedTxtRoom.Text == "" ||
                mTxtDOA.Text == "")
            { MessageBox.Show("All fields except Diagnosis are required fields.\n Please check the fields and field them out!"); }
            else
            {
                string admited = "YES";
                string released = "NO";
                UpdateDatabase.UpdateAdmitedReleased(id, diag, admited, released);
                string fName = txtFName.Text;
                string lName = txtLname.Text;
                string docName = cobDocName.SelectedItem.ToString();
                string dep = comBoxDepartment.SelectedItem.ToString();
                int room = Convert.ToInt32(maskedTxtRoom.Text);
                DateTime a = Convert.ToDateTime(mTxtDOA.Text);
                DateTime doa = a.Date;
                InsertToDatabase.AddAdmittanceToDatabase(id, fName, lName, docName, dep, diag, room, doa);
                UpdateDatabase.UpdateAdmittance(id, fName, lName, docName, dep, diag, room, doa);
                MessageBox.Show("Patient admitted");
                this.Close();
            }

        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblID.Text);
            MessageBox.Show(eng.PatientDetailedinfo(id));
        }

        private void btnDocInfo_Click(object sender, EventArgs e)
        {
            if (cobDocName.SelectedItem == null)
            {
                MessageBox.Show("Please Select The doctor");
            }
            else
            {
                string name = cobDocName.SelectedItem.ToString();
                MessageBox.Show(eng.DoctorDetailedInfo(name));
            }
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

        private void maskedTxtRoom_Validating(object sender, CancelEventArgs e)
        {
            int value = Convert.ToInt32(maskedTxtRoom.Text);

            if (maskedTxtRoom.Text == "" || value < 1 || eng.checkTheRoomAvalilable(value) == true)
            {
                MyErrorProvider.SetError(maskedTxtRoom, "This field can not be empty or this room is not available");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(maskedTxtRoom, "");
                e.Cancel = false;
            }
        }

        private void mTxtDOA_Validating(object sender, CancelEventArgs e)
        {
            DateTime a = Convert.ToDateTime(mTxtDOA.Text);
            double temp=(DateTime.Now - a).TotalDays;
            if(temp> 365) // done for testing purposes only
            {
                MyErrorProvider.SetError(mTxtDOA, "Date can not be over 365 days in the past");
                e.Cancel = true;
            }
            else
            {
                MyErrorProvider.SetError(mTxtDOA, "");
                e.Cancel = false;
            }
        }


        
    }
}
