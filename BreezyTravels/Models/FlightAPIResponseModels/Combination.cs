using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class Combination
    {
        public ReturnLeg returnLeg { get; set; }
        public string validatingAirline { get; set; }
        public bool isOneWayCombinable { get; set; }
        public FirstLeg firstLeg { get; set; }
        public int comfortScore { get; set; }
        public double serviceFeeAmount { get; set; }
        public string bookingId { get; set; }
        public List<int> service_fee_in_preferred_currencies { get; set; }
        public string providerType { get; set; }
    }
}
