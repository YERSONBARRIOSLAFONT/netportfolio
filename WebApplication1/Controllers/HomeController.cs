using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            var projects = GetProjects().Take(3).ToList();
            var model = new HomeIndexViewModel() { Projects = projects };
            return View(model);
        }

        private List<Project> GetProjects()
        {
            return new List<Project>() {
                new Project
            {
                ProjectTitle ="Amazon",
                Description = "E-commerce made on ASP.NET Core",
                Link = "https://amazon.com",
                ImageUrl = "/images/amazon.png",

            },
                new Project
            {
                ProjectTitle ="Reddit",
                Description = "E-commerce made on ASP.NET Core",
                Link = "https://amazon.com",
                ImageUrl = "/images/nyt.png",

            },
                new Project
            {
                ProjectTitle ="NewYork Times",
                Description = "E-commerce made on ASP.NET Core",
                Link = "https://amazon.com",
                ImageUrl = "/images/reddit.png",

            },
                new Project
            {
                ProjectTitle ="Facebook",
                Description = "E-commerce made on ASP.NET Core",
                Link = "https://amazon.com",
                ImageUrl = "/images/steam.png",

            },
            };
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
