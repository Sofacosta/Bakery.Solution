using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread 
  {
    public int BreadQuantity {get;}
    public int TotalBreadPrice = 0;
    public int FreeBreads = 0;
    public int Remainder = 0;
    public Bread(int breadQuantity) {
        BreadQuantity = breadQuantity;
        TotalBreadPrice = getBreadTotalPrice();
    
    }

    public int getBreadTotalPrice()
    {  
      Remainder = BreadQuantity % 3;
      FreeBreads = Convert.ToInt32(Math.Round((BreadQuantity - Remainder) * .334));

      return (BreadQuantity - FreeBreads) * 5;
    }
  }
}
