using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly string API_KEY = "66d95ea03fc6d2bbfcee01c2ef28139c"; 

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string weather = await GetWeatherAsync(city);
            lblResult.Text = weather;
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={API_KEY}&units=metric&lang=ru";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject data = JObject.Parse(responseBody);

                    if (data["cod"].ToString() != "200")
                    {
                        return $"������: {data["message"]}";
                    }

                    string description = data["weather"][0]["description"].ToString();
                    string temperature = data["main"]["temp"].ToString();
                    string feelsLike = data["main"]["feels_like"].ToString();
                    string humidity = data["main"]["humidity"].ToString();
                    string pressure = data["main"]["pressure"].ToString();
                    string windSpeed = data["wind"]["speed"].ToString();

                    return $"������: {description}\n" +
                           $"�����������: {temperature}�C\n" +
                           $"��������� ���: {feelsLike}�C\n" +
                           $"���������: {humidity}%\n" +
                           $"��������: {pressure} hPa\n" +
                           $"�������� �����: {windSpeed} �/�";
                }
            }
            catch (Exception ex)
            {
                return $"�� ������� �������� ������: {ex.Message}";
            }
        }
    }
}
