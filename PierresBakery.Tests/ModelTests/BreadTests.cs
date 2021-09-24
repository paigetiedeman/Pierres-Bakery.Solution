using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadCost_ReturnsBreadCost_Int()
    {
      int count = 1;
      Bread newBread = new Bread(count);
      int cost = newBread.BreadCost;
      Assert.AreEqual(count, cost);
    }
  }
}