using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class Arrival
    {
        public Airport airport { get; set; }
        public DateTime dateTime { get; set; }
        public City city { get; set; }
    }
}
