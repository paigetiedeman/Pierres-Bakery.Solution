using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCount { get; set; }
    public int BreadCost {get; set; }

    public Bread(int breadCount)
    {
      BreadCount = breadCount;
      BreadCost = 5;
    }
    public int BreadOrder()
    {
      int total = BreadCount * BreadCost;
      return total;
    }
  }
}