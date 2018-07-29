using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class PassengerFare
    {
        public double fare { get; set; }
        public double tax { get; set; }
        public List<object> ticketDesignators { get; set; }
        public int quantity { get; set; }
        public List<decimal> fare_in_preferred_currencies { get; set; }
        public string type { get; set; }
    }
}
