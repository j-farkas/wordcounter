using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Wordcount.Controllers;
using Wordcount.Models;

namespace Wordcount.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult indexView = controller.Index();

      //ASSERT
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));

    }

    [TestMethod]
    public void Index_HasCorrectModelType_CounterList()
    {
      //Arrange
      ViewResult indexView = new WordCounterController().Index() as ViewResult;

      //act
      var result = indexView.ViewData.Model;

      //assert
      Assert.IsInstanceOfType(result, typeof(List<Counter>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();

      //Act
      IActionResult view = controller.Create("walk","Walk the dog");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      WordCounterController controller = new WordCounterController();
      RedirectToActionResult actionResult = controller.Create("walk","Walk the dog") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
