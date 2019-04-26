using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordcount.Models;

namespace Wordcount.TestTools
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void CheckCount_ReturnSingleLetter_1()
    {
      Counter theCount = new Counter("a","a");
      Assert.AreEqual(1, theCount.Count());
    }
    [TestMethod]
    public void CheckCount_ReturnSingleLetterInWord_1()
    {
      Counter theCount = new Counter("a","cat");
      Assert.AreEqual(1, theCount.Count());
    }
  }
}
