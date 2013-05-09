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
    public partial class IncidentQueryForm : Form
    {
        private Main parent;

        private const string ALL = "All";
        private const string NULL = "Null";

        //column names of the datatable
        private string[] columnNameIncident = { "id", "address", "status", 
                                                "type", "start_date", "end_date" };

        #region Initialise

        /// <summary>
        /// Form constructor. passes parent for extra functionality
        /// </summary>
        public IncidentQueryForm(Main parent)
        {
            InitializeComponent();
            this.parent = parent;

            Initialize();
        }

        /// <summary>
        /// Initializes the combo boxes
        /// </summary>
        private void Initialize()
        {
            // incidentId ComboBox Initialise
            incidentIdComboBox.Items.Add(NULL);
            incidentIdComboBox.SelectedItem = NULL;

            // incidentType ComboBox Initialise
            incidentTypeComboBox.Items.Add(ALL);
            foreach (string s in parent.incidentTypes)
                incidentTypeComboBox.Items.Add(s);

            incidentTypeComboBox.SelectedItem = ALL;

            // incidentStatus ComboBox Initalise
            statusComboBox.Items.Add(ALL);
            foreach (string s in parent.incidentStatuses)
                statusComboBox.Items.Add(s);

            statusComboBox.SelectedItem = ALL;
        }

        #endregion

        #region UpdateTable

        /// <summary>
        /// Executes a query to the database for the incident information
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM incident ";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);

            //update the datatable
            if (data != null) 
                UpdateDatatable(data);
        }

        /// <summary>
        /// Updates the datatable with new values
        /// </summary>
        private void UpdateDatatable(List<string>[] data)
        {
            DataTable table = new DataTable();
            int columns = columnNameIncident.Count();

            //set up the columns
            foreach (string column in columnNameIncident)
                table.Columns.Add(column, typeof(string));

            //insert the data to the table
            for (int i = 0; i < data[0].Count; i++)
            {
                object[] array = new object[columns];

                array[0] = data[0][i];
                array[1] = data[1][i];
                array[2] = data[2][i];
                array[3] = data[3][i];
                array[4] = data[7][i];
                array[5] = data[8][i];

                table.Rows.Add(array);   
            }

            //add the table as the source
            datagrid.DataSource = table;
        }

        #endregion

        /// <summary>
        /// Updates the incident id combobox
        /// </summary>
        private void UpdateIdComboBox()
        {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            // clear items so we dont get duplicates id's
            incidentIdComboBox.Items.Clear();
            incidentIdComboBox.Items.Add(NULL);

            //add incident id to the combobox
            for (int i = 0; i < data[0].Count(); i++)
                incidentIdComboBox.Items.Add(data[0][i]);

            incidentIdComboBox.SelectedItem = NULL;
        }

        /// <summary>
        /// The selected incident ID will be edited. Goes to the
        /// incident edit page
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (incidentIdComboBox.Text == NULL) return;

            int id = Int32.Parse(incidentIdComboBox.Text);

            //open the incident edit form passing incident ID
            parent.IncidentEditForm.SetIncidentId(id);
            parent.OpenForm(parent.INCIDENT_EDIT);
        }

        /// <summary>
        /// opens incident edit form to create new incident
        /// </summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            parent.IncidentEditForm.SetIncidentId(0);
            parent.OpenForm(parent.INCIDENT_EDIT);
        }

        /// <summary>
        /// whenever the form .Activated() is called, 
        /// Update the form
        /// </summary>
        private void IncidentQueryForm_Activated(object sender, EventArgs e)
        {
            UpdateIdComboBox();
        }
    }
}