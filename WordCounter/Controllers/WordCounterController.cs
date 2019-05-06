using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;


namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/words")]
    public ActionResult Create(string word, string phrase)
    {
      Counter myWordCounter = new Counter(word, phrase);
      myWordCounter.WordCounter();
      return View("Index", myWordCounter);

    }
  }
}
