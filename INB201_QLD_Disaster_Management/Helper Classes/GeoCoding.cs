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
        /// Uses geocoding to locate the lat and lng of an address.
        /// Returns a pointLatLng
        /// </summary>
        public static PointLatLng GetPoint(string address)
        {
            //use geocoding to find the Lat and Lng
            GeoCoderStatusCode s = GeoCoderStatusCode.Unknow;
            PointLatLng? pos = GMapProviders.GoogleMap.GetPoint(address, out s);

            return pos.Value;
        }
    }
}
