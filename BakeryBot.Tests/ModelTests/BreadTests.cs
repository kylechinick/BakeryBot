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
      int breadQuantity = 1;
      double breadCost = 5;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
    [TestMethod]
    public void BreadCost_ReturnCostForTwoBread_Int()
    {
      int breadQuantity = 2;
      double breadCost = 10;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
    [TestMethod]
    public void BreadCost_ReturnCostForThreeBread_Int()
    {
      int breadQuantity = 3;
      double breadCost = 10;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
    [TestMethod]
    public void BreadCost_ReturnCostForTwelveBread_Int()
    {
      int breadQuantity = 12;
      double breadCost = 40;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
    [TestMethod]
    public void BreadCost_ReturnCostForNonPowerOfThreeBread_Int()
    {
      int breadQuantity = 17;
      double breadCost = 60;
      Bread bread = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, bread.getBreadCost());
    }
  }
}