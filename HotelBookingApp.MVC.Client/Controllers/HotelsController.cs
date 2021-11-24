using HotelBookingApp.MVC.Client.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System.Net.Mime;
using System.Text;

namespace HotelBookingApp.MVC.Client.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HotelsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

            HttpResponseMessage? response = await httpClient.GetAsync("hotels");

            List<HotelViewModel> hotels = new List<HotelViewModel>();

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string? validResponse = response.Content.ReadAsStringAsync().Result;

                    hotels = JsonConvert.DeserializeObject<List<HotelViewModel>>(validResponse);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

                return View("Error", ex);
            }

            return View(hotels);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int HotelID)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

            HttpResponseMessage? response = await httpClient.GetAsync($"hotels/{HotelID}");

            HotelViewModel hotel = new HotelViewModel();

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string? validResponse = response.Content.ReadAsStringAsync().Result;

                    hotel = JsonConvert.DeserializeObject<HotelViewModel>(validResponse);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

                return View("Error", ex);
            }

            return View(hotel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelName, HotelPostcode, HotelStreetAddress, Rooms")] HotelViewModel model)
        {
            if (ModelState.IsValid)
            {
                HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

                StringContent content = new(JsonConvert.SerializeObject(model), Encoding.UTF8, MediaTypeNames.Application.Json);

                Task<HttpResponseMessage>? response = httpClient.PostAsJsonAsync("hotels", content);

                response.Wait();

                if (response.IsCompletedSuccessfully)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        //[HttpGet]
        //public async Task<IActionResult> Edit(int HotelID)
        //{
        //    HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

        //    HttpResponseMessage? response = await httpClient.GetAsync($"hotels/{HotelID}");

        //    HotelViewModel hotel = new HotelViewModel();

        //    try
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string? validResponse = response.Content.ReadAsStringAsync().Result;

        //            hotel = JsonConvert.DeserializeObject<HotelViewModel>(validResponse);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message.ToString());

        //        return View("Error", ex);
        //    }

        //    return View(hotel);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(HotelViewModel model)
        //{
        //    HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

        //    HttpResponseMessage? response = await httpClient.GetAsync($"hotels/{HotelID}");

        //    HotelViewModel hotel = new HotelViewModel();

        //    try
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string? validResponse = response.Content.ReadAsStringAsync().Result;

        //            hotel = JsonConvert.DeserializeObject<HotelViewModel>(validResponse);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message.ToString());

        //        return View("Error", ex);
        //    }

        //    return View(hotel);
        //}
    }
}

