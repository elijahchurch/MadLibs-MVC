using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers 
{
    public class HomeController: Controller
    {
        [Route("/")]
        public ActionResult Form() {return View();}

        [Route("/story")]
        public ActionResult Story()
        {
            Words wordList = new Words;

            return View(wordList);
        }
    }
}