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
    /// This page manages the personnel information in the database.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class PersonnelQueryForm : Form {

        #region Fields

        // allows access to other public functions in the main form
        private Main parent;

        private const string ALL = "All";
        private const string NULL = "Select Personnel";
        private const string ALL_INCIDENTS = "All Incidents";

        private string[] columnNamePersonnel = { "Id", "Assigned Incident", "First Name", 
                                                  "Last Name", "Type", "Status", "Hours Worked"};

        #endregion

        #region Initialise

        /// <summary>
        /// constructor, passes parent for more functionality
        /// </summary>
        public PersonnelQueryForm(Main parent) {
            InitializeComponent();
            this.parent = parent;

            Initialize();
        }

        /// <summary>
        /// Initialises the comboboxes
        /// </summary>
        private void Initialize() {
            //initialise personnel id ComboBox
            personnelIdComboBox.Items.Add(NULL);
            personnelIdComboBox.SelectedItem = NULL;

            //initialise personnel type comboBox
            PersonnelTypeComboBox.Items.Add(ALL);
            foreach (string s in parent.PersonnelTypes)
                PersonnelTypeComboBox.Items.Add(s);

            PersonnelTypeComboBox.SelectedItem = ALL;

            // intialise status comboBox
            statusComboBox.Items.Add(ALL);
            foreach (string s in parent.PersonnelStatuses)
                statusComboBox.Items.Add(s);

            statusComboBox.SelectedItem = ALL;

            //initialise incidentidCombox
            incidentIdCB.Items.Add(ALL_INCIDENTS);
            incidentIdCB.SelectedItem = ALL_INCIDENTS;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// Executes a query that returns information of personnel 
        /// to form a table
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM personnel ";
            List<string> whereStatements = new List<string>();

            // get the query data from the form. add them to the where statement llist
            if (incidentIdCB.Text != ALL_INCIDENTS) {
                whereStatements.Add("incident_id=" + incidentIdCB.Text.Split(';')[0] + " ");
            }
            if (PersonnelTypeComboBox.Text != ALL) {
                whereStatements.Add("type='" + PersonnelTypeComboBox.Text + "' ");
            }
            if (statusComboBox.Text != ALL) {
                whereStatements.Add("status='" + statusComboBox.Text + "' ");
            }
            if (fNameBox.Text != "") {
                whereStatements.Add("first_name='" + fNameBox.Text + "' ");
            }
            if (lNameBox.Text != "") {
                whereStatements.Add("last_name='" + lNameBox.Text + "' ");
            }

            // generate the where statement
            if (whereStatements.Count > 0) {
                query += "WHERE " + whereStatements[0];

                if (whereStatements.Count > 1) {
                    for (int i = 1; i < whereStatements.Count; i++) {
                        query += "AND " + whereStatements[i];
                    }
                }
            }

            //get query data
            List<string>[] data = parent.SQL.SelectPersonnel(query);

            //update the datatable
            if (data != null)
                UpdateDatatable(data);
        }

        /// <summary>
        /// Opens the personnel information page to create a new personnel
        /// </summary>
        private void createButton_Click(object sender, EventArgs e) {
            labelError.Visible = false;
            parent.PersonnelEditForm.SetPersonnelId(0);
            parent.OpenForm(parent.PERSONNEL_EDIT);
        }

        /// <summary>
        /// edit button opens the edit form of the selected personnel id
        /// </summary>
        private void editButton_Click(object sender, EventArgs e) {
            labelError.Visible = false;
           
            if (personnelIdComboBox.Text != NULL) {
                int id = Int32.Parse(personnelIdComboBox.Text);
                parent.PersonnelEditForm.SetPersonnelId(id);
                parent.OpenForm(parent.PERSONNEL_EDIT);
            } else {
                labelError.Visible = true;
            }
        }

        private void buttonIncident_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_QUERY);
        }

        private void buttonReports_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.REPORTS);
        }

        private void buttonMap_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_MAP);
        }

        #endregion

        #region Form Events

        /// <summary>
        /// when form gets focus, update the combo boxes
        /// </summary>
        private void PersonnelQueryForm_Activated(object sender, EventArgs e) {
            labelError.Visible = false;
            UpdatePersonnelId();
            UpdateIncidentId();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// creates a table of personnel information
        /// </summary>
        private void UpdateDatatable(List<string>[] data) {
            DataTable table = new DataTable();
            int columns = columnNamePersonnel.Count();

            //set up the columns
            foreach (string column in columnNamePersonnel)
                table.Columns.Add(column, typeof(string));

            //iterate through the data of one incident
            for (int i = 0; i < data[0].Count; i++) {
                object[] array = new object[columns];

                array[0] = data[0][i];      // id
                array[1] = data[8][i];      // assigned incident
                array[2] = data[1][i];      // first name
                array[3] = data[2][i];      // last name
                array[4] = data[3][i];      // type
                array[5] = data[4][i];      // status
                array[6] = data[5][i];      // hours worked

                table.Rows.Add(array);
            }

            //add the table as the source
            datagrid.DataSource = table;
        }

        /// <summary>
        /// Updates the personnel id comboBox
        /// </summary>
        private void UpdatePersonnelId() {
            string query = "SELECT * FROM personnel";

            //get query data
            List<string>[] data = parent.SQL.SelectPersonnel(query);
            if (data == null) return;

            // clear items so we dont get duplicates id's
            personnelIdComboBox.Items.Clear();
            personnelIdComboBox.Items.Add(NULL);

            //add incident id to the combobox
            for (int i = 0; i < data[0].Count(); i++)
                personnelIdComboBox.Items.Add(data[0][i]);

            personnelIdComboBox.SelectedItem = NULL;
        }

        /// <summary>
        /// Updates the IncidentId ComboBox
        /// </summary>
        private void UpdateIncidentId() {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            // clear items so we dont get duplicates id's
            incidentIdCB.Items.Clear();
            incidentIdCB.Items.Add(ALL_INCIDENTS);

            //add incident id to the combobox
            for (int i = 0; i < data[0].Count(); i++) {
                string name = data[0][i] + "; " + data[1][i];
                incidentIdCB.Items.Add(name);
            }

            incidentIdCB.SelectedItem = ALL_INCIDENTS;
        }

        #endregion
    }
}
