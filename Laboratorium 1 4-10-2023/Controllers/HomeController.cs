using Laboratorium_1_4_10_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Laboratorium_1_4_10_2023.Controllers
{
    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author, int? id)
        {
         //   string author = Request.Query["author"];
            ViewBag.Author = author + " " + id;
            
  
            return View();
        }

        public IActionResult CalcFirst(string op, int x, int z)
        {
            int result;
           switch (op)
           {
                case "add":
                    {
                        result = x + z;
                        break;
                    }
                case "sub":
                    {
                        result = x - z;
                        break;
                    }
                case "mul":
                    {
                        result = x * z;
                        break;
                    }
                case "div":
                    {
                        result = x / z;
                        break;
                    }
                default: 
                    { 
                        result = 0;
                        break; 
                    }

           }
          ViewBag.Result = result;
           return View();
        }

        public IActionResult Calc([FromQuery(Name ="operator")]Operators? op, double? x, double? y)
        {
                 string result;
            if (op == null || x == null || y == null)
            {
                return View("ERROR");
            }
            else
            {
                switch (op)
                {
                    case Operators.ADD:
                        {
                            result = (x + y).ToString();
                            break;
                        }
                    case Operators.SUB:
                        {
                            result = (x - y).ToString();
                            break;
                        }
                    case Operators.MUL:
                        {
                            result = (x * y).ToString();
                            break;
                        }
                    case Operators.DIV:
                        {
                            result = (x / y).ToString();
                            break;
                        }
                    default:
                        {
                            result = "0";
                            break;
                        }

                }
                ViewBag.Result = result;
            }
       
       
           

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}