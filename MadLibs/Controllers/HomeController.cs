using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult StoryChooser() { return View(); }

      [Route("/form")]
      public ActionResult Form() { return View(); }

      [Route("/halloween-form")]
      public ActionResult HalloweenForm() { return View(); }

      [Route("/hstory")]
      public ActionResult HalloweenS(string noun, string verb_ing, string noun2, string noun3, string bodypart, string noun4, string verb_ing2, string bodypart_pl, string verb_ing3, string furniture, string noun_pl, string noun5, string bodypart2, string adverb, string bodypart3)
      {
          MadLibEntries entries = new MadLibEntries();
          entries.Noun = noun;
          entries.Noun2 = noun2;
          entries.Noun3 = noun3;
          entries.Noun4 = noun4;
          entries.Noun5 = noun5;
          entries.Noun_pl = noun_pl;
          entries.Verb_ing2 = verb_ing2;
          entries.Verb_ing = verb_ing;
          entries.Verb_ing3 = verb_ing3;
          entries.Bodypart_pl = bodypart_pl;
          entries.Bodypart2 = bodypart2;
          entries.Bodypart3 = bodypart3;
          entries.Bodypart = bodypart;
          entries.Adverb = adverb;
          entries.Furniture = furniture;

          return View(entries); 
      } 

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