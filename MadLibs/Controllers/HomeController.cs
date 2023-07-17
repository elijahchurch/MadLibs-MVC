using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers 
{
    public class HomeController: Controller
    {
        [Route("/")]
        public ActionResult Form() {return View();}

        [Route("/story")]
        public ActionResult Story(string name1, string name2, string animal, string exclamation, string thing, string food)
        {
            Words wordList = new Words;
            wordList.Name1 = name1;
            wordList.Name2 = name2;
            wordList.Animal = animal;
            wordList.Exclamation = thing;
            wordList.Food = food;
            return View(wordList);
        }
    }
}