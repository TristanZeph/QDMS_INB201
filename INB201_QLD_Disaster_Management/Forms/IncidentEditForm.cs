using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GMap.NET;
using INB201_QLD_Disaster_Management.Helper_Classes;


namespace INB201_QLD_Disaster_Management.Forms {
    /// <summary>
    /// This forms enables creating and editing Incident infomation.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class IncidentEditForm : Form {

        #region Fields

        private Main parent;                // provides access to public functions and SQL query
        private int incidentId;             // used to query incident information by its id value

        #endregion

        #region Initialise

        /// <summary>
        /// Constructor. Initialise comboxes
        /// </summary>
        public IncidentEditForm(Main parent) {
            InitializeComponent();
            this.parent = parent;
            Intialise();
        }

        /// <summary>
        /// Initialise the combo boxes with their items inserted.
        /// Set the first element as the initial value.
        /// </summary>
        private void Intialise() {
            // incidentTypes combobox
            foreach (string type in parent.IncidentTypes)
                typeCombox.Items.Add(type);

            typeCombox.SelectedIndex = 0;

            // incidentStatus combobox
            foreach (string status in parent.IncidentStatuses)
                statusCombox.Items.Add(status);

            statusCombox.SelectedIndex = 0;
        }

        #endregion

        #region Button Events
        private void buttonGoBack_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_QUERY);
        }
        private void buttonPersonnel_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.PERSONNEL_QUERY);
        }
        private void buttonReports_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.REPORTS);
        }
        private void buttonMap_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_MAP);
        }

        /// <summary>
        /// Clears the form
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e) {
            ClearForm();
        }

        /// <summary>
        /// Removes the incident from the database. and returns to the incident query page
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to remove this incident?",
                "Confirm?",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                // delete the query
                string query = "DELETE FROM incident WHERE id=" + incidentId;
                parent.SQL.Delete(query);

                // confirm message
                MessageBox.Show("Incident ID: " + incidentId + " has been removed successfully!");
                parent.OpenForm(parent.INCIDENT_QUERY);
            }
        }

        /// <summary>
        /// Updates or inserts incident data to the incident database
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e) {
            // hide/confirm the error messages
            labelError.Visible = false;
            labelConfirm.Visible = false;

            // collect the information
            string location = locationTextBox.Text;
            string type = typeCombox.Text;
            string status = statusCombox.Text;
            string startDate = dateTimePicker.Text;
            string message = messageTextBox.Text;

            // validate the form before we proceed
            if (ValidateForm()) return;

            // get lat and lng of the location
            PointLatLng point = new PointLatLng();
            if (GeoCoding.IsAddressValid(location + " Australia")) {
                point = GeoCoding.GetPoint(location + " Australia");
            } else {
                //show error
                DisplayLabel(labelError, "Address is not a valid location.");
                return;
            }

            //get the points
            double lat = point.Lat;
            double lng = point.Lng;

            // create incident was selected
            if (incidentId == 0) {
                string query = "INSERT INTO incident (type, latitude, longitude, address, warnings, status, points, start_date) " +
                               "VALUES ('" + type + "','" + lat + "','" + lng + "','" + location + "','" + message + "','" + status +
                                        "','points','" + startDate + "')";

                parent.SQL.Insert(query);
                DisplayLabel(labelConfirm, "Successfully created an incident.");
            }
                // edit incident was selected
            else {
                string query = "UPDATE incident SET " +
                               "type='" + type + "',latitude='" + lat + "',longitude='" + lng + "',address='" + location + "',warnings='" +
                               message + "',status='" + status + "',start_date='" + startDate + "' " +
                               "WHERE id=" + incidentId;

                parent.SQL.Update(query);
                DisplayLabel(labelConfirm, "Successfully edited incident ID: " + incidentId + ".");
            }
        }

        #endregion

        #region Form Events

        /// <summary>
        /// when form gets focus, update the incident form by its id
        /// </summary>
        private void IncidentEditForm_Activated(object sender, EventArgs e) {
            if (incidentId == 0) {
                ClearForm();
                removeButton.Visible = false;
            } else {
                UpdateInformation();
                removeButton.Visible = true;
            }

            labelConfirm.Visible = false;
            labelError.Visible = false;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Sets incident id by value
        /// </summary>
        public void SetIncidentId(int value) {
            incidentId = value;
        }

        /// <summary>
        /// inserts the incident information in their textboxes/comboboxes
        /// </summary>
        private void UpdateInformation() {
            string query = "SELECT * FROM incident WHERE id=" + incidentId;

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            //assign the query data
            locationTextBox.Text = data[1][0];
            statusCombox.SelectedItem = data[2][0];
            typeCombox.SelectedItem = data[3][0];
            messageTextBox.Text = data[6][0];
            dateTimePicker.Text = data[7][0].Split(' ')[0];
        }

        /// <summary>
        /// clears all textboxes and restores comboboxes to default values
        /// </summary>
        private void ClearForm() {
            locationTextBox.Clear();
            typeCombox.SelectedIndex = 0;
            statusCombox.SelectedIndex = 0;
            messageTextBox.Clear();
        }

        /// <summary>
        /// Validates the inputs in the form when Apply button is clicked.
        /// </summary>
        /// <returns>
        /// Returns true if there are any errors.
        /// Returns false if validation passes
        /// </returns>
        private bool ValidateForm() {
            if (Valid.Null(locationTextBox.Text)) {
                DisplayLabel(labelError, "Location must have an input value.");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Assigns the label with text.
        /// Shows the label on the screen.
        /// </summary>
        private void DisplayLabel(Label label, string text) {
            label.Text = text;
            label.Visible = true;
        }

        #endregion
    }
}
