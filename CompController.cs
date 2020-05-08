

using Microsoft.VisualBasic;
using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace CompareSqurareroot.Controllers
{
    public class CompController : Controller
    {
        [HttpGet]
        public ActionResult Comp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Comp(String firstNumber, String secondNumber)
        {
             if(firstNumber is null || secondNumber is null)
            {
                ViewBag.ErrorMessage = "invalid Numbers entered";
            }
            else if(int.Parse(firstNumber) < 0 || int.Parse(secondNumber) < 0)
            {
                ViewBag.ErrorMessage = " negative number:  entar valid positve  number";
            }


            int numberone = int.Parse(firstNumber);
            int numbertwo = int.Parse(secondNumber);
            int sqr1 = (int)Math.Sqrt(numberone);
            int sqr2 = (int)Math.Sqrt(numbertwo);

            if(sqr1 > sqr2)
            {
                ViewBag.Result = "the number " + firstNumber + " with square root " + sqr1 + " has a higher square root than the number " + secondNumber + " with square root " + sqr2;
            }
            else if(sqr2 > sqr1)
            {
                 ViewBag.Result = "the number " + secondNumber + " with square root " + sqr2 + " has a higher square root than the number " + firstNumber + " with square root " + sqr1;

            }
            else if (sqr1 == sqr2)
            {
                ViewBag.Result = "the number " + firstNumber + " has thesame square root with " + secondNumber + " enter another number";
            }

           
            

            return View();
        }
    }


}
