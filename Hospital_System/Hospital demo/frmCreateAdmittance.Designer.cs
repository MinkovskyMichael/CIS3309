namespace Hospital_demo
{
    partial class frmCreateAdmittance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAdmittance));
            this.cobDocName = new System.Windows.Forms.ComboBox();
            this.mTxtDOA = new System.Windows.Forms.MaskedTextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxDepartment = new System.Windows.Forms.ComboBox();
            this.maskedTxtRoom = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.btnPatientInfo = new System.Windows.Forms.Button();
            this.btnDocInfo = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cobDocName
            // 
            this.cobDocName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDocName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobDocName.FormattingEnabled = true;
            this.cobDocName.Location = new System.Drawing.Point(799, 118);
            this.cobDocName.Margin = new System.Windows.Forms.Padding(4);
            this.cobDocName.Name = "cobDocName";
            this.cobDocName.Size = new System.Drawing.Size(577, 37);
            this.cobDocName.TabIndex = 49;
            this.cobDocName.Validating += new System.ComponentModel.CancelEventHandler(this.comBox_Validating);
            // 
            // mTxtDOA
            // 
            this.mTxtDOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtDOA.Location = new System.Drawing.Point(281, 126);
            this.mTxtDOA.Margin = new System.Windows.Forms.Padding(4);
            this.mTxtDOA.Mask = "00/00/0000";
            this.mTxtDOA.Name = "mTxtDOA";
            this.mTxtDOA.Size = new System.Drawing.Size(132, 34);
            this.mTxtDOA.TabIndex = 43;
            this.mTxtDOA.ValidatingType = typeof(System.DateTime);
            this.mTxtDOA.Validating += new System.ComponentModel.CancelEventHandler(this.mTxtDOA_Validating);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(900, 59);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLname.MaxLength = 33;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(475, 34);
            this.txtLname.TabIndex = 40;
            this.txtLname.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(157, 60);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.MaxLength = 33;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(469, 34);
            this.txtFName.TabIndex = 39;
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(595, 126);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 29);
            this.label13.TabIndex = 38;
            this.label13.Text = "Doctor\'s Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(705, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date Admited:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "First Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(785, 11);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 29);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Record Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Department:";
            // 
            // comBoxDepartment
            // 
            this.comBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxDepartment.Items.AddRange(new object[] {
            "Ancology",
            "Audiology",
            "Autism Center",
            "Blood Disorders",
            "Cardiology and Cardiac Surgery",
            "Child and Adolescent Wellness Clinics",
            "Intensive Care Unit (ICU)",
            "Dentistry",
            "Dermatology",
            "Diabetes",
            "Dialysis",
            "Gynecology",
            "Immunology",
            "Neurology",
            "Nutrition",
            "Orthopedics",
            "Pediatric ",
            "Radiology",
            "Urology"});
            this.comBoxDepartment.Location = new System.Drawing.Point(265, 197);
            this.comBoxDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxDepartment.Name = "comBoxDepartment";
            this.comBoxDepartment.Size = new System.Drawing.Size(577, 37);
            this.comBoxDepartment.TabIndex = 51;
            this.comBoxDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.comBox_Validating);
            // 
            // maskedTxtRoom
            // 
            this.maskedTxtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtRoom.Location = new System.Drawing.Point(1243, 194);
            this.maskedTxtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtRoom.Mask = "000";
            this.maskedTxtRoom.Name = "maskedTxtRoom";
            this.maskedTxtRoom.Size = new System.Drawing.Size(132, 34);
            this.maskedTxtRoom.TabIndex = 52;
            this.maskedTxtRoom.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTxtRoom_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1120, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Room#:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnosis.Location = new System.Drawing.Point(157, 270);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiagnosis.MaxLength = 33;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(469, 34);
            this.txtDiagnosis.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Diagnosis:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1243, 513);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 43);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSubmit
            // 
            this.txtSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmit.Location = new System.Drawing.Point(1056, 513);
            this.txtSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(145, 43);
            this.txtSubmit.TabIndex = 57;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.UseVisualStyleBackColor = true;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientInfo.Location = new System.Drawing.Point(21, 450);
            this.btnPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.Size = new System.Drawing.Size(359, 43);
            this.btnPatientInfo.TabIndex = 58;
            this.btnPatientInfo.Text = "Patient Detailed Information";
            this.btnPatientInfo.UseVisualStyleBackColor = true;
            this.btnPatientInfo.Click += new System.EventHandler(this.btnPatientInfo_Click);
            // 
            // btnDocInfo
            // 
            this.btnDocInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocInfo.Location = new System.Drawing.Point(21, 530);
            this.btnDocInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocInfo.Name = "btnDocInfo";
            this.btnDocInfo.Size = new System.Drawing.Size(359, 43);
            this.btnDocInfo.TabIndex = 59;
            this.btnDocInfo.Text = "Doctor Detailed Information";
            this.btnDocInfo.UseVisualStyleBackColor = true;
            this.btnDocInfo.Click += new System.EventHandler(this.btnDocInfo_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("MyErrorProvider.Icon")));
            // 
            // frmCreateAdmittance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1433, 640);
            this.Controls.Add(this.btnDocInfo);
            this.Controls.Add(this.btnPatientInfo);
            this.Controls.Add(this.txtSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTxtRoom);
            this.Controls.Add(this.comBoxDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobDocName);
            this.Controls.Add(this.mTxtDOA);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateAdmittance";
            this.Text = "Admit Patient";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobDocName;
        private System.Windows.Forms.MaskedTextBox mTxtDOA;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoxDepartment;
        private System.Windows.Forms.MaskedTextBox maskedTxtRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.Button btnPatientInfo;
        private System.Windows.Forms.Button btnDocInfo;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}