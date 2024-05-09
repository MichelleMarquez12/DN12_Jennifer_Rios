using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApi.Cors.Example;

namespace WebCors.Example.Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<WeatherForecast> WeatherForecasts { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            System.Threading.Thread.Sleep(5000);

            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync("https://localhost:44348/WeatherForecast");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WeatherForecast>>(content);

                WeatherForecasts = list;
            }
        }
    }
}
