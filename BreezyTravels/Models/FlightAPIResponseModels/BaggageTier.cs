using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class BaggageTier
    {
        public List<int> max_weights { get; set; }
        public int tier { get; set; }
        public Total total { get; set; }
        public Price price { get; set; }
    }
}
