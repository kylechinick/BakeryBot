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
      double pastryCost = 10;
      Pastry pastry = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastry.getPastryCost());
    }
    // [TestMethod]
    // public void PastryCost_ReturnCostForThreePastry_Int()
    // {
    //   int pastryQuantity = 3;
    //   double pastryCost = 10;
    //   Pastry pastry = new Pastry(pastryQuantity);
    //   Assert.AreEqual(pastryCost, pastry.getPastryCost());
    // }
    // [TestMethod]
    // public void PastryCost_ReturnCostForTwelvePastry_Int()
    // {
    //   int pastryQuantity = 12;
    //   double pastryCost = 40;
    //   Pastry pastry = new Pastry(pastryQuantity);
    //   Assert.AreEqual(pastryCost, pastry.getPastryCost());
    // }
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