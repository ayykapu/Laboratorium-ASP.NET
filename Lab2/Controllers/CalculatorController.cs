using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab2.Controllers
{
    public class CalculatorController : Controller
    {

        public enum Operators
        {
            ADD, SUB, MUL, DIV
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result2(string op, int x, int z)
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
                case "+":
                    {
                        result = x + z;
                        break;
                    }
                case "-":
                    {
                        result = x - z;
                        break;
                    }
                case "*":
                    {
                        result = x * z;
                        break;
                    }
                case "/":
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
        public IActionResult ResultNDA([FromQuery(Name = "operator")] Operators? op, double? x, double? z)
        {
            string result;
            if (op == null || x == null || z == null)
            {
                return View("ERROR");
            }
            else
            {
                switch (op)
                {
                    case Operators.ADD:
                        {
                            result = (x + z).ToString();
                            break;
                        }
                    case Operators.SUB:
                        {
                            result = (x - z).ToString();
                            break;
                        }
                    case Operators.MUL:
                        {
                            result = (x * z).ToString();
                            break;
                        }
                    case Operators.DIV:
                        {
                            result = (x / z).ToString();
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
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
