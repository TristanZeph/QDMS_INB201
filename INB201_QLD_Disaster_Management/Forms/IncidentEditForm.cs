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


namespace INB201_QLD_Disaster_Management.Forms
{
    public partial class IncidentEditForm : Form
    {
        #region Fields

        private Main parent;                // provides access to public functions and SQL query
        private int incidentId;             // used to query incident information by its id value

        // list of incident types
        private const string FIRE = "Fire";
        private const string STORM = "Thunder Storm";
        private const string FLOOD = "Flood";
        private const string OTHER = "Other";

        string[] incidentTypes = { FIRE, STORM, FLOOD, OTHER };

        // list of incident statuses
        private const string POSSIBLE = "Possible";
        private const string ACTIVE = "Active";
        private const string ENDED = "Ended";

        string[] incidentStatuses = { POSSIBLE, ACTIVE, ENDED };

        #endregion 

        #region Constructor and Initialise

        /// <summary>
        /// Constructor. initialise comboxes
        /// </summary>
        public IncidentEditForm(Main parent)
        {
            InitializeComponent();
            Intialise();

            this.parent = parent;
        }

        /// <summary>
        /// initialise the combo boxes with their items inserted
        /// </summary>
        private void Intialise()
        {
            foreach (string type in incidentTypes)
                typeCombox.Items.Add(type);

            typeCombox.SelectedItem = OTHER;

            foreach (string status in incidentStatuses)
                statusCombox.Items.Add(status);

            statusCombox.SelectedItem = POSSIBLE;
        }

        #endregion

        /// <summary>
        /// inserts the incident information in their textboxes/comboboxes
        /// </summary>
        private void UpdateInformation()
        {
            string query = "SELECT * FROM incident WHERE id=" + incidentId;

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            //assign the query data
            idTextBox.Text = incidentId + "";
            locationTextBox.Text = data[1][0];
            statusCombox.SelectedItem = data[2][0];
            typeCombox.SelectedItem = data[3][0];
            messageTextBox.Text = data[6][0];
            startDateTextBox.Text = data[7][0].Split(' ')[0];
            endDateTextBox.Text = data[8][0].Split(' ')[0];
        }

        /// <summary>
        /// when form gets focus, update the incident form by its id
        /// </summary>
        private void IncidentEditForm_Activated(object sender, EventArgs e)
        {
            if (incidentId == 0)
            {
                idTextBox.Clear();
                ClearForm();
                removeButton.Visible = false;
            }
            else
            {
                UpdateInformation();
                removeButton.Visible = true;
            }
        }

        /// <summary>
        /// clears all textboxes and restores comboboxes to default values
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// clears all textboxes and restores comboboxes to default values
        /// </summary>
        private void ClearForm()
        {
            locationTextBox.Clear();
            typeCombox.SelectedItem = OTHER;
            statusCombox.SelectedItem = POSSIBLE;
            startDateTextBox.Clear();
            endDateTextBox.Clear();
            messageTextBox.Clear();
        }

        /// <summary>
        /// Updates or inserts incident data to the incident database
        /// </summary>
        private void applyButton_Click(object sender, EventArgs e)
        {
            // collect the information
            string location = locationTextBox.Text;
            string type = typeCombox.Text;
            string status = statusCombox.Text;
            string startDate = startDateTextBox.Text;
            string endDate = endDateTextBox.Text;
            string message = messageTextBox.Text;

            // if location is empty, show error
            if (location == "") 
            {
                MessageBox.Show("Location is empty. Please specify a value!"); 
                return;
            }

            //use geocoding to find latitude and longitude of a location
            PointLatLng point = GeoCoding.GetPoint(location);
            if (point == null)
            {
                MessageBox.Show("Specified location is invalid! Please try again.");
                return;
            }

            //get the points
            double lat = point.Lat;
            double lng = point.Lng;

            // create incident was selected
            if (incidentId == 0)
            {
                /* INSERT INTO incident (type, latitude, longitude, address, warnings, status, points, start_date, end_date)
                 * VALUES ('type', 'lat', 'long', 'location', 'message', 'status', 'points', 'startDate', 'endDate'); */
                string query = "INSERT INTO incident (type, latitude, longitude, address, warnings, status, points, start_date, end_date) " +
                               "VALUES ('" + type + "','" + lat + "','" + lng + "','" + location + "','" + message + "','" + status + 
                                        "','points','" + startDate + "','" + endDate + "')";
                
                parent.SQL.Insert(query);
                MessageBox.Show("Successfully created a new Incident!");
            }
            // edit incident was selected
            else    
            {
                string query = "UPDATE incident SET " +
                               "type='" + type + "',latitude='" + lat + "',longitude='" + lng + "',address='" + location + "',warnings='" + 
                               message + "',status='" + status + "',points='points',start_date='" + startDate + "',end_date='" + endDate + "' " +
                               "WHERE id=" + incidentId;

                parent.SQL.Update(query);
                MessageBox.Show("Successfully edited incident ID: " + incidentId + "!");
            }

            parent.OpenForm(parent.INCIDENT_QUERY);
        }

        /// <summary>
        /// Removes the incident from the database via ID
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to remove this incident?", 
                "Confirm?", 
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM incident WHERE id=" + incidentId;

                parent.SQL.Delete(query);
            }
        }

        /// <summary>
        /// Sets incident id by value
        /// </summary>
        public void SetIncidentId(int value)
        {
            incidentId = value;
        }
    }
}
