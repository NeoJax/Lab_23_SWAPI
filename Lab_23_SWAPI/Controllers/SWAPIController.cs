using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab_23_SWAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab_23_SWAPI.Controllers
{
    public class SWAPIController : Controller
    {
        private readonly HttpClient _client;

        public SWAPIController(IHttpClientFactory client)
        {
            _client = client.CreateClient();
            _client.BaseAddress = new Uri("https://swapi.co/api/");
        }

        public async Task<IActionResult> DisplayPeople()
        {
            var response = await _client.GetAsync($"people/");
            var people = await response.Content.ReadAsAsync<PeopleRoot>();
            return View(people);
        }

        public async Task<IActionResult> DisplayPlanets()
        {
            var response = await _client.GetAsync($"planets/");
            var planets = await response.Content.ReadAsAsync<PlanetsRoot>();
            return View(planets);
        }


        public async Task<IActionResult> GetPersonById(int id)
        {
            var response = await _client.GetAsync($"people/{id}");
            var person = await response.Content.ReadAsAsync<Person>();
            return View(person);
        }

        public async Task<IActionResult> GetPlanetById(int id)
        {
            var response = await _client.GetAsync($"planets/{id}");
            var planet = await response.Content.ReadAsAsync<Planet>();
            return View(planet);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
