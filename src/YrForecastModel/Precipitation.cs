using System;
using System.Xml.Serialization;
namespace YrForecastModel
{
    /// <summary>
    /// Rain forecast.
    /// </summary>
    [Serializable]
    public class Precipitation
    {
        /// <summary>
        /// Rain forecast in millimeters. If you want to show the rainfall directly, you should round off and not show decimals.
        /// </summary>
        [XmlAttribute("value")]
        public Double Value { get; set; }
    }
}