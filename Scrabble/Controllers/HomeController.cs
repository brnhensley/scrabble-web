using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;
using System;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [Route("/answer")]
    public ActionResult Answer(string word)
    {
      Word scoreThis = new Word(word);
      return View(scoreThis);
    }

    [Route("/")]
    public ActionResult Index() {return View(); }
  }
}
