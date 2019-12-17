using System;
using System.Xml.Serialization;

namespace YrNoForecast
{
    [Serializable]
    public class CreditLink
    {
        /// <summary>
        /// Text to display on web page
        /// </summary>
        [XmlAttribute("text")]
        public String Text { get; set; }

        /// <summary>
        /// Link to the city page on Yr.no site.
        /// </summary>
        [XmlAttribute("url")]
        public String Url { get; set; }
    }
}