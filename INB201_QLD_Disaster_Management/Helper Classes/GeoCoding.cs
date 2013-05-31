using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GMap.NET;
using GMap.NET.MapProviders;

namespace INB201_QLD_Disaster_Management.Helper_Classes {
    /// <summary>
    /// This class uses geocoding to locate the Latitude and Longitude of an address.
    /// </summary>
    public class GeoCoding {
        /// <summary>
        /// Determines if the address for geo-coding is valid.
        /// </summary>
        /// <returns>If pos has value</returns>
        public static bool IsAddressValid(string address) {
            GeoCoderStatusCode s = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(address, out s);

            return pos.HasValue;
        }

        /// <summary>
        /// Returns the latitude and longitude of an address.
        /// </summary>
        /// <returns>PointLatLng of the address</returns>
        public static PointLatLng GetPoint(string address) {
            GeoCoderStatusCode s = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(address, out s);

            return pos.Value;
        }
    }
}
