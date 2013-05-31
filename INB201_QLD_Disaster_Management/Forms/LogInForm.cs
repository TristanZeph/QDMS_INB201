using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INB201_QLD_Disaster_Management.Forms {
    /// <summary>
    /// Seperate log-in page for administrators. 
    /// Handles user log-ins queries.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class LogInForm : Form {

        #region Fields

        private Main parent;

        #endregion

        #region Initialise

        public LogInForm(Main parent) {
            InitializeComponent();

            this.parent = parent;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// Allows the user to login to the program
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e) {
            string user = usernameTextBox.Text;
            string pass = passwordTextBox.Text;
            string query = "SELECT count(*) FROM admin WHERE username='" + user + "'" +
                           " AND password='" + pass + "'";

            // if there is a login match, log into the system.
            // otherwise, display error messages
            if (parent.SQL.Count(query) > 0 && parent.IsAdmin == false) {

                parent.AccountName = usernameTextBox.Text;
                labelError.Visible = false;
                usernameTextBox.Clear();
                parent.IsAdmin = true;

                parent.EnableAdminFunctions();

                parent.OpenForm(parent.HOME);
            } else {
                labelError.Visible = true;
            }

            passwordTextBox.Clear();
        }

        /// <summary>
        /// Returns back to the home page
        /// </summary>
        private void buttonBack_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.HOME);
        }

        #endregion
    }
}
