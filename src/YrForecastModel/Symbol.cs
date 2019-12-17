using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    /// <summary>
    /// Symbols are specified with number and name. Use the attribute "numberEx". 
    /// This is new from May 27, 2014 and gives a more detailed precipitation symbol than the "number" attribute.
    /// </summary>
    /// <seealso cref="https://hjelp.yr.no/hc/en-us/articles/360009342913-XML-specification-of-forecast-xml"/>
   
   
    [Serializable]
    public class Symbol
    {
        /// <summary>
        /// Symbol number
        /// </summary>
        [XmlAttribute("number")]
        public String Number { get; set; }

        /// <summary>
        /// Symbol external number
        /// </summary>
        [XmlAttribute("numberEx")]
        public String NumberEx { get; set; }

        /// <summary>
        /// Symbol name
        /// </summary>
        [XmlAttribute("name")]
        public String Name { get; set; }

        /// <summary>
        /// Moon phases in the symbol
        /// </summary>
        [XmlAttribute("var")]
        public String Var { get; set; }
    }
}