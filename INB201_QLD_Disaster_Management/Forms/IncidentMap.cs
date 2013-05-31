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
    /// This form displays the incident map of the disaster database.
    /// It displays information of the incident and displays a marker of its location.
    /// 
    /// Author: Tristan Le
    /// ID:     N8320055
    /// </summary>
    public partial class IncidentMap : Form {

        #region Fields

        private Main parent;
        private GoogleMap map;

        //temporary variables that stores the lat and lng of an incident.
        //used to create a point and zoom to the incident location
        private double tempLat;
        private double tempLng;

        private const string NONE = "None";

        #endregion

        #region Initialise

        /// <summary>
        /// constructor. passes main form for more functionality
        /// </summary>
        public IncidentMap(Main form) {
            InitializeComponent();
            parent = form;

            Initialize();
        }

        /// <summary>
        /// initialises the map
        /// </summary>
        private void Initialize() {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            map = new GoogleMap(gmap, parent);
            map.GoToDefaultLocation();

            timer1.Start();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Updates the incident id combobox
        /// </summary>
        private void UpdateIncidentId() {
            string query = "SELECT * FROM incident WHERE status='Possible' OR status='Active'";

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            //clear combo box to avoid duplicates
            incidentCB.Items.Clear();

            //insert into the combo box
            for (int i = 0; i < data[0].Count(); i++) {
                string name = data[0][i] + "; " + data[1][i];
                incidentCB.Items.Add(name);
            }

            //if we have elements, make the first element the default selection
            if (incidentCB.Items.Count == 0) incidentCB.Items.Add(NONE);
            incidentCB.SelectedIndex = 0;
        }

        /// <summary>
        /// Update the incident information fields when an incident as been selected
        /// </summary>
        private void UpdateIncidentInformation() {
            string id = incidentCB.Text.Split(';')[0];
            string query = "SELECT * FROM incident WHERE id=" + id;

            //get query data
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            statusTB.Text = data[2][0];
            typeTB.Text = data[3][0];
            messageTB.Text = data[6][0];

            //get map coordinates
            double lat = Double.Parse(data[4][0]);
            double lng = Double.Parse(data[5][0]);
            tempLat = lat;
            tempLng = lng;
            PointLatLng point = new PointLatLng(lat, lng);

            //zoom to the location
            map.SetMapCoordinates(point);
            gmap.Zoom = 12;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// restores the map to the default location
        /// </summary>
        private void restoreButton_Click(object sender, EventArgs e) {
            map.GoToDefaultLocation();
        }

        /// <summary>
        /// Zooms to the selected incident
        /// </summary>
        private void goToButton_Click(object sender, EventArgs e) {
            PointLatLng point = new PointLatLng(tempLat, tempLng);
            map.SetMapCoordinates(point);
            gmap.Zoom = 12;
        }

        #endregion

        #region Form Events

        /// <summary>
        /// Alters the zoom level of the map
        /// </summary>
        private void zoomScroll_Scroll(object sender, ScrollEventArgs e) {
            gmap.Zoom = zoomScroll.Value * -1;
        }

        /// <summary>
        /// On click marker. Zooms directly to the incident.
        /// </summary>
        private void gmap_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e) {
            string id = item.ToolTipText.Split(';')[0];         // get the id from tool tip

            // compare id values with the incident Combobox
            for (int i = 0; i < incidentCB.Items.Count; i++) {
                //id of combobox
                string id2 = incidentCB.Items[i].ToString().Split(';')[0];

                if (id == id2) {
                    incidentCB.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// Updates the time on the screen
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e) {
            labelTime.Text = DateTime.Now.ToLongDateString() + "\n" +
                DateTime.Now.ToShortTimeString();
        }

        // when form gets focus, update the combo box
        private void IncidentMap_Activated(object sender, EventArgs e) {
            UpdateIncidentId();
            map.UpdateMapMarkers();
        }

        /// <summary>
        /// when the combo box has been selected. update the incident information
        /// </summary>
        private void incidentCB_SelectedIndexChanged(object sender, EventArgs e) {
            if (incidentCB.Text != NONE)
                UpdateIncidentInformation();
        }

        #endregion

    }
}
