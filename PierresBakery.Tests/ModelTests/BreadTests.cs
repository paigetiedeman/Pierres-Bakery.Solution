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
    public void GetBreadCount_ReturnsBreadCount_Int()
    {
      int breadCount = 1;
      Bread newBread = new Bread(breadCount);
      int count = newBread.BreadCount;
      Assert.AreEqual(breadCount, count);
    }
    [TestMethod]
    public void SetBreadCount_SetBreadCount_Int()
    {
      int breadCount = 1;
      Bread newBread = new Bread(breadCount);
      int breadCountTwo = 2;
      newBread.BreadCount = breadCountTwo;
      int count = newBread.BreadCount;
      Assert.AreEqual(breadCountTwo, count);
    }
    [TestMethod]
    public void GetBreadCost_GetBreadCost_Int()
    {
    int breadCost = 5;
    Bread newBread = new Bread(breadCost);
    int cost = newBread.BreadCost;
    Assert.AreEqual(breadCost, cost);
    }
    [TestMethod]
    public void GetBreadOrder_GetBreadOrder_Int()
    {
      int breadCount = 1;
      int breadCost = 5;
      Bread newBread = new Bread(breadCount);
      int breadOrder = newBread.BreadOrder();
      Assert.AreEqual(breadCost, breadOrder);
    }
    [TestMethod]
    public void GetBreadOrder_GetBreadOrder3_Int()
    {
      int breadCount = 3;
      int breadCost = 10;
      Bread newBread = new Bread(breadCount);
      int breadOrder = newBread.BreadOrder();
      Assert.AreEqual(breadCost, breadOrder);
    }
  }
}