using System;
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
        }
        #endregion

        #region Button Events
        /// <summary>
        /// Allows the user to login to the program
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
            string pass = passwordTextBox.Text;
            string query = "SELECT count(*) FROM admin WHERE username='" + user + "'" +
                           " AND password='" + pass + "'";

            // if there is a login match, log into the system.
            // otherwise, display error messages
            if (parent.SQL.Count(query) > 0 && parent.IsAdmin == false)
            {
                userLabel.Text = user;
                logoutButton.Visible = true;
                parent.IsAdmin = true;
                usernameTextBox.Clear();
                parent.EnableAdminFunctions();

                MessageBox.Show("Welcome, " + user);
            }
            else if (parent.SQL.Count(query) > 0 && parent.IsAdmin == true)
            {
                MessageBox.Show("Please logout before signing in again!");
            }
            else
            {
                MessageBox.Show("Username or password invalid!");
            }

            passwordTextBox.Clear();
        }

        /// <summary>
        /// Allows user to logout of the system
        /// </summary>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            userLabel.Text = PUBLIC;
            logoutButton.Visible = false;
            parent.IsAdmin = false;
            parent.DisableAdminFunctions();

            MessageBox.Show("You have successfully logged out!");
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
                MessageBox.Show("Access Denied! Admins only.");
        }

        /// <summary>
        /// Opens the personnel page. validate whether there is an admin
        /// </summary>
        private void personnelButton_Click(object sender, EventArgs e)
        {
            if (parent.IsAdmin)
                parent.OpenForm(parent.PERSONNEL_QUERY);
            else
                MessageBox.Show("Access Denied! Admins only.");
        }

        /// <summary>
        /// Opens the reports page. validates whether there is an admin
        /// </summary>
        private void reportsButton_Click(object sender, EventArgs e)
        {
            if (parent.IsAdmin)
                parent.OpenForm(parent.REPORTS);
            else
                MessageBox.Show("Access Denied! Admins only.");
        }
        #endregion
    }
}
