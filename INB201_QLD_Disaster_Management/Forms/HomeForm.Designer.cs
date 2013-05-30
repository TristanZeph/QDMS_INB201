namespace INB201_QLD_Disaster_Management.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mapButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.personnelButton = new System.Windows.Forms.Button();
            this.incidentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mapPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(702, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 55);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Queensland State-wide Disaster Management System";
            // 
            // mapButton
            // 
            this.mapButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Location = new System.Drawing.Point(11, 117);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(84, 23);
            this.mapButton.TabIndex = 11;
            this.mapButton.Text = "Incident Map";
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Location = new System.Drawing.Point(600, 117);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(84, 23);
            this.reportsButton.TabIndex = 18;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // personnelButton
            // 
            this.personnelButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.personnelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personnelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personnelButton.Location = new System.Drawing.Point(403, 117);
            this.personnelButton.Name = "personnelButton";
            this.personnelButton.Size = new System.Drawing.Size(108, 23);
            this.personnelButton.TabIndex = 16;
            this.personnelButton.Text = "Manage Personnel";
            this.personnelButton.UseVisualStyleBackColor = false;
            this.personnelButton.Click += new System.EventHandler(this.personnelButton_Click);
            // 
            // incidentButton
            // 
            this.incidentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.incidentButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.incidentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incidentButton.Location = new System.Drawing.Point(183, 117);
            this.incidentButton.Name = "incidentButton";
            this.incidentButton.Size = new System.Drawing.Size(108, 23);
            this.incidentButton.TabIndex = 14;
            this.incidentButton.Text = "Manage Incidents";
            this.incidentButton.UseVisualStyleBackColor = false;
            this.incidentButton.Click += new System.EventHandler(this.incidentButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.labelError);
            this.groupBox2.Controls.Add(this.reportsButton);
            this.groupBox2.Controls.Add(this.mapPicture);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.mapButton);
            this.groupBox2.Controls.Add(this.personnelButton);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.incidentButton);
            this.groupBox2.Location = new System.Drawing.Point(35, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 391);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // mapPicture
            // 
            this.mapPicture.Image = ((System.Drawing.Image)(resources.GetObject("mapPicture.Image")));
            this.mapPicture.Location = new System.Drawing.Point(6, 15);
            this.mapPicture.Name = "mapPicture";
            this.mapPicture.Size = new System.Drawing.Size(96, 96);
            this.mapPicture.TabIndex = 12;
            this.mapPicture.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(595, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 96);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(571, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Queensland Disaster Management System";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Location = new System.Drawing.Point(702, 9);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(70, 55);
            this.buttonLogIn.TabIndex = 24;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(98, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 18);
            this.labelTime.TabIndex = 19;
            this.labelTime.Text = "Time";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Queensland Disaster Management System. Developed by Tristan Le. QUT Gardens Point" +
                ". ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(706, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Version 1.0a";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "This application is not associated by Queensland Government.";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(579, 54);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(48, 18);
            this.labelUsername.TabIndex = 29;
            this.labelUsername.Text = "User: ";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.White;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(394, -3);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(42, 20);
            this.labelError.TabIndex = 30;
            this.labelError.Text = "error";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelError.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::INB201_QLD_Disaster_Management.Properties.Resources.logo;
            this.pictureBox6.Location = new System.Drawing.Point(5, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 73);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 482);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(784, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
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
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.HomeForm_Activated);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.PictureBox mapPicture;
        private System.Windows.Forms.Button incidentButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button personnelButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelError;
    }
}