using Microsoft.AspNetCore.Mvc;

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
    }
}