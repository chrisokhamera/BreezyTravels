using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class PriceChargedByProvider
    {
        public double ticketing_fee { get; set; }
        public string currency { get; set; }
        public double total_fare { get; set; }
    }
}
