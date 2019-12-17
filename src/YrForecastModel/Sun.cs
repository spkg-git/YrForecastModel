using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    [Serializable]
    /// <summary>
    /// Sunset and sunrise class about
    /// </summary>
    public class Sun
    {
        /// <summary>
        /// Sunrise
        /// </summary>
        [XmlAttribute("rise")]
        public DateTime Rise { get; set; }

        /// <summary>
        /// Sunset
        /// </summary>
        [XmlAttribute("set")]
        public DateTime Set { get; set; }
    }
}