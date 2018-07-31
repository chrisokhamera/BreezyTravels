using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class FlightResultSet
    {
        public List<BaggageTier> BaggageTiers { get; set; }
        public double ticketing_fee { get; set; }
        public List<decimal> total_fare_in_preferred_currencies { get; set; }
        public List<Combination> combinations { get; set; }
        public PriceChargedByProvider price_charged_by_provider { get; set; }
        public double total_fare { get; set; }
        public string currency { get; set; }
        public double extra_cost { get; set; }
        public List<decimal> ticketing_fee_in_preferred_currencies { get; set; }
        public object lastTicketingDate { get; set; }
        public List<Breakdown> breakdown { get; set; }
    }
}
