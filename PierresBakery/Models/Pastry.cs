using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCount {get; set; }
    public int PastryCost {get; set; }

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
      PastryCost = 2;
    }

    public int PastryOrder()
    {
      if (PastryCount % 3 == 0)
      {
      int total = ((PastryCount / 3) * 5);
      return total;
      } 
      else 
      {
      int total = PastryCount * PastryCost;
      return total;
      }
    }
  }
}
// 1 = 2 - 1*2  
// 3 = 5 - 3*2 - 3/3
// 4 = 7 - 4*2 
// 