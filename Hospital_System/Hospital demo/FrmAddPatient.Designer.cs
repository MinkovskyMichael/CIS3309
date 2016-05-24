namespace Hospital_demo
{
    partial class FrmAddPatient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPatient));
            this.cmbDocName = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.mTxtPNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.mTxtSSN = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDOB = new System.Windows.Forms.MaskedTextBox();
            this.mTxtZip = new System.Windows.Forms.MaskedTextBox();
            this.gBoxSex = new System.Windows.Forms.GroupBox();
            this.rdnF = new System.Windows.Forms.RadioButton();
            this.rdnM = new System.Windows.Forms.RadioButton();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDocName
            // 
            this.cmbDocName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDocName.FormattingEnabled = true;
            this.cmbDocName.Location = new System.Drawing.Point(229, 385);
            this.cmbDocName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDocName.Name = "cmbDocName";
            this.cmbDocName.Size = new System.Drawing.Size(160, 37);
            this.cmbDocName.TabIndex = 76;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(167, 294);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(429, 34);
            this.txtCity.TabIndex = 74;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // mTxtPNumber
            // 
            this.mTxtPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtPNumber.Location = new System.Drawing.Point(880, 135);
            this.mTxtPNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtPNumber.Mask = "(999) 000-0000";
            this.mTxtPNumber.Name = "mTxtPNumber";
            this.mTxtPNumber.Size = new System.Drawing.Size(184, 34);
            this.mTxtPNumber.TabIndex = 73;
            this.mTxtPNumber.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtPNumber_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(151, 212);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1161, 34);
            this.txtAddress.TabIndex = 72;
            // 
            // mTxtSSN
            // 
            this.mTxtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtSSN.Location = new System.Drawing.Point(464, 137);
            this.mTxtSSN.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtSSN.Mask = "000-00-0000";
            this.mTxtSSN.Name = "mTxtSSN";
            this.mTxtSSN.Size = new System.Drawing.Size(148, 34);
            this.mTxtSSN.TabIndex = 71;
            this.mTxtSSN.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtSSN_Validating);
            // 
            // mTxtDOB
            // 
            this.mTxtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtDOB.Location = new System.Drawing.Point(187, 137);
            this.mTxtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtDOB.Mask = "00/00/0000";
            this.mTxtDOB.Name = "mTxtDOB";
            this.mTxtDOB.Size = new System.Drawing.Size(131, 34);
            this.mTxtDOB.TabIndex = 70;
            this.mTxtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtZip
            // 
            this.mTxtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtZip.Location = new System.Drawing.Point(1047, 299);
            this.mTxtZip.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtZip.Mask = "00000";
            this.mTxtZip.Name = "mTxtZip";
            this.mTxtZip.Size = new System.Drawing.Size(85, 34);
            this.mTxtZip.TabIndex = 75;
            this.mTxtZip.Validating += new System.ComponentModel.CancelEventHandler(this.mskZip_Validating);
            // 
            // gBoxSex
            // 
            this.gBoxSex.Controls.Add(this.rdnF);
            this.gBoxSex.Controls.Add(this.rdnM);
            this.gBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSex.Location = new System.Drawing.Point(1096, 138);
            this.gBoxSex.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxSex.Name = "gBoxSex";
            this.gBoxSex.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxSex.Size = new System.Drawing.Size(267, 32);
            this.gBoxSex.TabIndex = 69;
            this.gBoxSex.TabStop = false;
            this.gBoxSex.Text = "Sex:";
            // 
            // rdnF
            // 
            this.rdnF.AutoSize = true;
            this.rdnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnF.Location = new System.Drawing.Point(157, -2);
            this.rdnF.Margin = new System.Windows.Forms.Padding(4);
            this.rdnF.Name = "rdnF";
            this.rdnF.Size = new System.Drawing.Size(48, 33);
            this.rdnF.TabIndex = 1;
            this.rdnF.TabStop = true;
            this.rdnF.Text = "F";
            this.rdnF.UseVisualStyleBackColor = true;
            this.rdnF.Validating += new System.ComponentModel.CancelEventHandler(this.rdnButton_Validating);
            // 
            // rdnM
            // 
            this.rdnM.AutoSize = true;
            this.rdnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnM.Location = new System.Drawing.Point(88, -2);
            this.rdnM.Margin = new System.Windows.Forms.Padding(4);
            this.rdnM.Name = "rdnM";
            this.rdnM.Size = new System.Drawing.Size(53, 33);
            this.rdnM.TabIndex = 0;
            this.rdnM.TabStop = true;
            this.rdnM.Text = "M";
            this.rdnM.UseVisualStyleBackColor = true;
            this.rdnM.Validating += new System.ComponentModel.CancelEventHandler(this.rdnButton_Validating);
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cmbState.Location = new System.Drawing.Point(720, 288);
            this.cmbState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(160, 37);
            this.cmbState.TabIndex = 68;
            this.cmbState.Validating += new System.ComponentModel.CancelEventHandler(this.comBox_Validating);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(873, 70);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLname.MaxLength = 33;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(475, 34);
            this.txtLname.TabIndex = 67;
            this.txtLname.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(167, 71);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.MaxLength = 33;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(469, 34);
            this.txtFName.TabIndex = 66;
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 393);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 29);
            this.label13.TabIndex = 65;
            this.label13.Text = "Doctor\'s Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(625, 298);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 29);
            this.label12.TabIndex = 64;
            this.label12.Text = "State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(904, 300);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 29);
            this.label11.TabIndex = 63;
            this.label11.Text = "Zip Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 298);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 62;
            this.label10.Text = "City Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 60;
            this.label8.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 59;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "SSN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "First Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(232, 25);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 29);
            this.lblID.TabIndex = 55;
            this.lblID.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Record Number:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1191, 511);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1061, 511);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 52;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(167, 463);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosis.MaxLength = 30;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(429, 34);
            this.txtDiagnosis.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 77;
            this.label2.Text = "Diagnosis:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // FrmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1412, 562);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDocName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.mTxtPNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.mTxtSSN);
            this.Controls.Add(this.mTxtDOB);
            this.Controls.Add(this.mTxtZip);
            this.Controls.Add(this.gBoxSex);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddPatient";
            this.Text = "Patient Information";
            this.gBoxSex.ResumeLayout(false);
            this.gBoxSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox mTxtPNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox mTxtSSN;
        private System.Windows.Forms.MaskedTextBox mTxtDOB;
        private System.Windows.Forms.MaskedTextBox mTxtZip;
        private System.Windows.Forms.GroupBox gBoxSex;
        private System.Windows.Forms.RadioButton rdnF;
        private System.Windows.Forms.RadioButton rdnM;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;


    }
}