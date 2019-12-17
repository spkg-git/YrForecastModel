using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    
    /// <summary>
    /// According to Yr.no guidelines, you MUST create the link to the URL as specified in link id="overview" ..
    /// The other links that are specified in Links, you can choose whether to link or not.
    ///</summary>
 
    [Serializable]

    public class Link
    {
        /// <summary>
        /// Link Type
        /// </summary>
        [XmlAttribute("id")]
        public String Id { get; set; }

        /// <summary>
        /// Link to web page of city 
        /// </summary>
        [XmlAttribute("url")]
        public String Url { get; set; }
    }
}