using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31A2_Ronan_Justine_Ga.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_BSIT31A2_Ronan_Justine_Ga.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<IDescribable> customers = new List<IDescribable>
        {
            new Customer { Name = "Ronan", Email = "ronanjustinega44@gmail.com" },
            new PremiumCustomer { Name = "Justine", Email = "10derjusi@gmail.com", LoyaltyPoints = 120 }
        };

            return View(customers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
