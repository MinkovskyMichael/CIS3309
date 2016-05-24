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
    public partial class frmPatientView : Form
    {
        Engine eng = new Engine();
        ListViewItem MyListViewTester = new ListViewItem();

        public frmPatientView()
        {
            InitializeComponent();
            PatientsToView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
              string a, b, c, d,s, f, g, h, i, j, k, l, m;
            if (listViewPatient.SelectedItems.Count > 0)
            {
            a = listViewPatient.SelectedItems[0].SubItems[0].Text;
            b = listViewPatient.SelectedItems[0].SubItems[1].Text;
            c = listViewPatient.SelectedItems[0].SubItems[2].Text;
            d = listViewPatient.SelectedItems[0].SubItems[3].Text;
            s = listViewPatient.SelectedItems[0].SubItems[4].Text;
            f = listViewPatient.SelectedItems[0].SubItems[5].Text;
            g = listViewPatient.SelectedItems[0].SubItems[6].Text;
            h = listViewPatient.SelectedItems[0].SubItems[7].Text;
            i = listViewPatient.SelectedItems[0].SubItems[8].Text;
            j = listViewPatient.SelectedItems[0].SubItems[9].Text;
            k = listViewPatient.SelectedItems[0].SubItems[10].Text;
            l = listViewPatient.SelectedItems[0].SubItems[11].Text;
            m = listViewPatient.SelectedItems[0].SubItems[12].Text;

                
                FrmAddPatient fa = new FrmAddPatient(a,b,c,d,s,f,g,h,i,j,k,l,m);
                fa.ShowDialog();
            }
            else { MessageBox.Show("Please select patient"); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        FrmAddPatient newPatient = new FrmAddPatient();
        newPatient.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count > 0)
            {
                DeleteFromDatabase.DeletePatient(Convert.ToInt32(listViewPatient.SelectedItems[0].SubItems[0].Text));
                PatientsToView();
            }
            else { MessageBox.Show("Please select patient"); }
        }

        public void PatientsToView()
        {
            listViewPatient.Items.Clear();
            foreach (Patient item in ReadFromDatabase.readPatientsFromDatabase())
            {
                MyListViewTester = new ListViewItem();
                MyListViewTester.Text = item.RecordNumber.ToString();

                ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                item1.Text = item.FirstName.ToString();
                MyListViewTester.SubItems.Add(item1);

                ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                item2.Text = item.LastName.ToString();
                MyListViewTester.SubItems.Add(item2);

                ListViewItem.ListViewSubItem item3 = new ListViewItem.ListViewSubItem();
                item3.Text = item.Sex.ToString();
                MyListViewTester.SubItems.Add(item3);

                ListViewItem.ListViewSubItem item4 = new ListViewItem.ListViewSubItem();
                String.Format("{0:MM/dd/yyyy}", item.Birthday);
                item4.Text = String.Format("{0:MM/dd/yyyy}", item.Birthday);
                    
                MyListViewTester.SubItems.Add(item4);

                ListViewItem.ListViewSubItem item5 = new ListViewItem.ListViewSubItem();
                item5.Text = item.SocialSecurity.ToString();
                MyListViewTester.SubItems.Add(item5);

                ListViewItem.ListViewSubItem item6 = new ListViewItem.ListViewSubItem();
                item6.Text = item.PhoneNumber.ToString();
                MyListViewTester.SubItems.Add(item6);

                ListViewItem.ListViewSubItem item7 = new ListViewItem.ListViewSubItem();
                item7.Text = item.Address.ToString();
                MyListViewTester.SubItems.Add(item7);

                ListViewItem.ListViewSubItem item8 = new ListViewItem.ListViewSubItem();
                item8.Text = item.City.ToString();
                MyListViewTester.SubItems.Add(item8);

                ListViewItem.ListViewSubItem item9 = new ListViewItem.ListViewSubItem();
                item9.Text = item.State.ToString();
                MyListViewTester.SubItems.Add(item9);

                ListViewItem.ListViewSubItem item10 = new ListViewItem.ListViewSubItem();
                item10.Text = item.ZipCode.ToString();
                MyListViewTester.SubItems.Add(item10);

                ListViewItem.ListViewSubItem item11 = new ListViewItem.ListViewSubItem();
                item11.Text = item.AssignedTo.ToString();
                MyListViewTester.SubItems.Add(item11);

                ListViewItem.ListViewSubItem item12 = new ListViewItem.ListViewSubItem();
                item12.Text = item.Diagnosis.ToString();
                MyListViewTester.SubItems.Add(item12);

                ListViewItem.ListViewSubItem item13 = new ListViewItem.ListViewSubItem();
                item13.Text = item.Admitted.ToString();
                MyListViewTester.SubItems.Add(item13);

                ListViewItem.ListViewSubItem item14 = new ListViewItem.ListViewSubItem();
                item14.Text = item.Released.ToString();
                MyListViewTester.SubItems.Add(item14);

                listViewPatient.Items.Add(MyListViewTester);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPatientView_Load(object sender, EventArgs e)
        {
            PatientsToView();
        }

        
    }
}
