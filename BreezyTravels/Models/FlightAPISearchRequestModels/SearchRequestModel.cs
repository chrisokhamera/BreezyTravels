using Newtonsoft.Json;
using System.Collections.Generic;

namespace BreezyTravels.Models.FlightAPISearchRequestModels
{
    public class SearchRequestModel
    {
        [JsonProperty("fromLocation")]
        public string FromLocation { get; set; }

        [JsonProperty("toLocation")]
        public string ToLocation { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("returnDate")]
        public string ReturnDate { get; set; }

        [JsonProperty("persons")]
        public List<Person> Persons { get; set; }

        [JsonProperty("userData")]
        public UserData UserData { get; set; }
    }
}
