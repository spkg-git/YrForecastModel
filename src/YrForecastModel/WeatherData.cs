using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace YrNoForecast
{
    [Serializable]
    [XmlRoot("weatherdata")]
    public class WeatherData
    {
        /// <summary>
        /// Information about the official location name, type of location, country and time zone.
        /// </summary>
        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("credit")]
        public Credit Credit { get; set; }

        /// <summary>
        /// Links to the URLs
        /// </summary>
        [XmlArrayItem("link")]
        public List<Link> links { get; set; }

        /// <summary>
        /// Information about when the notification is valid and the approximate time for the next update.
        /// </summary>
        [XmlElement("meta")]
        public Meta Meta { get; set; }

        [XmlElement("sun")]
        public Sun Sun { get; set; }

        /// <summary>
        /// Forecast
        /// </summary>
        [XmlElement("forecast")]
        public Forecast Forecast { get; set; }
    }
}
