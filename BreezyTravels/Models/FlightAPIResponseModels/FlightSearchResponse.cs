using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class FlightSearchResponse
    {
        public List<FlightResultSet> flightResultSet { get; set; }
    }
}
