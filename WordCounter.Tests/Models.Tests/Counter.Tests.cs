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
    [TestMethod]
    public void DoesContain_DoesContain_True()
    {
      Counter newWord = new Counter();
      Assert.AreEqual(true, newWord.DoesContain("test", "test"));
    }

    [TestMethod]
    public void CountContains_DoesContain_True()
    {
      Counter newWord = new Counter();
      Assert.AreEqual(2, newWord.CountContains("test", "this is a test test"));
    }

    [TestMethod]
    public void CountContainsAccurate_DoesContain_True()
    {
      Counter newWord = new Counter();
      Assert.AreEqual(1, newWord.CountContains("test", "this is a test testify"));
    }

    [TestMethod]
    public void CountContainsCharacters_DoesContainCharacters_True()
    {
      Counter newWord = new Counter();
      Assert.AreEqual(2, newWord.CountContains("test", "this is a test test."));
    }

  }
}
