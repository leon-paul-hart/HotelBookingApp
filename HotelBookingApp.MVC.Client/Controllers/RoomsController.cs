using HotelBookingApp.MVC.Client.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

namespace HotelBookingApp.MVC.Client.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        // GET: RoomsController
        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("HotelAPI");

            HttpResponseMessage? response = await httpClient.GetAsync("rooms");

            List<RoomViewModel> rooms = new List<RoomViewModel>();

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    string? validResponse = response.Content.ReadAsStringAsync().Result;

                    rooms = JsonConvert.DeserializeObject<List<RoomViewModel>>(validResponse);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());

                return View("Error", ex);
            }

            return View(rooms);
        }

        // GET: RoomsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
