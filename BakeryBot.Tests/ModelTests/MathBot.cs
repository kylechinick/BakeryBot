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
    public void AdderBot_ReturnSum_Int()
    {
      int firstNumberToAdd = 1;
      int secondNumberToAdd = 1;
      double expectedSum = 5;
      MathBot mathBot = new MathBot(firstNumberToAdd, secondNumberToAdd);
      Assert.AreEqual(expectedSum, mathBot.adderBot());
    }
  }
}