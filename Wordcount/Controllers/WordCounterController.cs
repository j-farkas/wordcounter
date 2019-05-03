using Microsoft.AspNetCore.Mvc;
using Wordcount.Models;
using System.Collections.Generic;
using System;

namespace Wordcount.Controllers
{
  public class WordCounterController : Controller
  {

    // [HttpPost("/game/play/{letter}")]
    // public ActionResult New(char letter)
    // {
    //    Game playing = Game.Find(1);
    //
    //    char[] theWord = playing.TheWord.ToCharArray();
    //    if(Array.IndexOf(theWord, letter) < 0)
    //    {
    //      playing.Guesses = playing.Guesses+1;
    //    }
    //    while(Array.IndexOf(theWord, letter) >= 0)
    //    {
    //      playing.SetGuessed(Array.IndexOf(theWord, letter), letter);
    //      theWord[Array.IndexOf(theWord,letter)] = '_';
    //    }
    //    Game.RemoveLetter(letter);
    //    playing.TheWord = new string(theWord);
    //    if(Array.IndexOf(playing.GetGuessed(),'_') < 0)
    //    {
    //      playing.Winner();
    //    }
    //    return RedirectToAction("Play");
    // }
    //
    [HttpGet("/game")]
    public ActionResult Index()
    {

      if(Counter.GetAll().Count > 0)
      {
        List<Counter> allCounters = Counter.GetAll();
        return View(allCounters);
      }else
      {
        return RedirectToAction("Add");
      }

    }

    [HttpGet("/game/add")]
      public ActionResult Add()
      {
        return View();
      }

    [HttpPost("/game")]
      public ActionResult Create(string compare, string to)
      {
          Counter theCounter = new Counter(compare, to);
          return RedirectToAction("Index");
      }


      [HttpPost("/game/delete")]
      public ActionResult DeleteAll()
      {
        Counter.ClearAll();
        return RedirectToAction("Index");
      }

  }
}
