using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INB201_QLD_Disaster_Management.Forms {
    public partial class LogInForm : Form {

        private Main parent; 

        public LogInForm(Main parent) {
            InitializeComponent();

            this.parent = parent;
        }

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
            }
            else {
                labelError.Visible = true;
            }

            passwordTextBox.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.HOME);
        }
    }
}
