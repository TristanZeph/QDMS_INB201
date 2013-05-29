using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GMap.NET;
using GMap.NET.MapProviders;

namespace INB201_QLD_Disaster_Management.Helper_Classes
{
    public class GeoCoding
    {
        /// <summary>
        /// Determines if the address for geo-coding is valid.
        /// Return true, if the address is valid.
        /// Otherwise, return false.
        /// </summary>
        public static bool IsAddressValid(string address)
        {
            //use geocoding to find the Lat and Lng
            GeoCoderStatusCode s = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(address, out s);

            return pos.HasValue;
        }

        /// <summary>
        /// Returns the latitude and longitude of an address.
        /// </summary>
        public static PointLatLng GetPoint(string address) {
            //use geocoding to find the Lat and Lng
            GeoCoderStatusCode s = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(address, out s);

            return pos.Value;
        }
    }
}
