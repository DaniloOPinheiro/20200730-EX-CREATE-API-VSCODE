using System;

namespace _20200730_EX_CREATE_API_VSCODE.Models
{
    public class WeatherForecastModel
    {
        public Autor Autor { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }
    }

    public class Autor
    {
       string name = "Danilo O. Pinheiro";
       string linkedin = "https://www.linkedin.com/in/danilo-o-pinheiro-8127ab176/";
       string github = "https://github.com/DaniloOPinheiro";
    }

}