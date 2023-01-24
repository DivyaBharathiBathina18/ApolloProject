using Microsoft.AspNetCore.Mvc;

namespace ApolloProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
