using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    /// <summary>
    /// Date and time of the interval the forecast is valid for. 
    /// </summary>
    [Serializable]

    public class Time
    {
        #region Attributes

        /// <summary>
        /// Begin prediction period
        /// </summary>
        [XmlAttribute("from")]
        public DateTime From { get; set; }

        /// <summary>
        /// End prediction period
        /// </summary>
        [XmlAttribute("to")]
        public DateTime To { get; set; }


        /// <summary>
        /// Prediction period (0, 1, 2, 3)
        /// </summary>
        [XmlAttribute("period")]
        public UInt16 Period { get; set; }

        #endregion

        #region Elements

        /// <summary>
        /// Symbols are specified with number and name. Use the attribute "numberEx".
        /// </summary>
        [XmlElement("symbol")]
        public Symbol Symbol { get; set; }

        /// <summary>
        /// Rain forecast.
        /// </summary>
        [XmlElement("precipitation")]
        public Precipitation Precipitation { get; set; }

        /// <summary>
        /// Wind direction
        /// </summary>
        [XmlElement("windDirection")]
        public WindDirection WindDirection { get; set; }

        /// <summary>
        /// Wind Speed
        /// </summary>
        [XmlElement("windSpeed")]
        public WindSpeed WindSpeed { get; set; }

        /// <summary>
        /// Temperature
        /// </summary>
        [XmlElement("temperature")]
        public Temperature Temperature { get; set; }

        /// <summary>
        /// Pressure
        /// </summary>
        [XmlElement("pressure")]
        public Pressure Pressure { get; set; }
        #endregion
    }
}