using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //Action Method
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Salamu = hour < 12 ? "Good Morming" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //TODO: store response from guest
            return View();
        }
    }
}