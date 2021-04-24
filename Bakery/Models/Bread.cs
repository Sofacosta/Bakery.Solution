using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public int BreadQuantity {get;}
    public Bread(int breadQuantity) {
        BreadQuantity = breadQuantity;
    }
  }
}
