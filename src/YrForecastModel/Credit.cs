using System;
using System.Xml.Serialization;


namespace YrNoForecast
{

    [Serializable]

    ///<summary>
    ///In order to use the free weather data from yr no, you HAVE to display 
    /// the following text clearly visible on your web page.The text should be a
    /// link to the specified URL.
    ///</summary>
    public class Credit
    {
        [XmlElement("link")]
        public CreditLink Link { get; set; }
    }
}