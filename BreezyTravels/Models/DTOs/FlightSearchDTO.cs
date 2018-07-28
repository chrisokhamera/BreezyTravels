using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreezyTravels.Models.DTOs
{
    public class FlightSearchDTO
    {
        public string From { get; set; }
        public string To { get; set; }
        public bool IsOneWay { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
