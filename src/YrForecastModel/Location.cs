using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace YrNoForecast
{
    ///<summary>The node has information about the official location name, type of location, country and time zone. 
    ///Timezone has the name of time zone and deviation per minute compared with UTC time. All times are local.
    ///</summary>
    [Serializable]
    public class Location
    {
        
        /// <summary>
        /// Location Name
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }

        /// <summary>
        /// Type of location
        /// </summary>
        [XmlElement("type")]
        public String Type { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [XmlElement("country")]
        public String Country { get; set; }

        /// <summary>
        /// Location timezone
        /// </summary>
        [XmlElement("timezone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Contains information about latitude/longitude, 
        /// altitude + information about what database yr.no has used to place the city.
        /// </summary>
        [XmlElement("location")]
        public GeoLocation GeoLocation { get; set; }

    }
}
