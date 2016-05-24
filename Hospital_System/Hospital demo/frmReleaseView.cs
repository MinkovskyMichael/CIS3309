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
    public partial class frmReleaseView : Form
    {
        Engine eng = new Engine();
        ListViewItem MyListViewTester = new ListViewItem();

        public frmReleaseView()
        {
            InitializeComponent();
            displayAppoitmentToListView();
            displayReleaseToView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void displayAppoitmentToListView()
        {
            listViewAdmition.Items.Clear();
            foreach (Admittance item in ReadFromDatabase.readAdmittanceFromDatabase())
            {
                MyListViewTester = new ListViewItem();
                MyListViewTester.Text = item.ID.ToString();

                ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                item1.Text = item.FirstName.ToString();
                MyListViewTester.SubItems.Add(item1);

                ListViewItem.ListViewSubItem item2 = new ListViewItem.ListViewSubItem();
                item2.Text = item.LastName.ToString();
                MyListViewTester.SubItems.Add(item2); 

                ListViewItem.ListViewSubItem item3 = new ListViewItem.ListViewSubItem();
                item3.Text = item.AssignedTo.ToString();
                MyListViewTester.SubItems.Add(item3);

                ListViewItem.ListViewSubItem item4 = new ListViewItem.ListViewSubItem();
                item4.Text = item.Department.ToString();
                MyListViewTester.SubItems.Add(item4);

                ListViewItem.ListViewSubItem item5 = new ListViewItem.ListViewSubItem();
                item5.Text = item.Room.ToString();
                MyListViewTester.SubItems.Add(item5);

                ListViewItem.ListViewSubItem item6 = new ListViewItem.ListViewSubItem();
                item6.Text = item.Diagnosis;
                MyListViewTester.SubItems.Add(item6);

                ListViewItem.ListViewSubItem item7 = new ListViewItem.ListViewSubItem();
                item7.Text = String.Format("{0:MM/dd/yyyy}", item.AdmittanceDate);
                MyListViewTester.SubItems.Add(item7);


                listViewAdmition.Items.Add(MyListViewTester);
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
                    string a, b, c, d, i, f;
            if (listViewAdmition.SelectedItems.Count > 0)
            {
                i = listViewAdmition.SelectedItems[0].SubItems[0].Text;
                a = listViewAdmition.SelectedItems[0].SubItems[1].Text;
                b = listViewAdmition.SelectedItems[0].SubItems[2].Text;
                c = listViewAdmition.SelectedItems[0].SubItems[3].Text;
                d = listViewAdmition.SelectedItems[0].SubItems[6].Text;
                f = listViewAdmition.SelectedItems[0].SubItems[7].Text;
                frmRelease newRelease = new frmRelease(a, b, c, d, i, f);
                newRelease.ShowDialog();
            }
            else { MessageBox.Show("Please select amitted patient"); }
            
        }


        public void displayReleaseToView()
        {
            listViewRelease.Items.Clear();
            foreach (Release item in ReadFromDatabase.readReleaseFromDatabase())
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
                item3.Text = String.Format("{0:MM/dd/yyyy}", item.AdmitedTime); 
                MyListViewTester.SubItems.Add(item3);

                ListViewItem.ListViewSubItem item8 = new ListViewItem.ListViewSubItem();
                item8.Text = item.AdmitedTime.ToString();
                MyListViewTester.SubItems.Add(item8);

                ListViewItem.ListViewSubItem item4 = new ListViewItem.ListViewSubItem();
                item4.Text = String.Format("{0:MM/dd/yyyy}" ,item.ReleaseTime);
                MyListViewTester.SubItems.Add(item4);

                ListViewItem.ListViewSubItem item5 = new ListViewItem.ListViewSubItem();
                item5.Text = item.Duration.ToString() + " Days";
                MyListViewTester.SubItems.Add(item5);

                ListViewItem.ListViewSubItem item6 = new ListViewItem.ListViewSubItem();
                item6.Text = item.Diagnosis;
                MyListViewTester.SubItems.Add(item6);

                ListViewItem.ListViewSubItem item7 = new ListViewItem.ListViewSubItem();
                item7.Text = item.Medicine.ToString();
                MyListViewTester.SubItems.Add(item7);


                listViewRelease.Items.Add(MyListViewTester);
            }
        }

        private void frmReleaseView_Load(object sender, EventArgs e)
        {
            displayReleaseToView();
            displayAppoitmentToListView();
        }




    }
}
