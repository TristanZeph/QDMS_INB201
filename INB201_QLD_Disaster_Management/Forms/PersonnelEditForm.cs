using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using INB201_QLD_Disaster_Management.Helper_Classes;

namespace INB201_QLD_Disaster_Management.Forms
{
    public partial class PersonnelEditForm : Form
    {
        Main parent;
        int personnelId;

        //default values
        private const string NONE = "None";
        private const string VOLUNTEER = "Volunteer";
        private const string UNASSIGNED = "Unassigned";

        /// <summary>
        /// Constructor, passes main form for more functionality
        /// </summary>
        public PersonnelEditForm(Main form)
        {
            InitializeComponent();

            parent = form;
            Intialize();
        }

        /// <summary>
        /// Initialises comboboxes
        /// </summary>
        private void Intialize()
        {
            //assignmentCB Update
            assignmentCB.Items.Add(NONE);
            assignmentCB.SelectedItem = NONE;

            //personnel type CB update
            foreach (string type in parent.PersonnelTypes)
                typeCB.Items.Add(type);

            typeCB.SelectedItem = VOLUNTEER;

            //personnel status CB update
            foreach (string status in parent.PersonnelStatuses)
                statusCB.Items.Add(status);

            statusCB.SelectedItem = UNASSIGNED;

            // continuous hours CB initialise
            for (int i = 0; i < 25; i++)
                comboBoxHours.Items.Add(i);

            comboBoxHours.SelectedIndex = 0;
        }

        /// <summary>
        /// Updates the assignment comboBox with incident ID and location
        /// </summary>
        private void UpdateAssignmentCB()
        {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            //clear comboBox so we dont get duplicate information
            assignmentCB.Items.Clear();
            assignmentCB.Items.Add(NONE);
            assignmentCB.SelectedItem = NONE;

            //insert incident info in assignmentCB
            for (int i = 0; i < data[0].Count(); i++)
            {
                string name = data[0][i] + "; " + data[1][i];
                assignmentCB.Items.Add(name);
            }
        }

        /// <summary>
        /// when form get focus, update the combo boxes
        /// </summary>
        private void PersonnelEditForm_Activated(object sender, EventArgs e)
        {
            UpdateAssignmentCB();

            if (personnelId > 0)
                UpdateInformation();
            else
            {
                Clear();
            }
        }

        /// <summary>
        /// inserts the incident information in their textboxes/comboboxes
        /// </summary>
        private void UpdateInformation()
        {
            string query = "SELECT * FROM personnel WHERE id=" + personnelId;

            //get query data
            List<string>[] data = parent.SQL.SelectPersonnel(query);
            if (data == null) return;

            //assign the query data
            fNameTextBox.Text = data[1][0];
            lNameTextBox.Text = data[2][0];
            typeCB.SelectedItem = data[3][0];
            statusCB.SelectedItem = data[4][0];
            comboBoxHours.Text = data[5][0];
            startTimeTextBox.Text = data[6][0];
            endTimeTextBox.Text = data[7][0];

            //query incident information to get address
            query = "SELECT * FROM incident WHERE id=" + data[8][0];
            List<string>[] incidentData = parent.SQL.SelectIncident(query);
            if (incidentData == null) return;

            //combine incident id and address together
            string name = incidentData[0][0] + "; " + incidentData[1][0];
            assignmentCB.SelectedItem = name;
        }

        /// <summary>
        /// Executes insert or update sql query
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {
            HideErrors();

            // validate the form. If we find errors, do not continue.
            if (ValidateForm()) {
                return;
            }

            string incidentId;
            string fName = fNameTextBox.Text;
            string lName = lNameTextBox.Text;
            string type = typeCB.Text;
            string status = statusCB.Text;
            string startTime = startTimeTextBox.Text;
            string endTime = endTimeTextBox.Text;
            string hours = comboBoxHours.Text;

            //gets incident id from text. if there is no assignment, we get null
            if (assignmentCB.Text != NONE)
                incidentId = assignmentCB.Text.Split(';')[0];
            else
                incidentId = null;

            // if create button was selected. use insert query
            if (personnelId == 0)
            {
                string query = "INSERT INTO personnel (first_name, last_name, type, status, working_hours, start_time, end_time, incident_id) " +
                               "VALUES ('" + fName + "','" + lName + "','" + type + "','" + status + "','" + hours + "','" + startTime +
                                        "','" + endTime + "','";

                if (incidentId != null)
                    query += incidentId;

                query += "')";

                parent.SQL.Insert(query);
                ShowLabelError(labelConfirm, "Successfully created new Personnel.");
            }
            // else edit button was selected. use update query
            else
            {
                string query = "UPDATE personnel " +
                               "SET first_name='" + fName + "',last_name='" + lName + "',type='" + type + "',status='" + status +
                               "',working_hours='" + hours + "',start_time='" + startTime + "',end_time='" + endTime + "'";

                if (incidentId != null)
                    query += ",incident_id='" + incidentId + "' ";
                
                query += "WHERE id=" + personnelId;

                parent.SQL.Update(query);
                ShowLabelError(labelConfirm, "Successfully updated Personnel ID: " + personnelId);
            }
        }

        /// <summary>
        /// Sets the personnelId to pass information from the personnel 
        /// query page
        /// </summary>
        public void SetPersonnelId(int value)
        {
            personnelId = value;
        }

        /// <summary>
        /// clears all forms
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// clears all forms
        /// </summary>
        private void Clear()
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            assignmentCB.SelectedItem = NONE;
            typeCB.SelectedItem = VOLUNTEER;
            statusCB.SelectedItem = UNASSIGNED;
            startTimeTextBox.Clear();
            endTimeTextBox.Clear();
            comboBoxHours.SelectedIndex = 0;
        }

        private void buttonIncident_Click(object sender, EventArgs e) {
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
        /// Executes validation when user hits the submit (apply) button.
        /// </summary>
        /// <returns>
        /// Returns true, if validation fails.
        /// Otherwise, return false. (validation passes)</returns>
        private bool ValidateForm() {
            List<Label> labels = new List<Label>();

            if (Helper_Classes.Validate.LettersOnly(fNameTextBox.Text) ||
                Helper_Classes.Validate.Null(fNameTextBox.Text)) {
                labels.Add(labelErrorFName);
            }
            if (Helper_Classes.Validate.LettersOnly(lNameTextBox.Text) ||
                Helper_Classes.Validate.Null(lNameTextBox.Text)) {
                labels.Add(labelErrorLName);
            }
            if (Helper_Classes.Validate.NumbersOnly(startTimeTextBox.Text) ||
                Helper_Classes.Validate.Null(startTimeTextBox.Text)) {
                labels.Add(labelErrorStart);
            }
            if (Helper_Classes.Validate.NumbersOnly(endTimeTextBox.Text) ||
                Helper_Classes.Validate.Null(endTimeTextBox.Text)) {
                    labels.Add(labelErrorEnd);
            }

            if (labels.Count() > 0) {
                foreach (Label l in labels) {
                    l.Visible = true;
                }

                return true;
            }

            return false;
        }

        private void ShowLabelError(Label label, string message) {
            label.Text = message;
            label.Visible = true;
        }

        private void HideErrors() {
            labelErrorEnd.Visible = false;
            labelErrorStart.Visible = false;
            labelErrorFName.Visible = false;
            labelErrorLName.Visible = false;
            labelConfirm.Visible = false;
        }
    }
}
