using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BreezyTravels.Models.DTOs;
using BreezyTravels.Models.FlightAPISearchRequestModels;
using BreezyTravels.Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BreezyTravels.Controllers
{
    public class FlightsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Search(FlightSearchDTO model)
        {
            if (ModelState.IsValid)
            {

                //create search request object

                SearchRequestModel rm = new SearchRequestModel
                {
                    FromLocation = model.From,
                    ToLocation = model.To,
                    DepartureDate = model.DepartureDate.ToShortDateString(),
                    ReturnDate = (model.IsOneWay) ? model.ReturnDate.ToShortDateString() : string.Empty,

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

                string rmString = JsonConvert.SerializeObject(rm);
                StringContent searchRequest = new StringContent(rmString, Encoding.UTF8, "application/json");

                try
                {
                    using (var client = HttpService.GetHttpClient())
                    {
                        var result = await client.PostAsync("https://dev.allmyles.com/v2.0/flights", searchRequest);
                        var responstring = result.Content.ReadAsStringAsync();
                    }
                }
                catch (Exception e)
                {

                    Debug.WriteLine(e.Message);
                }
            }
            return View();
        }
    }
}