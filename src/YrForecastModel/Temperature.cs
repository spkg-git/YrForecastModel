using System;
    using System.Xml.Serialization;
namespace YrForecastModel
{
    /// <summary>
    /// Temperature forecast in Celsius.
    /// </summary>
    [Serializable]
    public class Temperature
    {
        /// <summary>
        /// Celsius
        /// </summary>
        [XmlAttribute("unit")]
        public String Unit { get; set; }

        /// <summary>
        /// Temperature forecast in Celsius. 
        /// </summary>
        [XmlAttribute("value")]
        public Double Value { get; set; }
    }
}