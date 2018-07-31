using Newtonsoft.Json;

namespace BreezyTravels.Models.FlightAPISearchRequestModels
{
    public class UserData
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("browser_agent")]
        public string BrowserAgent { get; set; }
    }
}
