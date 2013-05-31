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
    /// This form displays the home page of the program. 
    /// Provides navigation to other forms and supports user login.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class HomeForm : Form {
        
        #region Fields
        // access SQL functions and form transitions
        private Main parent;

        private const string PUBLIC = "Public";
        #endregion

        #region Initialise

        /// <summary>
        /// Constructor, passes parent for more SQL and form transitions
        /// </summary>
        public HomeForm(Main parent) {
            InitializeComponent();
            this.parent = parent;

            timer1.Start();
        }

        #endregion

        #region Button Events
        /// <summary>
        /// Button Events open the page that is associated with the button
        /// </summary>
        private void buttonLogIn_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.LOGIN);
        }
        private void mapButton_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_MAP);
        }
        private void incidentButton_Click(object sender, EventArgs e) {
            if (parent.IsAdmin)
                parent.OpenForm(parent.INCIDENT_QUERY);
            else
                DisplayLabel(labelError, "Access Denied. Administrators only.");
        }
        private void personnelButton_Click(object sender, EventArgs e) {
            if (parent.IsAdmin)
                parent.OpenForm(parent.PERSONNEL_QUERY);
            else
                DisplayLabel(labelError, "Access Denied. Administrators only.");
        }
        private void reportsButton_Click(object sender, EventArgs e) {
            if (parent.IsAdmin)
                parent.OpenForm(parent.REPORTS);
            else
                DisplayLabel(labelError, "Access Denied. Administrators only.");
        }

        /// <summary>
        /// Allows user to logout of the system
        /// </summary>
        private void logoutButton_Click(object sender, EventArgs e) {
            buttonLogIn.Visible = true;
            logoutButton.Visible = false;
            parent.IsAdmin = false;
            parent.DisableAdminFunctions();
            parent.AccountName = "Public";
            labelUsername.Text = "User: " + parent.AccountName;

            DisplayLabel(labelError, "You have successfully logged out!");
        }

        #endregion

        #region Form Events 

        /// <summary>
        /// When form is activated, makes sure to display the correct
        /// log-in or log-out button. Hides all error labels.
        /// </summary>
        private void HomeForm_Activated(object sender, EventArgs e) {
            if (parent.IsAdmin) {
                buttonLogIn.Visible = false;
                logoutButton.Visible = true;
            } else {
                buttonLogIn.Visible = true;
                logoutButton.Visible = false;
            }

            labelError.Visible = false;
            labelUsername.Text = "User: " + parent.AccountName;
        }

        /// <summary>
        /// When the timer ticks at a certain amount, update the time
        /// label with the date and time.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToLongDateString() + "\n" +
                            DateTime.Now.ToShortTimeString();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Displays the error label in the screen with the corressponding message.
        /// </summary>
        private void DisplayLabel(Label label, string message) {
            label.Text = message;
            label.Visible = true;
        }

        #endregion
    }
}
