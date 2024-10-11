using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace PersonsInfoV2Api.BussinessLogic
{
    public class CarrierLookupService
    {
        private readonly string _apiKey = "YOUR_API_KEY";
        private readonly HttpClient _httpClient;

        public CarrierLookupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCarrierAsync(string phoneNumber)
        {
            var url = $"https://apilayer.com/api/validate?access_key={_apiKey}&number={phoneNumber}";
            var response = await _httpClient.GetStringAsync(url);
            dynamic result = JsonConvert.DeserializeObject(response);
            return result.carrier;
        }
    }
}
