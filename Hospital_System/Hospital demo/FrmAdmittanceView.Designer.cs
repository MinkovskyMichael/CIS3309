namespace Hospital_demo
{
    partial class FrmAdmittanceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmittanceView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.listViewPatient = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cZip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDocsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAssigned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncAdmission = new System.Windows.Forms.Button();
            this.Admission = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditAdmission = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.listViewAdmission = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteApp = new System.Windows.Forms.Button();
            this.btnEditAppoitment = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Admission.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Admission);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1375, 710);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.listViewPatient);
            this.tabPage1.Controls.Add(this.btncAdmission);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1367, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1201, 607);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewPatient
            // 
            this.listViewPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cFirstName,
            this.cLastName,
            this.cSex,
            this.cDOB,
            this.cSSN,
            this.cPhoneNumber,
            this.cAddress,
            this.cCity,
            this.cState,
            this.cZip,
            this.cDocsName,
            this.cAssigned,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPatient.FullRowSelect = true;
            this.listViewPatient.GridLines = true;
            this.listViewPatient.Location = new System.Drawing.Point(0, 0);
            this.listViewPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewPatient.Name = "listViewPatient";
            this.listViewPatient.Size = new System.Drawing.Size(1366, 599);
            this.listViewPatient.TabIndex = 9;
            this.listViewPatient.UseCompatibleStateImageBehavior = false;
            this.listViewPatient.View = System.Windows.Forms.View.Details;
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 80;
            // 
            // cFirstName
            // 
            this.cFirstName.Text = "First Name";
            this.cFirstName.Width = 136;
            // 
            // cLastName
            // 
            this.cLastName.Text = "Last Name";
            this.cLastName.Width = 105;
            // 
            // cSex
            // 
            this.cSex.Text = "Sex";
            // 
            // cDOB
            // 
            this.cDOB.Text = "DOB";
            this.cDOB.Width = 107;
            // 
            // cSSN
            // 
            this.cSSN.Text = "SSN";
            this.cSSN.Width = 112;
            // 
            // cPhoneNumber
            // 
            this.cPhoneNumber.Text = "Phone Number";
            this.cPhoneNumber.Width = 158;
            // 
            // cAddress
            // 
            this.cAddress.Text = "Address";
            this.cAddress.Width = 132;
            // 
            // cCity
            // 
            this.cCity.Text = "City";
            this.cCity.Width = 145;
            // 
            // cState
            // 
            this.cState.Text = "Statet";
            // 
            // cZip
            // 
            this.cZip.Text = "Zip Code";
            this.cZip.Width = 124;
            // 
            // cDocsName
            // 
            this.cDocsName.Text = "Docs Name";
            this.cDocsName.Width = 142;
            // 
            // cAssigned
            // 
            this.cAssigned.Text = "Diagnosis";
            this.cAssigned.Width = 134;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Admitted";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Released";
            // 
            // btncAdmission
            // 
            this.btncAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncAdmission.Location = new System.Drawing.Point(4, 609);
            this.btncAdmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncAdmission.Name = "btncAdmission";
            this.btncAdmission.Size = new System.Drawing.Size(277, 39);
            this.btncAdmission.TabIndex = 1;
            this.btncAdmission.Text = "Create Admission";
            this.btncAdmission.UseVisualStyleBackColor = true;
            this.btncAdmission.Click += new System.EventHandler(this.btncCreatetAdm_Click);
            // 
            // Admission
            // 
            this.Admission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admission.BackgroundImage")));
            this.Admission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admission.Controls.Add(this.btnDelete);
            this.Admission.Controls.Add(this.btnEditAdmission);
            this.Admission.Controls.Add(this.btnExit1);
            this.Admission.Controls.Add(this.listViewAdmission);
            this.Admission.Controls.Add(this.btnDeleteApp);
            this.Admission.Controls.Add(this.btnEditAppoitment);
            this.Admission.Controls.Add(this.btnExit2);
            this.Admission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admission.Location = new System.Drawing.Point(4, 38);
            this.Admission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admission.Name = "Admission";
            this.Admission.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admission.Size = new System.Drawing.Size(1367, 668);
            this.Admission.TabIndex = 1;
            this.Admission.Text = "Admission";
            this.Admission.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(279, 613);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(269, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Admission";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteAdm_Click);
            // 
            // btnEditAdmission
            // 
            this.btnEditAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdmission.Location = new System.Drawing.Point(9, 613);
            this.btnEditAdmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditAdmission.Name = "btnEditAdmission";
            this.btnEditAdmission.Size = new System.Drawing.Size(261, 42);
            this.btnEditAdmission.TabIndex = 8;
            this.btnEditAdmission.Text = "Edit Admission";
            this.btnEditAdmission.UseVisualStyleBackColor = true;
            this.btnEditAdmission.Click += new System.EventHandler(this.btnEditAdmission_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(1205, 613);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(148, 42);
            this.btnExit1.TabIndex = 7;
            this.btnExit1.Text = "EXIT";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewAdmission
            // 
            this.listViewAdmission.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewAdmission.FullRowSelect = true;
            this.listViewAdmission.GridLines = true;
            this.listViewAdmission.Location = new System.Drawing.Point(0, 0);
            this.listViewAdmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewAdmission.Name = "listViewAdmission";
            this.listViewAdmission.Size = new System.Drawing.Size(1361, 605);
            this.listViewAdmission.TabIndex = 6;
            this.listViewAdmission.UseCompatibleStateImageBehavior = false;
            this.listViewAdmission.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "First name";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Last Name";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Department Name";
            this.columnHeader7.Width = 182;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Room#";
            this.columnHeader8.Width = 122;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Doc Name";
            this.columnHeader9.Width = 165;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Diagnosis";
            this.columnHeader10.Width = 140;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Appoitment";
            this.columnHeader11.Width = 122;
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.Location = new System.Drawing.Point(169, 671);
            this.btnDeleteApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(140, 43);
            this.btnDeleteApp.TabIndex = 5;
            this.btnDeleteApp.Text = "Delete";
            this.btnDeleteApp.UseVisualStyleBackColor = true;
            this.btnDeleteApp.Click += new System.EventHandler(this.btnDeleteAdm_Click);
            // 
            // btnEditAppoitment
            // 
            this.btnEditAppoitment.Location = new System.Drawing.Point(21, 671);
            this.btnEditAppoitment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditAppoitment.Name = "btnEditAppoitment";
            this.btnEditAppoitment.Size = new System.Drawing.Size(140, 43);
            this.btnEditAppoitment.TabIndex = 4;
            this.btnEditAppoitment.Text = "Edit";
            this.btnEditAppoitment.UseVisualStyleBackColor = true;
            this.btnEditAppoitment.Click += new System.EventHandler(this.btnEditAdmission_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.Location = new System.Drawing.Point(1400, 674);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(163, 39);
            this.btnExit2.TabIndex = 3;
            this.btnExit2.Text = "EXIT";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmAdmittanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 704);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdmittanceView";
            this.Text = "Admission View Window";
            this.Activated += new System.EventHandler(this.FrmAppoitmentView_Load);
            this.Load += new System.EventHandler(this.FrmAppoitmentView_Load);
            this.Shown += new System.EventHandler(this.FrmAppoitmentView_Load);
            this.Enter += new System.EventHandler(this.FrmAppoitmentView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Admission.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Admission;
        private System.Windows.Forms.Button btncAdmission;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewPatient;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cFirstName;
        private System.Windows.Forms.ColumnHeader cLastName;
        private System.Windows.Forms.ColumnHeader cSex;
        private System.Windows.Forms.ColumnHeader cDOB;
        private System.Windows.Forms.ColumnHeader cSSN;
        private System.Windows.Forms.ColumnHeader cPhoneNumber;
        private System.Windows.Forms.ColumnHeader cAddress;
        private System.Windows.Forms.ColumnHeader cCity;
        private System.Windows.Forms.ColumnHeader cState;
        private System.Windows.Forms.ColumnHeader cZip;
        private System.Windows.Forms.ColumnHeader cDocsName;
        private System.Windows.Forms.ColumnHeader cAssigned;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnDeleteApp;
        private System.Windows.Forms.Button btnEditAppoitment;
        private System.Windows.Forms.ListView listViewAdmission;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditAdmission;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}