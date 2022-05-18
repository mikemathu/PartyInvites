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
            /*This provide data for the view by assigning a value to the ViewBag.Greeting property. The Greeting
            property didn’t exist until the moment I assigned the value—this allows me to pass data from the controller
            to the view in a free and fluid manner, without having to define classes ahead of time.*/
            int hour = DateTime.Now.Hour;
            ViewBag.Salamu = hour < 12 ? "Good Morming" : "Good Afternoon";
            ViewBag.Subject = "Work Harder";

            return View("MyView");
        }

        /*The RsvpForm action method calls the View method without an argument, which tells MVC to render 
          the default view associated with the action method, which is a view with the same name as the action 
           method, in this case, RsvpForm.cshtml*/

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