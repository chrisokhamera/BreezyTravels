using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BreezyTravels.Models.DTOs;
using BreezyTravels.Models.FlightAPIResponseModels;
using BreezyTravels.Models.FlightAPISearchRequestModels;
using BreezyTravels.PageViewModels;
using BreezyTravels.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BreezyTravels.Controllers
{
    [Authorize]
    public class FlightsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Search(FlightSearchDTO model)
        {

            FlightSearchResponse availableFlights = null;
            SearchPageViewModel vm = null;
            if (ModelState.IsValid)
            {

                //create search request object

                SearchRequestModel rm = new SearchRequestModel
                {
                    FromLocation = model.From,
                    ToLocation = model.To,
                    DepartureDate = model.DepartureDate.ToShortDateString(),


                    Persons = new List<Person>
                    {
                        new Person
                        {
                            PassengerType = "ADT",
                            Quantity = 1
                        }
                    },

                    UserData = new UserData
                    {
                        Ip = "89.134.155.92",
                        BrowserAgent = "Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:46.0) Gecko/20100101 Firefox/46.0"
                    }
                };

                try
                {
                    rm.ReturnDate = model.ReturnDate.Value.ToShortDateString();
                }
                catch (Exception)
                {

                    rm.ReturnDate = "";
                }

                string rmString = JsonConvert.SerializeObject(rm);
                StringContent searchRequest = new StringContent(rmString, Encoding.UTF8, "application/json");

                try
                {

                    string responseString = string.Empty;

                    using (var client = HttpService.GetHttpClient())
                    {

                        while (responseString == string.Empty)
                        {
                            Thread.Sleep(3000);
                            var result = await client.PostAsync("https://dev.allmyles.com/v2.0/flights", searchRequest);
                            responseString = await result.Content.ReadAsStringAsync();
                        }
                       
                    }

                    availableFlights = JsonConvert.DeserializeObject<FlightSearchResponse>(responseString);
                }
                catch (Exception e)
                {

                    Debug.WriteLine(e.Message);
                }
            }



            if (availableFlights != null)
            {
                vm = new SearchPageViewModel();
                vm.FirstLegs = new List<FlightSegment>();
                vm.ReturnLegs = new List<FlightSegment>();

                foreach (var resultSet in availableFlights.flightResultSet)
                {
                    foreach (var combination in resultSet.combinations)
                    {
                        foreach (var flighSegments in combination.firstLeg.flightSegments)
                        {
                            vm.FirstLegs.Add(flighSegments);
                        }

                        foreach (var flighSegments in combination.returnLeg.flightSegments)
                        {
                            vm.ReturnLegs.Add(flighSegments);
                        }

                    }
                }
            }

            return View(vm);
        }
    }
}