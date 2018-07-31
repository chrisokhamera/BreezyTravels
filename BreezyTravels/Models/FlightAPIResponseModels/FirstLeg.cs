using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.FlightAPIResponseModels
{
    public class FirstLeg
    {
        public string elapsedTime { get; set; }
        public List<FlightSegment> flightSegments { get; set; }
    }
}
