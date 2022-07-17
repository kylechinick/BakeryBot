using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryBot.Models;

namespace BakeryBot.Tests
{
  [TestClass]
  public class MathBotTests
  {
    [TestMethod]
    public void AdderBot_ReturnSum_Double()
    {
      double firstNumberToAdd = 1;
      double secondNumberToAdd = 5;
      double expectedSum = 6;
      MathBot mathBot = new MathBot(firstNumberToAdd, secondNumberToAdd);
      Assert.AreEqual(expectedSum, mathBot.adderBot());
    }
  }
}