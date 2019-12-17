using System.Xml.Serialization;
using System;

namespace YrForecastModel

{
    [Serializable]
    public class TimeZone
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("id")]
        public String Id { get; set; }

        /// <summary>
        /// The difference in minutes from Coordinated Universal Time (UTC)
        /// </summary>
        [XmlAttribute("utcoffsetMinutes")]
        public Int16 UtcOffsetMinutes { get; set; }
    }
}