using Api.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using WepApi.WindowsClient;
namespace WebApi.WindowsClient
{
	public class Program
	{
		static void Main(string[] args)
		{
			//GetIp();
			System.Threading.Thread.Sleep(5000);
			var forecast = GetWeatherForecastAsync(new Zone
			{
				City = "Acapulco",
				Date = new DateTime(2024, 02, 06)
			}).Result;

			Console.WriteLine("Ciudad: " + forecast.Zone.City);
			Console.WriteLine("Fecha: " + forecast.Zone.Date);

			foreach (var item in forecast.WeatherForecast)
			{
				Console.WriteLine();
				Console.WriteLine("Summary: " + item.Summary);
				Console.WriteLine("Temperature C: " + item.TemperatureC);
				Console.WriteLine("Temperature F: " + item.TemperatureF);

				Console.ReadKey();
			}
		}

		private static async Task<ZoneWeatherForecast> GetWeatherForecastAsync(Zone zone)
		{
			string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(zone);
			HttpClient client = new HttpClient();


			HttpResponseMessage response = await client.PostAsync("https://localhost:7144/weatherforecast/byzone", new StringContent(jsonContent, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();

			string responseBody = await response.Content.ReadAsStringAsync();
			ZoneWeatherForecast forecast = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeatherForecast>(responseBody);
			//var info = await GetIpInfo(ip.Ip);

			//Console.WriteLine("Country: " + info.Country);
			//Console.WriteLine("City: " + info.City);
			//Console.WriteLine("Time Zone: " + info.TimeZone);
			return forecast;
		}

		private static async Task<IpAddress> GetIp()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");
			response.EnsureSuccessStatusCode();

			string responseBody = await response.Content.ReadAsStringAsync();

			IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);
			Console.WriteLine("My current Ip Address is: " + ip.Ip);

			var info = await GetIpInfo(ip.Ip);

			Console.WriteLine("Country: " + info.Country);
			Console.WriteLine("City: " + info.City);
			Console.WriteLine("Time Zone: " + info.TimeZone);
			return ip;
		}

		private static async Task<IpInfo> GetIpInfo(string IpAddress)
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{IpAddress}/geo");
			response.EnsureSuccessStatusCode();

			string responseBody = await response.Content.ReadAsStringAsync();
			IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);
			//Console.WriteLine("My current Ip Address is: " + info.Ip);
			return info;
		}
	}
}
