namespace servicetwo;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int SpeedKMH { get; set; }

    public int SpeedMH =>  (int)(SpeedKMH / 1.6);

    public string? Auto { get; set; }
}