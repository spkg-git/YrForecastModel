# Yr Forecast Model
This project is a .NET Core model of [Yr's weather forecasts in XML format](https://hjelp.yr.no/hc/en-us/articles/360001940793-Free-weather-data-service-from-Yr) for Serializing/Deserializing.

[![Actions Status](https://github.com/spkg-git/YrForecastModel/workflows/.NET%20Core/badge.svg)](https://github.com/spkg-git/YrForecastModel/YrForecastModel/actions?query=workflow%3A%22.NET+Core%22)

[Example of forecast.xml](https://github.com/spkg-git/YrForecastModel/blob/master/forecast.xml)

[XML specification of forecast.xml](https://hjelp.yr.no/hc/en-us/articles/360001940793-Free-weather-data-service-from-Yr)

## Installation

Either checkout this Github repository or install YrForecastModel via NuGet Package Manager. If you want to use NuGet just search for "YrForecastModel" or run the following command in the NuGet Package Manager console:
```bash
PM> Install-Package YrForecastModel -Version 2.0.0
```
## Code Example:

```csharp

//Deserialization
WeatherData weatherData = new WeatherData();
XmlSerializer ser = new XmlSerializer(typeof(WeatherData));
using StreamReader sr = new StreamReader("forecast.xml");
weatherData = (WeatherData) ser.Deserialize(sr);

//Serialization
using StreamWriter swr = new StreamWriter("forecast_test_result.xml");
ser.Serialize(swr, (WeatherData)weatherData);
```
