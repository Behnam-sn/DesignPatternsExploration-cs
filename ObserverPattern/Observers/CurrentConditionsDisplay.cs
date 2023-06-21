namespace ObserverPattern;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        System.Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }

    public void Update()
    {
        temperature = weatherData.Temperature;
        humidity = weatherData.Humidity;
        Display();
    }
}
