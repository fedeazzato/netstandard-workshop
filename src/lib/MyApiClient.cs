using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyApi
{
    public class MyApiClient
    {
        public string ApiUrl => "http://ipinfo.io";
        
        //public string ApiKey {get; set;} = "MY-API-KEY";
        
        public async Task<IpInfoResponse> GetData(string ipAddress)
        {
            var result = string.Empty;
            
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                var response = await client.GetAsync(ApiUrl + '/' + ipAddress);
                if(response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsStringAsync();
            }

            return JsonConvert.DeserializeObject<IpInfoResponse>(result);
        }
    }
}
