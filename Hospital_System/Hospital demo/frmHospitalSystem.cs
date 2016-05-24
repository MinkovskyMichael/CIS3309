using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Hospital_demo
{
    public partial class frmHospitalSystem : Form
    {
        public frmHospitalSystem()
        {
            InitializeComponent();
            string message = "What is your name?";
            string title = "Enter Name";
            string result ="";
            while (result == "")
            {
                result = Interaction.InputBox(message, title);
                if (result == "")
                {
                    MessageBox.Show("Please enter your name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
            }
            MessageBox.Show("Hello " + result + ", Welcome to the Hospital System by System inc. ");
       }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to close the program?";
            string title = "Close Program";
            DialogResult result;
            result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using the Hospital System by System inc.");
                this.Close();
            }
        }

        private void btnAddPatient_Click_1(object sender, EventArgs e)
        {
            frmPatientView PatientView = new frmPatientView();
            PatientView.ShowDialog();
        }

        private void btnAddDooctor_Click(object sender, EventArgs e)
        {
            frmDoctorView doc = new frmDoctorView();
            doc.ShowDialog();
        }

        private void btnAppoitment_Click(object sender, EventArgs e)
        {
            FrmAdmittanceView appoitment = new FrmAdmittanceView();
            appoitment.ShowDialog();
        }

        private void btnPRelease_Click(object sender, EventArgs e)
        {
            frmReleaseView newR = new frmReleaseView();
            newR.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"If there is problem with a software or you have a question please contact our company immediate: (1800)help-sys" + "\n"+ "Leading developers: Michael Minkovsky and Abullah Alwabel" +
            "\n" + "Hospital System is property of System inc." + "\n" + "Thank you for using our software", "Help Information");
        }

    }
}
