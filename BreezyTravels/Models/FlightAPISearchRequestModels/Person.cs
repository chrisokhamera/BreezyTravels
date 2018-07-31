using Newtonsoft.Json;

namespace BreezyTravels.Models.FlightAPISearchRequestModels
{
    public class Person
    {
        [JsonProperty("passengerType")]
        public string PassengerType { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
