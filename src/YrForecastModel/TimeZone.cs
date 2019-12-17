using System.Xml.Serialization;
using System;

namespace YrNoForecast

{
    [Serializable]
    public class TimeZone
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        /// The difference in minutes from Coordinated Universal Time (UTC)
        /// </summary>
        [XmlAttribute("utcoffsetMinutes")]
        public UInt16 UtcOffsetMinutes { get; set; }
    }
}