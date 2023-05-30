using hww4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hww4.Controllers
{
    public class HomeController : Controller
    {
        int va;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult opr(int In1, char OP, int In2)
        {
            char op = OP;
            ViewData["In1"] = In1;
            ViewData["In2"] = In2;
            switch (OP)
            {
                case '+':
                    va = In1 + In2;
                    break;

                case '-':
                    va = In1 - In2;
                    break;

                case '*':
                    va = In1 * In2;
                    break;

                case '/':
                    va = In1 / In2;
                    break;
            }
            ViewData["value"] = va;
            ViewData["Opx"] = op;
            return View("Index");
        }

        
    }
}