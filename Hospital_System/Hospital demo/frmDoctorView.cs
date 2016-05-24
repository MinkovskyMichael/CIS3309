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
    public partial class frmDoctorView : Form
    {
        Engine eng = new Engine();
        ListViewItem MyListViewTester = new ListViewItem();

        public frmDoctorView()
        {
            InitializeComponent();
            displayDoctorToListView();
        }

        private void btnExitDoctor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            frmAddDoctor doc = new frmAddDoctor();
            doc.ShowDialog();
        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            string x, y, z, w, q, r, t, p, v;

            if (listViewDoc.SelectedItems.Count > 0)
            {
                x = listViewDoc.SelectedItems[0].SubItems[0].Text;
                y = listViewDoc.SelectedItems[0].SubItems[1].Text;
                z = listViewDoc.SelectedItems[0].SubItems[2].Text;
                w = listViewDoc.SelectedItems[0].SubItems[3].Text;
                q = listViewDoc.SelectedItems[0].SubItems[4].Text;
                r = listViewDoc.SelectedItems[0].SubItems[5].Text;
                t = listViewDoc.SelectedItems[0].SubItems[6].Text;
                p = listViewDoc.SelectedItems[0].SubItems[7].Text;
                v = listViewDoc.SelectedItems[0].SubItems[8].Text;

                frmAddDoctor modifyDoc = new frmAddDoctor(x, y, z, w, q, r, t, p, v);
                modifyDoc.ShowDialog();
            }
            else { MessageBox.Show("Please select Doctor"); }
        }

        public void displayDoctorToListView()
        {
            listViewDoc.Items.Clear();
            foreach (Doctor item in ReadFromDatabase.readDoctorFromDatabase())
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
                item3.Text = item.Address.ToString();
                MyListViewTester.SubItems.Add(item3);

                ListViewItem.ListViewSubItem item4 = new ListViewItem.ListViewSubItem();
                item4.Text = item.PhoneNumber;
                MyListViewTester.SubItems.Add(item4);

                ListViewItem.ListViewSubItem item5 = new ListViewItem.ListViewSubItem();
                item5.Text = item.State;
                MyListViewTester.SubItems.Add(item5);

                ListViewItem.ListViewSubItem item6 = new ListViewItem.ListViewSubItem();
                item6.Text = item.City;
                MyListViewTester.SubItems.Add(item6);

                ListViewItem.ListViewSubItem item7 = new ListViewItem.ListViewSubItem();
                item7.Text = item.ZipCode.ToString();
                MyListViewTester.SubItems.Add(item7);

                ListViewItem.ListViewSubItem item8 = new ListViewItem.ListViewSubItem();
                item8.Text = item.Specialty;
                MyListViewTester.SubItems.Add(item8);

                listViewDoc.Items.Add(MyListViewTester);
            }
        }

        private void frmDoctorView_Load(object sender, EventArgs e)
        {
            displayDoctorToListView();
        }

        private void btnDeleteDoc_Click(object sender, EventArgs e)
        {
            DeleteFromDatabase.DeleteDoctor(Convert.ToInt32(listViewDoc.SelectedItems[0].SubItems[0].Text));
            displayDoctorToListView();
        }
    }
}
