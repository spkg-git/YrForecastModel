# YrForecastModel
This project is a Net.Core model of [Yr's weather forecasts in XML format](https://hjelp.yr.no/hc/en-us/articles/360001940793-Free-weather-data-service-from-Yr)
for Serializing/Deserializing.

## Example
```csharp

//Deserialization
WeatherData weatherData = new WeatherData();
XmlSerializer ser = new XmlSerializer(typeof(WeatherData));
using StreamReader sr = new StreamReader("forecast.xml");
weatherData = (WeatherData) ser.Deserialize(sr);

//Serialization
using StreamWriter sr = new StreamWriter("forecast_test_result.xml");
ser.Serialize(sr, (WeatherData)weatherData);
```
