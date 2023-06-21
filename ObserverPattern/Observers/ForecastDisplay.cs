namespace ObserverPattern;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float currentPressure = 29.92f;
    private float lastPressure;
    private WeatherData weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        System.Console.WriteLine("");
    }

    public void Update()
    {
        lastPressure = currentPressure;
        currentPressure = weatherData.Pressure;
        Display();
    }
}