using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace YrNoForecast
{
    /// <summary>
    /// Forecast
    /// </summary>
    [Serializable]
    public class Forecast
    {
        /// <summary>
        /// In this part you will find the normal forecast for the location. 
        /// </summary>
        [XmlArrayItem("time")]
        public List<Time> tabular { get; set; }
    }
}