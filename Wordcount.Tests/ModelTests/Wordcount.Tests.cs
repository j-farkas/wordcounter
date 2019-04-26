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
    [TestMethod]
    public void CheckCount_ReturnWordInWord_1()
    {
      Counter theCount = new Counter("cat","cat");
      Assert.AreEqual(1, theCount.Count());
    }
    [TestMethod]
    public void CheckCount_ReturnWordInWords_2()
    {
      Counter theCount = new Counter("cat","cat cat");
      Assert.AreEqual(2, theCount.Count());
    }
    [TestMethod]
    public void CheckCount_ReturnWordInbiggerword_2()
    {
      Counter theCount = new Counter("cat","cat cathedral");
      Assert.AreEqual(2, theCount.Count());
    }
    [TestMethod]
    public void CheckCount_ReturnWordIgnoreSymbolsbiggerword_2()
    {
      Counter theCount = new Counter("cat","cat c/a.thedral");
      Assert.AreEqual(2, theCount.Count());
    }
  }
}
