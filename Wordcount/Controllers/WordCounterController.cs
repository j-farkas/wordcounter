using Microsoft.AspNetCore.Mvc;
using Wordcount.Models;
using System.Collections.Generic;
using System;

namespace Wordcount.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/items/{id}")]
      public ActionResult Show(int id)
      {
        Counter counter = Counter.Find(id);
        return View(counter);
      }

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
