using Microsoft.AspNetCore.Mvc;
using Wordcount.Models;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace Wordcount.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/game/{id}")]
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
        if(Regex.IsMatch(compare, @"^[a-zA-Z]+$") == true)
        {
          Counter theCounter = new Counter(compare, to);
        }
        return RedirectToAction("Index");
    }

    [HttpPost("/game/delete")]
    public ActionResult DeleteAll()
    {
      Counter.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpPost("/game/{id}")]
    public ActionResult Delete(int id)
    {
      Counter.DeleteAt(id);
      return RedirectToAction("Index");
    }

    [HttpPost("/game/{id}/compare")]
    public ActionResult EditCompare(int id, string compare)
    {
      Counter counter = Counter.Find(id);
      counter.SetCompare(compare);
      return RedirectToAction("Show",id);
    }

    [HttpPost("/game/{id}/to")]
    public ActionResult EditTo(int id, string to)
    {
      Counter counter = Counter.Find(id);
      counter.SetTo(to);
      return RedirectToAction("Show",id);
    }
  }
}
