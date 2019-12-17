using System;
using System.Xml.Serialization;
namespace YrNoForecast
{

    /// <summary>
    /// Wind direction in degrees, with a code and text for wind direction. 
    /// The codes are in English, wind direction is given in the language chosen.
    /// </summary>
    [Serializable]
    public class WindDirection
    {
        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        [XmlAttribute("deg")]
        public Double Deg { get; set; }

        /// <summary>
        /// Wind direction code
        /// </summary>
        [XmlAttribute("code")]
        public String Code { get; set; }

        /// <summary>
        /// Wind direction text
        /// </summary>
        [XmlAttribute("name")]
        public String Name { get; set; }
    }
}