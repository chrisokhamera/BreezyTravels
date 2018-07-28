using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class FlightSegment
    {
        public string flightNumber { get; set; }
        public string marketingAirlineName { get; set; }
        public string operatingAirlineName { get; set; }
        public string operatingAirline { get; set; }
        public int availableSeats { get; set; }
        public Arrival arrival { get; set; }
        public string aircraft { get; set; }
        public string @class { get; set; }
        public Departure departure { get; set; }
        public string marketingAirline { get; set; }
        public string default_fare_family { get; set; }
        public string cabin { get; set; }
    }
}
