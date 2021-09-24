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
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadCount_ReturnsBreadCost_Int()
    {
      int breadcount = 1;
      Bread newBread = new Bread(breadcount);
      int cost = newBread.BreadCount;
      Assert.AreEqual(breadcount, cost);
    }
  }
}