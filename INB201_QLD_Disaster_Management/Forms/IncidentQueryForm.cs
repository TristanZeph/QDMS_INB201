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
    /// This form manages the incidents in the database.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class IncidentQueryForm : Form {

        #region Fields

        private Main parent;

        private const string ALL = "All";
        private const string NULL = "Select Incident";

        //column names of the datatable
        private string[] columnNameIncident = { "Id", "Location", "Status", 
                                                "Type", "Start Date", "End Date" };
        #endregion

        #region Initialise

        /// <summary>
        /// Form constructor. passes parent for extra functionality
        /// </summary>
        public IncidentQueryForm(Main parent) {
            InitializeComponent();
            this.parent = parent;

            Initialize();
        }

        /// <summary>
        /// Initializes the combo boxes
        /// </summary>
        private void Initialize() {
            // incidentId ComboBox Initialise
            incidentIdComboBox.Items.Add(NULL);
            incidentIdComboBox.SelectedItem = NULL;

            // incidentType ComboBox Initialise
            incidentTypeComboBox.Items.Add(ALL);
            foreach (string s in parent.IncidentTypes)
                incidentTypeComboBox.Items.Add(s);

            incidentTypeComboBox.SelectedItem = ALL;

            // incidentStatus ComboBox Initalise
            statusComboBox.Items.Add(ALL);
            foreach (string s in parent.IncidentStatuses)
                statusComboBox.Items.Add(s);

            statusComboBox.SelectedItem = ALL;
        }

        #endregion

        #region Datatable Methods

        /// <summary>
        /// Executes a query to the database for the incident information
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e) {
            string query = "SELECT * FROM incident ";
            List<string> whereStatements = new List<string>();

            // get the query data from the form. add them to the where statement llist
            if (incidentTypeComboBox.Text != ALL) {
                whereStatements.Add("type='" + incidentTypeComboBox.Text + "' ");
            }
            if (statusComboBox.Text != ALL) {
                whereStatements.Add("status='" + statusComboBox.Text + "' ");
            }
            if (locationTextBox.Text != "") {
                whereStatements.Add("address LIKE '" + locationTextBox.Text + "'");
            }

            // if there are elements in the list, create the WHERE sql statement
            if (whereStatements.Count > 0) {
                query += "WHERE " + whereStatements[0];

                if (whereStatements.Count > 1) {
                    for (int i = 1; i < whereStatements.Count; i++) {
                        query += "AND " + whereStatements[i];
                    }
                }
            }

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);

            //update the datatable
            if (data != null)
                UpdateDatatable(data);
        }

        /// <summary>
        /// Updates the datatable with new values
        /// </summary>
        private void UpdateDatatable(List<string>[] data) {
            DataTable table = new DataTable();
            int columns = columnNameIncident.Count();

            //set up the columns
            foreach (string column in columnNameIncident)
                table.Columns.Add(column, typeof(string));

            //insert the data to the table
            for (int i = 0; i < data[0].Count; i++) {
                object[] array = new object[columns];

                array[0] = data[0][i];      // id
                array[1] = data[1][i];      // address
                array[2] = data[2][i];      // status 
                array[3] = data[3][i];      // type
                array[4] = data[7][i];      // start_date
                array[5] = data[8][i];      // end_date

                table.Rows.Add(array);
            }

            //add the table as the source
            datagrid.DataSource = table;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Updates the incident id combobox
        /// </summary>
        private void UpdateIdComboBox() {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            // clear items so we dont get duplicates id's
            incidentIdComboBox.Items.Clear();
            incidentIdComboBox.Items.Add(NULL);

            //add incident id to the combobox
            for (int i = 0; i < data[0].Count(); i++) {
                string incident = data[0][i] + "; " + data[1][i];
                incidentIdComboBox.Items.Add(incident);
            }

            incidentIdComboBox.SelectedItem = NULL;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// The selected incident ID will be edited. Goes to the
        /// incident edit page
        /// </summary>
        private void editButton_Click(object sender, EventArgs e) {
            labelError.Visible = false;

            if (incidentIdComboBox.Text == NULL) {
                labelError.Visible = true;
                return;
            }

            int id = Int32.Parse(incidentIdComboBox.Text.Split(';')[0]);

            //open the incident edit form passing incident ID
            parent.IncidentEditForm.SetIncidentId(id);
            parent.OpenForm(parent.INCIDENT_EDIT);
        }

        /// <summary>
        /// opens incident edit form to create new incident
        /// </summary>
        private void createButton_Click(object sender, EventArgs e) {
            labelError.Visible = false;
            parent.IncidentEditForm.SetIncidentId(0);
            parent.OpenForm(parent.INCIDENT_EDIT);
        }

        /// <summary>
        /// Buttons that transitions the form
        /// </summary>
        private void buttonReports_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.REPORTS);
        }
        private void buttonMap_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_MAP);
        }
        private void buttonPersonnel_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.PERSONNEL_QUERY);
        }

        #endregion

        #region Form Events

        /// <summary>
        /// whenever the form .Activated() is called, 
        /// Update the form
        /// </summary>
        private void IncidentQueryForm_Activated(object sender, EventArgs e) {
            labelError.Visible = false;
            UpdateIdComboBox();
        }

        #endregion
    }
}