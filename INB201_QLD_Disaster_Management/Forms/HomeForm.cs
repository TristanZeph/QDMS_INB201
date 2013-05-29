﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INB201_QLD_Disaster_Management.Forms
{
    /// <summary>
    /// This form displays the home page of the program. 
    /// Provides navigation to other forms and supports user login.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class HomeForm : Form
    {
        #region Fields
        // access SQL functions and form transitions
        private Main parent;

        private const string PUBLIC = "Public";
        #endregion

        #region Initialise
        /// <summary>
        /// Constructor, passes parent for more SQL and form transitions
        /// </summary>
        public HomeForm(Main parent)
        {
            InitializeComponent();
            this.parent = parent;

            timer1.Start();
        }
        #endregion

        #region Button Events
        private void buttonLogIn_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.LOGIN);
        }

        /// <summary>
        /// Allows user to logout of the system
        /// </summary>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            buttonLogIn.Visible = true;
            logoutButton.Visible = false;
            parent.IsAdmin = false;
            parent.DisableAdminFunctions();
            parent.AccountName = "Public";
            labelUsername.Text = "User: " + parent.AccountName;

            labelError.Text = "You have successfully logged out!";
        }

        /// <summary>
        /// Opens the map screen
        /// </summary>
        private void mapButton_Click(object sender, EventArgs e)
        {
            parent.OpenForm(parent.INCIDENT_MAP);
        }

        /// <summary>
        /// Opens the incident page. validates whether there is an admin
        /// </summary>
        private void incidentButton_Click(object sender, EventArgs e)
        {
            if (parent.IsAdmin)
                parent.OpenForm(parent.INCIDENT_QUERY);
            else
                labelError.Text = "Access Denied. Administrators only.";
        }

        /// <summary>
        /// Opens the personnel page. validate whether there is an admin
        /// </summary>
        private void personnelButton_Click(object sender, EventArgs e)
        {
            if (parent.IsAdmin)
                parent.OpenForm(parent.PERSONNEL_QUERY);
            else
                labelError.Text = "Access Denied. Administrators only.";
        }

        /// <summary>
        /// Opens the reports page. validates whether there is an admin
        /// </summary>
        private void reportsButton_Click(object sender, EventArgs e)
        {
            if (parent.IsAdmin)
                parent.OpenForm(parent.REPORTS);
            else
                labelError.Text = "Access Denied. Administrators only.";
        }
        #endregion

        private void HomeForm_Activated(object sender, EventArgs e) {
            if (parent.IsAdmin) {
                buttonLogIn.Visible = false;
                logoutButton.Visible = true;
            }
            else {
                buttonLogIn.Visible = true;
                logoutButton.Visible = false;
            }

            labelError.Visible = false;
            labelUsername.Text = "User: " + parent.AccountName;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToLongDateString() + "\n" +
                DateTime.Now.ToShortTimeString();
        }

        private void labelError_TextChanged(object sender, EventArgs e) {
            labelError.Visible = true;
        }
    }
}
