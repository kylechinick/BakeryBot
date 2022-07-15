using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BakeryBot.Models;

namespace BakeryBot.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_ReturnBaseCost_Int()
    {
      int pastryQuantity = 1;
      double pastryCost = 2;
      Pastry pastry = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastry.getPastryCost());
    }
    [TestMethod]
    public void PastryCost_ReturnCostForTwoPastry_Int()
    {
      int pastryQuantity = 2;
      double pastryCost = 4;
      Pastry pastry = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastry.getPastryCost());
    }
    [TestMethod]
    public void PastryCost_ReturnCostForThreePastry_Int()
    {
      int pastryQuantity = 3;
      double pastryCost = 5;
      Pastry pastry = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastry.getPastryCost());
    }
    [TestMethod]
    public void PastryCost_ReturnCostForFourPastry_Int()
    {
      int pastryQuantity = 4;
      double pastryCost = 4;
      Pastry pastry = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastry.getPastryCost());
    }
    // [TestMethod]
    // public void PastryCost_ReturnCostForNonPowerOfThreePastry_Int()
    // {
    //   int pastryQuantity = 17;
    //   double pastryCost = 60;
    //   Pastry pastry = new Pastry(pastryQuantity);
    //   Assert.AreEqual(pastryCost, pastry.getPastryCost());
    // }
  }
}