using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {

[TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        IActionResult NewTest = controller.Create("word", "this is a test word");

        //Assert
        Assert.IsInstanceOfType(NewTest, typeof(RedirectToActionResult));

  }
}
