using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace INB201_QLD_Disaster_Management.Helper_Classes {
    /// <summary>
    /// This class handles the controls of the GMap.Net control.
    /// </summary>
    public class GoogleMap {
        private static string DEFAULT_LOCATION = "Emerald, Queensland";
        private GMapControl gmap;
        private Main parent;                    // for SQL queries

        /// <summary>
        /// Constructors GoogleMap and sets gmap and the parent.
        /// Initialises the first overlay of the map.
        /// </summary>
        public GoogleMap(GMapControl gmap, Main parent) {
            if (gmap == null) throw new ArgumentNullException();
            if (parent == null) throw new ArgumentNullException();

            this.parent = parent;
            this.gmap = gmap;

            // overlay layer to add markers on the map
            GMapOverlay overlay = new GMapOverlay("first_layer");
            gmap.Overlays.Add(overlay);
        }

        /// <summary>
        /// Updates the map markers
        /// </summary>
        public void UpdateMapMarkers() {
            string query = "SELECT * FROM incident";
            List<string>[] data = parent.SQL.SelectIncident(query);
            if (data == null) return;

            // clear overlay so we dont get dupe markers
            gmap.Overlays[0].Markers.Clear();

            // create a new marker for each incident
            for (int i = 0; i < data[0].Count(); i++) {
                double lat = Double.Parse(data[4][i]);
                double lng = Double.Parse(data[5][i]);

                PointLatLng point = new PointLatLng(lat, lng);

                // create the tooltip
                string tooltip = data[0][i] + "; " + data[1][i] + "\n" + data[3][i];
                CreateMapMarker(point, tooltip);
            }
        }

        /// <summary>
        /// Creates the map marker and adds it to the map
        /// </summary>
        public void CreateMapMarker(PointLatLng point, string tooltip) {
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
            marker.ToolTipText = tooltip;

            gmap.Overlays[0].Markers.Add(marker);
            gmap.UpdateMarkerLocalPosition(marker);
        }

        /// <summary>
        /// Sets the map coordinates to center at that specific point.
        /// </summary>
        public void SetMapCoordinates(PointLatLng point) {
            gmap.Position = point;
        }

        /// <summary>
        /// Reset the map to the default location
        /// </summary>
        public void GoToDefaultLocation() {
            gmap.SetPositionByKeywords(DEFAULT_LOCATION);
            gmap.Zoom = 5;
        }
    }
}
