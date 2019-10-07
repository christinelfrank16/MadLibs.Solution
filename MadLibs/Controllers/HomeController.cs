using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Form() { return View(); }

      [Route("/story")]
      public ActionResult Story(string noun, string verb, string adjective, string animal, string persontwo, string personone) { 
          MadLibEntries entries = new MadLibEntries();
          entries.Adjective = adjective;
          entries.Animal = animal;
          entries.Noun = noun;
          entries.Verb = verb;
          entries.PersonTwo =persontwo;
          entries.PersonOne = personone;

          return View(entries); 
      }
  }
}