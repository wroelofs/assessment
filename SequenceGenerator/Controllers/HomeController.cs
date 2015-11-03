using WouterRoelofs.Assessments.SequenceGenerator.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WouterRoelofs.Assessments.SequenceGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Generate(Input input)
        {
            var sequences = new List<ISequence>()
            {
                new AllNumbersSequence(input.Number),
                new OddNumbersSequence(input.Number),
                new EvenNumbersSequence(input.Number),
                new CEZNumbersSequence(input.Number),
                new FibonacciNumbersSequence(input.Number)
            };

            return View(sequences);
        }
    }
}