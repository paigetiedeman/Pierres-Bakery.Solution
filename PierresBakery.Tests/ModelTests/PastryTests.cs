using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryCount_ReturnsPastryCount_Int()
    {
      int pastryCount = 1;
      Pastry newPastry = new Pastry(pastryCount);
      int count = newPastry.PastryCount;
      Assert.AreEqual(pastryCount, count);
    }
    [TestMethod]
    public void SetPastryCount_SetPastryCount_Int()
    {
      int pastryCount = 1;
      Pastry newPastry = new Pastry(pastryCount);
      int pastryCountTwo = 2;
      newPastry.PastryCount = pastryCountTwo;
      int count = newPastry.PastryCount;
      Assert.AreEqual(pastryCountTwo, count);
    }
    [TestMethod]
    public void GetPastryCost_ReturnsPastryCost_Int()
    {
      int pastryCost = 2;
      Pastry newPastry = new Pastry(pastryCost);
      int cost = newPastry.PastryCost;
      Assert.AreEqual(pastryCost, cost);
    }
    [TestMethod]
    public void GetPastryOrder_ReturnsPastryOrder_Int()
    {
      int pastryCount = 1;
      int pastryCost = 2;
      Pastry newPastry = new Pastry(pastryCount);
      int pastryOrder = newPastry.PastryOrder();
      Assert.AreEqual(pastryCost, pastryOrder);
    }
  }
}