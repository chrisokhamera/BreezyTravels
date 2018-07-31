using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class Departure
    {
        public Airport2 airport { get; set; }
        public DateTime dateTime { get; set; }
        public City2 city { get; set; }
    }
}
