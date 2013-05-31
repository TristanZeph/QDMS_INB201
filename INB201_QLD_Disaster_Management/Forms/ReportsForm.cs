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
    /// This form displays reports of the incidents.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class ReportsForm : Form {

        #region Fields

        private Main parent;
        private const string ALL = "All Incidents";

        #endregion

        #region Initialise

        /// <summary>
        /// constructor. pass parent for SQL queries
        /// </summary>
        public ReportsForm(Main parent) {
            InitializeComponent();
            Initialize();

            this.parent = parent;
        }

        /// <summary>
        /// Set up the incident id combobox
        /// </summary>
        private void Initialize() {
            incidentIdCB.Items.Add(ALL);
            incidentIdCB.SelectedItem = ALL;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// updates the combo box with incident information
        /// </summary>
        private void UpdateComboBox() {
            string query = "SELECT * FROM incident";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            //clear to avoid duplicates
            incidentIdCB.Items.Clear();
            incidentIdCB.Items.Add(ALL);
            incidentIdCB.SelectedItem = ALL;

            //insert incident id into the combo box
            for (int i = 0; i < data[0].Count(); i++) {
                string name = data[0][i] + "; " + data[1][i];
                incidentIdCB.Items.Add(name);
            }

            incidentIdCB.SelectedItem = 0;
        }

        /// <summary>
        /// gets a report of all incidents occurs in the qld region
        /// </summary>
        private void AllIncidentReport() {
            string report = "Report Begin \r\n============\r\n\n" +
                            "Report Executed: All Incidents \r\n" +
                            "Time of Report: " + DateTime.Now.ToString();

            report += "\r\n\r\n   --- Incident Data ---";

            //get total count of incidents
            report += "\r\n\r\nTotal Incidents: " + parent.SQL.Count("SELECT count(*) FROM incident");
            report += "\r\n\r\nIncident Status \r\n===============";

            //get status of incidents
            foreach (string status in parent.IncidentStatuses)
                report += "\r\n" + status + ": " +
                    parent.SQL.Count("SELECT count(*) FROM incident WHERE status='" + status + "'");

            report += "\r\n\r\nTotal types of Incidents \r\n========================";

            //get type count of incidents
            foreach (string type in parent.IncidentTypes) {
                int count = parent.SQL.Count("SELECT count(*) FROM incident WHERE type='" + type + "'");
                if (count > 0)
                    report += "\r\n" + type + ": " + count;
            }

            report += "\r\n\r\n   --- Personnel Data ---";

            //get total personnel and types count
            report += "\r\n\r\nTotal Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel");
            report += "\r\n\r\nTotal Types of Personnel \r\n========================";

            foreach (string type in parent.PersonnelTypes) {
                int count = parent.SQL.Count("SELECT count(*) FROM personnel WHERE type='" + type + "'");
                if (count > 0)
                    report += "\r\n" + type + ": " + count;
            }

            //report missing or deceased personnel
            report += "\r\n\r\nMissing Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel WHERE status='Missing'");
            report += "\r\nDeceased Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel WHERE status='Deceased'");

            //output the report in the textbox
            messageTB.Text = report;
        }

        /// <summary>
        /// generates an individual incident report
        /// </summary>
        private void IndividualIncidentReport() {
            string id = incidentIdCB.Text.Split(';')[0];

            //get incident data
            List<string>[] data = parent.SQL.SelectIncident("SELECT * FROM incident WHERE id=" + id);
            if (data == null) return;

            //start the report
            string report = "Report Begin \r\n============\r\n\n" +
                            "Report Executed: Individual Incident \r\n" +
                            "Time of Report: " + DateTime.Now.ToString();

            //get incident data
            report += "\r\n\r\n   --- Incident Data ---";
            report += "\r\n\r\nIncident ID: " + id;
            report += "\r\nLocation: " + data[1][0];
            report += "\r\nStatus: " + data[2][0];
            report += "\r\nType: " + data[3][0];
            report += "\r\nStart Date: " + data[7][0];
            report += "\r\nEnd Date: " + data[8][0];

            report += "\r\n\r\n   --- Personnel Data ---";

            //get total personnel and types count
            report += "\r\n\r\nTotal Assigned Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel WHERE incident_id=" + id);
            report += "\r\n\r\nTotal Types of Personnel \r\n========================";

            foreach (string type in parent.PersonnelTypes) {
                int count = parent.SQL.Count("SELECT count(*) FROM personnel WHERE type='" + type + "' AND incident_id=" + id);
                if (count > 0)
                    report += "\r\n" + type + ": " + count;
            }

            //report missing or deceased personnel
            report += "\r\n\r\nMissing Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel WHERE status='Missing' AND incident_id=" + id);
            report += "\r\nDeceased Personnel: " + parent.SQL.Count("SELECT count(*) FROM personnel WHERE status='Deceased' AND incident_id=" + id);

            messageTB.Text = report;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// Returns information regarding to the incidents
        /// </summary>
        private void getButton_Click(object sender, EventArgs e) {
            messageTB.Clear();

            if (incidentIdCB.Text == ALL)
                AllIncidentReport();
            else
                IndividualIncidentReport();
        }

        /// <summary>
        /// Buttons that transition to a different page.
        /// </summary>
        private void buttonPersonnel_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.PERSONNEL_QUERY);
        }
        private void buttonIncident_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_QUERY);
        }

        private void buttonMap_Click(object sender, EventArgs e) {
            parent.OpenForm(parent.INCIDENT_MAP);
        }

        #endregion

        #region Form Events

        /// <summary>
        /// when form gets focus, update the combo box
        /// </summary>
        private void ReportsForm_Activated(object sender, EventArgs e) {
            UpdateComboBox();
        }

        #endregion
    }
}
