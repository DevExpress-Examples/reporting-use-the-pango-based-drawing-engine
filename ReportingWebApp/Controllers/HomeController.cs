using Microsoft.AspNetCore.Mvc;

namespace ReportingWebApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    
        public IActionResult Designer() {
            return View();
        }

        public IActionResult Viewer() {
            return View();
        }
    }
}
