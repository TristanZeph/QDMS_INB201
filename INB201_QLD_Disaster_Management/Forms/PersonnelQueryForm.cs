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
    public partial class PersonnelQueryForm : Form
    {
        private Main parent;                // allows access to other public functions in the main form

        private const string ALL = "All";
        private const string NULL = "Null";

        /// <summary>
        /// constructor, passes parent for more functionality
        /// </summary>
        public PersonnelQueryForm(Main parent)
        {
            InitializeComponent();
            this.parent = parent;

            Initialize();
        }

        /// <summary>
        /// Initialises the comboboxes
        /// </summary>
        private void Initialize()
        {
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
            incidentIdCB.Items.Add(ALL);
            incidentIdCB.SelectedItem = ALL;
        }

        /// <summary>
        /// Updates the personnel id comboBox
        /// </summary>
        private void UpdatePersonnelId()
        {
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
        private void UpdateIncidentId()
        {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            // clear items so we dont get duplicates id's
            incidentIdCB.Items.Clear();
            incidentIdCB.Items.Add(NULL);

            //add incident id to the combobox
            for (int i = 0; i < data[0].Count(); i++)
            {
                string name = data[0][i] + "; " + data[1][i];
                incidentIdCB.Items.Add(name);
            }

            incidentIdCB.SelectedItem = NULL;
        }

        /// <summary>
        /// Executes a query that returns information of personnel 
        /// to form a table
        /// </summary>
        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personnel ";

            //get query data
            List<string>[] data = parent.SQL.SelectPersonnel(query);

            //update the datatable
            if (data != null)
                UpdateDatatable(data);
        }

        /// <summary>
        /// creates a table of personnel information
        /// </summary>
        private void UpdateDatatable(List<string>[] data)
        {
            DataTable table = new DataTable();
            int columns = parent.SQL.columnNamePersonnel.Count();

            //set up the columns
            foreach (string column in parent.SQL.columnNamePersonnel)
                table.Columns.Add(column, typeof(string));

            //insert the data to the table
            for (int i = 0; i < data[0].Count; i++)
            {
                object[] array = new object[columns];

                //iterate through the data of one incident
                for (int j = 0; j < columns; j++)
                    array[j] = data[j][i];

                table.Rows.Add(array);
            }

            //add the table as the source
            datagrid.DataSource = table;
        }

        /// <summary>
        /// Opens the personnel information page to create a new personnel
        /// </summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            parent.PersonnelEditForm.SetPersonnelId(0);
            parent.OpenForm(parent.PERSONNEL_EDIT);
        }

        /// <summary>
        /// when form gets focus, update the combo boxes
        /// </summary>
        private void PersonnelQueryForm_Activated(object sender, EventArgs e)
        {
            UpdatePersonnelId();
            UpdateIncidentId();
        }

        /// <summary>
        /// edit button opens the edit form of the selected personnel id
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (personnelIdComboBox.Text != NULL)
            {
                int id = Int32.Parse(personnelIdComboBox.Text);
                parent.PersonnelEditForm.SetPersonnelId(id);
                parent.OpenForm(parent.PERSONNEL_EDIT);
            }
            else
            {
                MessageBox.Show("Please select a personnel Id to edit!");
            }
        }
    }
}
