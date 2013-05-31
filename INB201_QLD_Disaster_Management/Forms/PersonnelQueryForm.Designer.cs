namespace INB201_QLD_Disaster_Management.Forms
{
    partial class PersonnelQueryForm
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.PersonnelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.incidentIdCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personnelIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonPersonnel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(6, 19);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.Size = new System.Drawing.Size(597, 177);
            this.datagrid.TabIndex = 0;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(317, 17);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(114, 21);
            this.statusComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personnel Assigned to Incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personnel Type";
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(6, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // PersonnelTypeComboBox
            // 
            this.PersonnelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonnelTypeComboBox.FormattingEnabled = true;
            this.PersonnelTypeComboBox.Location = new System.Drawing.Point(317, 46);
            this.PersonnelTypeComboBox.Name = "PersonnelTypeComboBox";
            this.PersonnelTypeComboBox.Size = new System.Drawing.Size(114, 21);
            this.PersonnelTypeComboBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lNameBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.fNameBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.incidentIdCB);
            this.groupBox4.Controls.Add(this.statusComboBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.searchButton);
            this.groupBox4.Controls.Add(this.PersonnelTypeComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(164, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 117);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Options";
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(66, 46);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(131, 20);
            this.lNameBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Surname";
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(66, 17);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(131, 20);
            this.fNameBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // incidentIdCB
            // 
            this.incidentIdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incidentIdCB.FormattingEnabled = true;
            this.incidentIdCB.Location = new System.Drawing.Point(317, 73);
            this.incidentIdCB.Name = "incidentIdCB";
            this.incidentIdCB.Size = new System.Drawing.Size(285, 21);
            this.incidentIdCB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.personnelIdComboBox);
            this.groupBox1.Location = new System.Drawing.Point(164, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit/Create New Personnel";
            // 
            // createButton
            // 
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(261, 32);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 21);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create New";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(140, 32);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 21);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Personnel";
            // 
            // personnelIdComboBox
            // 
            this.personnelIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personnelIdComboBox.FormattingEnabled = true;
            this.personnelIdComboBox.Location = new System.Drawing.Point(9, 32);
            this.personnelIdComboBox.Name = "personnelIdComboBox";
            this.personnelIdComboBox.Size = new System.Drawing.Size(125, 21);
            this.personnelIdComboBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.datagrid);
            this.groupBox2.Location = new System.Drawing.Point(163, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 202);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnel Datatable";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 42);
            this.label4.TabIndex = 24;
            this.label4.Text = "Personnel Management";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMap);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.buttonReports);
            this.groupBox3.Controls.Add(this.buttonPersonnel);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 140);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Navigation";
            // 
            // buttonMap
            // 
            this.buttonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMap.Location = new System.Drawing.Point(6, 109);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(135, 23);
            this.buttonMap.TabIndex = 11;
            this.buttonMap.Text = "Incident Map";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Incident Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonIncident_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Location = new System.Drawing.Point(6, 80);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(135, 23);
            this.buttonReports.TabIndex = 9;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonPersonnel
            // 
            this.buttonPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonnel.Location = new System.Drawing.Point(6, 51);
            this.buttonPersonnel.Name = "buttonPersonnel";
            this.buttonPersonnel.Size = new System.Drawing.Size(135, 23);
            this.buttonPersonnel.TabIndex = 8;
            this.buttonPersonnel.Text = "Personnel Management";
            this.buttonPersonnel.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 482);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(784, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(109, 16);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(131, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Please select a personnel.";
            this.labelError.Visible = false;
            // 
            // PersonnelQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PersonnelQueryForm";
            this.Text = "PersonnelQueryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.PersonnelQueryForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox PersonnelTypeComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox personnelIdComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox incidentIdCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonPersonnel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelError;
    }
}