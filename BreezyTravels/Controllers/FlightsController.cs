using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreezyTravels.Models.DTOs;
using BreezyTravels.Models.FlightAPISearchRequestModels;
using Microsoft.AspNetCore.Mvc;

namespace BreezyTravels.Controllers
{
    public class FlightsController : Controller
    {
        [HttpPost]
        public IActionResult Search(FlightSearchDTO model)
        {
            if (ModelState.IsValid)
            {
                SearchRequestModel rm = new SearchRequestModel();

                rm.departureDate = model.DepartureDate.ToShortDateString();
                rm.returnDate = model.ReturnDate.ToShortDateString();

                //send api request

                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View();
        }
    }
}