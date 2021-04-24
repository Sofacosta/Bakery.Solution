using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry 
  {
    public int PastryQuantity {get;}
    public Pastry(int pastryQuantity) {
        PastryQuantity = pastryQuantity;
    }
  }
}

