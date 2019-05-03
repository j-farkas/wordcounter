using Microsoft.AspNetCore.Mvc;
using Wordcount.Models;
using System.Collections.Generic;

namespace WordCount.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
