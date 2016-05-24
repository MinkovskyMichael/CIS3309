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
    public partial class frmRelease : Form
    {
        Engine eng = new Engine();
        public DateTime temp;

        public frmRelease()
        {
            InitializeComponent();
        }

        public frmRelease(string a, string b, string c, string d, string i, string f)
        {
            InitializeComponent();
            lblID.Text = i;
            txtFName.Text = a;
            txtLname.Text = b;
            txtDocName.Text = c;
            txtDiagnosis.Text = d;
            mTxtDOR.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now);
            temp = Convert.ToDateTime(f);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLname.Text == "" || txtDiagnosis.Text == "" || txtMedicine.Text == "" || mTxtDOR.Text =="")
            { MessageBox.Show("Please fill all the fields"); }
            else
            {
                int room = -1;
                int id = Convert.ToInt32(lblID.Text);
                UpdateDatabase.UpdateTheRoom(id, room);
                string diag = txtDiagnosis.Text;
                string admited = "YES";
                string released = "YES";
                UpdateDatabase.UpdateAdmitedReleased(id, diag, admited, released);
                string fName = txtFName.Text;
                string lName = txtLname.Text;
                string docName = txtDocName.Text;
                string medicine = txtMedicine.Text;
                DateTime a = Convert.ToDateTime(mTxtDOR.Text);
                double d = eng.DurationCalculation(id, a);
                int duration = (int)d;
                InsertToDatabase.AddReleaseToDatabase(id, fName, lName, diag, docName, a, duration, medicine, temp);
                UpdateDatabase.UpdateRelease(id, fName, lName, diag, docName, a, duration, medicine);
                DeleteFromDatabase.DeleteAdmittance(id);
                UpdateDatabase.UpdatePatientDiagnosis(id, diag);
                MessageBox.Show("Patient released");
                this.Close();
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

    }
}
