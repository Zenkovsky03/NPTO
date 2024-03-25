namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

<<<<<<< HEAD
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5551);
=======
        public int TemperatureF => 32 + (int)(TemperatureC / 0.55565);
>>>>>>> dev

        public string? Summary { get; set; }
    }
}
