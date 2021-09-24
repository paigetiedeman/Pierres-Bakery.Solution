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
      if (BreadCount % 3 == 0)
      {
      int promoTotal = (BreadCount * BreadCost)- ((BreadCount / 3) * BreadCost);
      return promoTotal;
      }
      else 
      {
      int total = BreadCount * BreadCost;
      return total;
      }
    }
  }
}

// / 3 or % 3 = 0