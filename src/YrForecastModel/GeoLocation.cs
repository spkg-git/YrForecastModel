using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    /// <summary>
    /// /// <summary>
    /// Contains information about latitude/longitude, 
    /// altitude + information about what database yr.no has used to place the city.
    /// There are two main databases that lie behind yr.no: SSR from the Norwegian map and Geonames (geonames.org).
    /// </summary>
    /// </summary>
    [Serializable]
    public class GeoLocation
    {
        /// <summary>
        /// Altitude оf location in meters
        /// </summary>
        [XmlAttribute("altitude")]
        public Int16 Altitude { get; set; }

        /// <summary>
        /// Latitude of location in meters
        /// </summary>
        [XmlAttribute("latitude")]
        public Double Latitude { get; set; }

        /// <summary>
        /// Longitude of location in meters
        /// </summary>
        [XmlAttribute("longitude")]
        public Double Longitude { get; set; }

        /// <summary>
        /// Geobase using
        /// </summary>
        [XmlAttribute("geobase")]
        public String Geobase { get; set; }

        /// <summary>
        /// Geobase ID
        /// </summary>
        [XmlAttribute("geobaseid")]
        public UInt32 Geobaseid { get; set; }
    }
}