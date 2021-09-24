using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCount { get; set; }

    public Bread(int breadcount)
    {
      BreadCount = breadcount;
    }
  }
}