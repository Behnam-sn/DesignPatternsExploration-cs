using ObserverPattern;

var weatherData = new WeatherData();

var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);