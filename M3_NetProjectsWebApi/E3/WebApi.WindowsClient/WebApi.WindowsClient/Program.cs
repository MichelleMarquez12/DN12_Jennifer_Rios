using System;
using System.Net;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
namespace WebApi.WindowsClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            GetIp();

            Console.ReadKey();

        }


        //Muestra solo la ip del dispositivo
        public static async Task<IpAddress> GetIp()
        {
            //INSTANCIA A LA CLASE HTTP
            HttpClient client = new HttpClient();

            //Invocación al método
            HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);

            Console.WriteLine("My current ip address is: " + ip.Ip);

            var info = await GetIpInfo(ip.Ip);

            Console.WriteLine("City: " + info.City);
            Console.WriteLine("Country: " + info.Country);
            Console.WriteLine("Timezone: " + info.Timezone);

            return ip;
        }

        //Muestra ip y informacion del dispositivo
        public static async Task<IpInfo> GetIpInfo(string IpAddress)
        {
            //INSTANCIA A LA CLASE HTTP
            HttpClient client = new HttpClient();

            //Invocación al método
            HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{IpAddress}/geo");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            IpInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);

            return info;
        }

    }
}