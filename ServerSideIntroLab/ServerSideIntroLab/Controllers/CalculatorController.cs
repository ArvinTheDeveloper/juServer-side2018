using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerSideIntroLab.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        /*Calculate: Retreives data from form using PostMethod with Request.Form and performs arithmetic calculations which then is returned*/
        [HttpPost]
        public ActionResult Calculate()
        {
            var firstNumber = Double.Parse(Request.Form["firstNumber"]);
            var secondNumber = Double.Parse(Request.Form["secondNumber"]);
            var arithmetic = Request.Form["arithmetic"];
            if (arithmetic == "plus")
            {
                ViewBag.Result = (firstNumber + secondNumber);
            }else if (arithmetic == "minus")
            {
                ViewBag.Result = (firstNumber - secondNumber);
            }
            else if (arithmetic == "multiply")
            {
                ViewBag.Result = (firstNumber * secondNumber);          
            }
            else if (arithmetic == "divide")
            {
                ViewBag.Result = (firstNumber / secondNumber);           
            }
            else { ViewBag.Result = "You did not select a arithmetic type or you selected more than one type."; }

            return View();
        }

        /*GetCalculate: Retreives data from form using GetMethod with Request.QueryString and performs arithmetic calculations which then is returned*/
        [HttpGet]
        public ActionResult GetCalculate()
        {
            var firstNumber = Double.Parse(Request.QueryString["firstNumber"]);
            var secondNumber = Double.Parse(Request.QueryString["secondNumber"]);
            var arithmetic = Request.QueryString["arithmetic"];
            if (arithmetic == "plus")
            {
                ViewBag.Result = (firstNumber + secondNumber);
            }
            else if (arithmetic == "minus")
            {
                ViewBag.Result = (firstNumber - secondNumber);
            }
            else if (arithmetic == "multiply")
            {
                ViewBag.Result = (firstNumber * secondNumber);
            }
            else if (arithmetic == "divide")
            {
                ViewBag.Result = (firstNumber / secondNumber);
            }
            else { ViewBag.Result = "You did not select a arithmetic type or you selected more than one type."; }

            return View();
        }

    }
}