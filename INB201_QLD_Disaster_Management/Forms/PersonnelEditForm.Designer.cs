namespace INB201_QLD_Disaster_Management.Forms
{
    partial class PersonnelEditForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.labelErrorEnd = new System.Windows.Forms.Label();
            this.labelErrorStart = new System.Windows.Forms.Label();
            this.labelErrorLName = new System.Windows.Forms.Label();
            this.labelErrorFName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assignmentCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonIncident = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonPersonnel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(353, 361);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // statusCB
            // 
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(117, 160);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(110, 21);
            this.statusCB.TabIndex = 19;
            this.statusCB.SelectedIndexChanged += new System.EventHandler(this.statusCB_SelectedIndexChanged);
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(117, 123);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(110, 21);
            this.typeCB.TabIndex = 18;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(434, 361);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Location = new System.Drawing.Point(57, 361);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personnel Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.labelConfirm);
            this.groupBox1.Controls.Add(this.comboBoxHours);
            this.groupBox1.Controls.Add(this.labelErrorEnd);
            this.groupBox1.Controls.Add(this.labelErrorStart);
            this.groupBox1.Controls.Add(this.labelErrorLName);
            this.groupBox1.Controls.Add(this.labelErrorFName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.endTimeTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.startTimeTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.assignmentCB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.statusCB);
            this.groupBox1.Controls.Add(this.typeCB);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(164, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Infomation";
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.ForeColor = System.Drawing.Color.Red;
            this.labelConfirm.Location = new System.Drawing.Point(55, 292);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(67, 13);
            this.labelConfirm.TabIndex = 44;
            this.labelConfirm.Text = "confirmLabel";
            this.labelConfirm.Visible = false;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(193, 229);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(48, 21);
            this.comboBoxHours.TabIndex = 43;
            // 
            // labelErrorEnd
            // 
            this.labelErrorEnd.AutoSize = true;
            this.labelErrorEnd.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEnd.Location = new System.Drawing.Point(428, 163);
            this.labelErrorEnd.Name = "labelErrorEnd";
            this.labelErrorEnd.Size = new System.Drawing.Size(86, 13);
            this.labelErrorEnd.TabIndex = 42;
            this.labelErrorEnd.Text = "Invalid End Time";
            this.labelErrorEnd.Visible = false;
            // 
            // labelErrorStart
            // 
            this.labelErrorStart.AutoSize = true;
            this.labelErrorStart.ForeColor = System.Drawing.Color.Red;
            this.labelErrorStart.Location = new System.Drawing.Point(428, 127);
            this.labelErrorStart.Name = "labelErrorStart";
            this.labelErrorStart.Size = new System.Drawing.Size(89, 13);
            this.labelErrorStart.TabIndex = 41;
            this.labelErrorStart.Text = "Invalid Start Time";
            this.labelErrorStart.Visible = false;
            // 
            // labelErrorLName
            // 
            this.labelErrorLName.AutoSize = true;
            this.labelErrorLName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLName.Location = new System.Drawing.Point(271, 61);
            this.labelErrorLName.Name = "labelErrorLName";
            this.labelErrorLName.Size = new System.Drawing.Size(192, 13);
            this.labelErrorLName.TabIndex = 40;
            this.labelErrorLName.Text = "Invalid Last Name. Must be letters only.";
            this.labelErrorLName.Visible = false;
            // 
            // labelErrorFName
            // 
            this.labelErrorFName.AutoSize = true;
            this.labelErrorFName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFName.Location = new System.Drawing.Point(271, 28);
            this.labelErrorFName.Name = "labelErrorFName";
            this.labelErrorFName.Size = new System.Drawing.Size(191, 13);
            this.labelErrorFName.TabIndex = 39;
            this.labelErrorFName.Text = "Invalid First Name. Must be letters only.";
            this.labelErrorFName.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(478, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "* indicates required fields";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Continuous Hours Worked";
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Location = new System.Drawing.Point(388, 160);
            this.endTimeTextBox.MaxLength = 4;
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(34, 20);
            this.endTimeTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "End Time (24hr time)*";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(388, 124);
            this.startTimeTextBox.MaxLength = 4;
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(34, 20);
            this.startTimeTextBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Start Time (24hr time)*";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(117, 58);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.lNameTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Last Name*";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(117, 25);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(134, 20);
            this.fNameTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "First Name*";
            // 
            // assignmentCB
            // 
            this.assignmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignmentCB.FormattingEnabled = true;
            this.assignmentCB.Location = new System.Drawing.Point(116, 89);
            this.assignmentCB.Name = "assignmentCB";
            this.assignmentCB.Size = new System.Drawing.Size(392, 21);
            this.assignmentCB.TabIndex = 25;
            this.assignmentCB.SelectedIndexChanged += new System.EventHandler(this.assignmentCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Assignment";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMap);
            this.groupBox3.Controls.Add(this.buttonIncident);
            this.groupBox3.Controls.Add(this.buttonReports);
            this.groupBox3.Controls.Add(this.buttonPersonnel);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 140);
            this.groupBox3.TabIndex = 40;
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
            // buttonIncident
            // 
            this.buttonIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncident.Location = new System.Drawing.Point(6, 22);
            this.buttonIncident.Name = "buttonIncident";
            this.buttonIncident.Size = new System.Drawing.Size(135, 23);
            this.buttonIncident.TabIndex = 10;
            this.buttonIncident.Text = "Incident Management";
            this.buttonIncident.UseVisualStyleBackColor = true;
            this.buttonIncident.Click += new System.EventHandler(this.buttonIncident_Click);
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
            this.buttonPersonnel.Click += new System.EventHandler(this.buttonPersonnel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(784, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // PersonnelEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonnelEditForm";
            this.Text = "PersonnelEditForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.PersonnelEditForm_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assignmentCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonIncident;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonPersonnel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelErrorFName;
        private System.Windows.Forms.Label labelErrorLName;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label labelErrorEnd;
        private System.Windows.Forms.Label labelErrorStart;
        private System.Windows.Forms.Label labelConfirm;
    }
}