using BreezyTravels.Models.FlightAPIResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.PageViewModels
{
    public class SearchPageViewModel
    {
        public List<Combination> Combinations { get; set; }

        public List<FlightSegment> FirstLegs { get; set; }

        public List<FlightSegment> ReturnLegs { get; set; }

    }
}
