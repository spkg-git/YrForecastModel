using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Xml.Serialization;
using YrForecastModel;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLocation()
        {
            WeatherData result = new WeatherData(); ;
            XmlSerializer ser = new XmlSerializer(typeof(WeatherData));
            using (StreamReader sr = new StreamReader("forecast.xml"))
            {
                try
                {
                    result = (WeatherData)ser.Deserialize(sr);
                    Assert.IsNotNull(result.Location);
                    Assert.IsNotNull(result.Location);
                    Assert.IsNotNull(result.Credit);
                    Assert.IsNotNull(result.links);
                    Assert.AreEqual(5, result.links.Count);
                    Assert.IsNotNull(result.Meta);
                    Assert.IsNotNull(result.Sun);
                }
                catch (Exception ex)
                {
                    Assert.Fail(ex.Message);
                }

            }

            using (StreamWriter sr = new StreamWriter("forecast_test_result.xml"))
            {
                try
                {
                    ser.Serialize(sr, (WeatherData)result);

                }
                catch (Exception ex)
                {
                    Assert.Fail(ex.Message);
                }

            }

        }
    }
}
