using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;
using System.Collections.Generic;

namespace PlacesIveBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Places> allPlaces = Places.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string description)
        {
            Places myList = new Places(description);
            return RedirectToAction("Index");
        }
    }
}