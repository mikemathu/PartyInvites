using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //Action Method
        public string Index()
        {
            return "Hello Mike";
        }
    }
}