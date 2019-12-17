using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    /// <summary>
    /// Wind speed in meters per second (m/s) with associated Beaufort name.
    /// </summary>
    [Serializable]
    public class WindSpeed
    {
        /// <summary>
        /// Wind speed in meters per second (m/s)
        /// </summary>
        [XmlAttribute("mps")]
        public Double Mps { get; set; }

        /// <summary>
        /// Wind speed with associated Beaufort name
        /// </summary>
        [XmlAttribute("name")]
        public String Name { get; set; }
    }
}