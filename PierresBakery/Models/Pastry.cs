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
      
    }
  }
}