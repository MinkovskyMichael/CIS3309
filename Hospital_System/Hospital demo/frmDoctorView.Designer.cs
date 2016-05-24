namespace Hospital_demo
{
    partial class frmDoctorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorView));
            this.btnDeleteDoc = new System.Windows.Forms.Button();
            this.btnExitDoctor = new System.Windows.Forms.Button();
            this.btnAddDoc = new System.Windows.Forms.Button();
            this.btnEditDoc = new System.Windows.Forms.Button();
            this.listViewDoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDeleteDoc
            // 
            this.btnDeleteDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoc.Location = new System.Drawing.Point(275, 563);
            this.btnDeleteDoc.Name = "btnDeleteDoc";
            this.btnDeleteDoc.Size = new System.Drawing.Size(112, 30);
            this.btnDeleteDoc.TabIndex = 18;
            this.btnDeleteDoc.Text = "Delete";
            this.btnDeleteDoc.UseVisualStyleBackColor = true;
            this.btnDeleteDoc.Click += new System.EventHandler(this.btnDeleteDoc_Click);
            // 
            // btnExitDoctor
            // 
            this.btnExitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDoctor.Location = new System.Drawing.Point(934, 563);
            this.btnExitDoctor.Name = "btnExitDoctor";
            this.btnExitDoctor.Size = new System.Drawing.Size(112, 30);
            this.btnExitDoctor.TabIndex = 17;
            this.btnExitDoctor.Text = "Exit";
            this.btnExitDoctor.UseVisualStyleBackColor = true;
            this.btnExitDoctor.Click += new System.EventHandler(this.btnExitDoctor_Click);
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoc.Location = new System.Drawing.Point(145, 563);
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(112, 30);
            this.btnAddDoc.TabIndex = 16;
            this.btnAddDoc.Text = "Add";
            this.btnAddDoc.UseVisualStyleBackColor = true;
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnEditDoc
            // 
            this.btnEditDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDoc.Location = new System.Drawing.Point(12, 563);
            this.btnEditDoc.Name = "btnEditDoc";
            this.btnEditDoc.Size = new System.Drawing.Size(112, 30);
            this.btnEditDoc.TabIndex = 15;
            this.btnEditDoc.Text = "Edit";
            this.btnEditDoc.UseVisualStyleBackColor = true;
            this.btnEditDoc.Click += new System.EventHandler(this.btnEditDoc_Click);
            // 
            // listViewDoc
            // 
            this.listViewDoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDoc.FullRowSelect = true;
            this.listViewDoc.GridLines = true;
            this.listViewDoc.Location = new System.Drawing.Point(1, -2);
            this.listViewDoc.Name = "listViewDoc";
            this.listViewDoc.Size = new System.Drawing.Size(1177, 559);
            this.listViewDoc.TabIndex = 14;
            this.listViewDoc.UseCompatibleStateImageBehavior = false;
            this.listViewDoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Address";
            this.columnHeader14.Width = 177;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Phone Number";
            this.columnHeader15.Width = 201;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "State";
            this.columnHeader16.Width = 77;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "City";
            this.columnHeader17.Width = 152;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Zip Code";
            this.columnHeader18.Width = 127;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Specialty";
            this.columnHeader19.Width = 215;
            // 
            // frmDoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 605);
            this.Controls.Add(this.btnDeleteDoc);
            this.Controls.Add(this.btnExitDoctor);
            this.Controls.Add(this.btnAddDoc);
            this.Controls.Add(this.btnEditDoc);
            this.Controls.Add(this.listViewDoc);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoctorView";
            this.Text = "Doctor View";
            this.Activated += new System.EventHandler(this.frmDoctorView_Load);
            this.Load += new System.EventHandler(this.frmDoctorView_Load);
            this.Shown += new System.EventHandler(this.frmDoctorView_Load);
            this.Enter += new System.EventHandler(this.frmDoctorView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteDoc;
        private System.Windows.Forms.Button btnExitDoctor;
        private System.Windows.Forms.Button btnAddDoc;
        private System.Windows.Forms.Button btnEditDoc;
        private System.Windows.Forms.ListView listViewDoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}