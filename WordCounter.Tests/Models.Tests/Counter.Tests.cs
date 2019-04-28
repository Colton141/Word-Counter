using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWord_IsAWord_True()
    {
      Counter newWord = new Counter();
      Assert.AreEqual(true, newWord.IsWord("test"));
    }


  }
}
