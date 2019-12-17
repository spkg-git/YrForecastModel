using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    /// <summary>
    /// Air pressure in hectopascal at sea level.
    /// </summary>
    [Serializable]
    public class Pressure
    {
        /// <summary>
        /// Hpa
        /// </summary>
        [XmlAttribute("unit")]
        public String Unit { get; set; }

        /// <summary>
        /// Air pressure in hectopascal at sea level.
        /// </summary>
        [XmlAttribute("value")]
        public Double Value { get; set; }
    }
}