using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryBot.Models;

namespace BakeryBot.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_ReturnBaseCost_Int()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      int breadQuantity = 1;
      double breadCost = 5;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
    [TestMethod]
    public void BreadCost_ReturnCostForTwoBread_Int()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      int breadQuantity = 2;
      double breadCost = 10;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
  }
}