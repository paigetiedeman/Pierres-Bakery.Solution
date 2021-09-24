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
      if (PastryCount < 3)
      {
        int total = PastryCount * PastryCost;
        return total;
      }
      else if (PastryCount % 3 == 0)
      {
        int total = ((PastryCount / 3) * 5);
        return total;
      } 
      else 
      {
        int total = (PastryCount * PastryCost) - 1;
        return total;
      }
    }
  }
}
// y = 7
// x = 4
// b = 2
// a = ?
// y = xb + a
// 7 = 4*2 - 1 
// 
// 9 = 5*2 -1