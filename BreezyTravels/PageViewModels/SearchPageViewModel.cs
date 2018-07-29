using BreezyTravels.Models.FlightAPIResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.PageViewModels
{
    public class SearchPageViewModel
    {
        public IEnumerable<IEnumerable<List<FlightSegment>>> FirstLeg { get; set; }

        public IEnumerable<IEnumerable<List<FlightSegment>>> ReturnLeg { get; set; }

    }
}
