using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "YOUR_API_KEY";
        private const string ApiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetWeatherButton_Click_Click(object sender, EventArgs e)
        {
            string city = CityTextBox.Text;

            WeatherData weatherData = WeatherService.GetWeather(city);

            if (weatherData != null)
            {
                string temperature = $"{weatherData.Main.Temp}°C";
                string description = weatherData.Weather[0].Description;

                TemperatureLabel.Text = temperature;
                DescriptionLabel.Text = description;
            }
            else
            {
                MessageBox.Show("Failed to retrieve weather data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class WeatherData
    {
        public string Name { get; set; }
        public MainData Main { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class MainData
    {
        public float Temp { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }

    public class WeatherService
    {
        public static WeatherData GetWeather(string city)
        {
            string url = string.Format(ApiUrl, city, ApiKey);

            using (WebClient client = new WebClient())
            {
                try
                {
                    string json = client.DownloadString(url);
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                    return weatherData;
                }
                catch (WebException)
                {
                    return null;
                }
            }
        }
    }
}

