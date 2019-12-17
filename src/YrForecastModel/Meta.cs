using System;
using System.Xml.Serialization;
namespace YrNoForecast
{

    /// <summary>
    /// The node has information about when the notification is valid and the approximate time for the next update. 
    /// </summary>
    [Serializable]


    public class Meta
    {

        [XmlElement("lastupdate")]
        public DateTime LastUpdate { get; set; }

        [XmlElement("nextupdate")]
        public DateTime NextUpdate { get; set; }
    }
}