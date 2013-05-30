namespace INB201_QLD_Disaster_Management.Forms
{
    partial class IncidentEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.statusCombox = new System.Windows.Forms.ComboBox();
            this.typeCombox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonPersonnel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.labelConfirm);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.statusCombox);
            this.groupBox1.Controls.Add(this.typeCombox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(164, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incident Information";
            // 
            // labelConfirm
            // 
            this.labelConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.ForeColor = System.Drawing.Color.Red;
            this.labelConfirm.Location = new System.Drawing.Point(39, 329);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(41, 13);
            this.labelConfirm.TabIndex = 26;
            this.labelConfirm.Text = "confirm";
            this.labelConfirm.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(255, 71);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(28, 13);
            this.labelError.TabIndex = 25;
            this.labelError.Text = "error";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(116, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Please specify an address.";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(119, 124);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "* indicates required field";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(409, 361);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // statusCombox
            // 
            this.statusCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombox.FormattingEnabled = true;
            this.statusCombox.Location = new System.Drawing.Point(383, 96);
            this.statusCombox.Name = "statusCombox";
            this.statusCombox.Size = new System.Drawing.Size(127, 21);
            this.statusCombox.TabIndex = 19;
            // 
            // typeCombox
            // 
            this.typeCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombox.FormattingEnabled = true;
            this.typeCombox.Location = new System.Drawing.Point(119, 96);
            this.typeCombox.Name = "typeCombox";
            this.typeCombox.Size = new System.Drawing.Size(127, 21);
            this.typeCombox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Start Date";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(490, 361);
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
            this.applyButton.Location = new System.Drawing.Point(42, 361);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Warning Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextBox.Location = new System.Drawing.Point(42, 174);
            this.messageTextBox.MaxLength = 1024;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(523, 143);
            this.messageTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(119, 48);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(421, 20);
            this.locationTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location*";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Location = new System.Drawing.Point(6, 22);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(135, 23);
            this.buttonGoBack.TabIndex = 2;
            this.buttonGoBack.Text = "Incident Management";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 42);
            this.label9.TabIndex = 22;
            this.label9.Text = "Incident Information";
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
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMap);
            this.groupBox3.Controls.Add(this.buttonReports);
            this.groupBox3.Controls.Add(this.buttonPersonnel);
            this.groupBox3.Controls.Add(this.buttonGoBack);
            this.groupBox3.Location = new System.Drawing.Point(12, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 140);
            this.groupBox3.TabIndex = 24;
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
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // IncidentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "IncidentEditForm";
            this.Text = "IncidentEditForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.IncidentEditForm_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusCombox;
        private System.Windows.Forms.ComboBox typeCombox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonPersonnel;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}