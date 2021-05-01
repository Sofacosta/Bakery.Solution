using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry 
  {
    public int PastryQuantity {get;}
    public int TotalPastryPrice = 0;
    public int discountedPastries = 0;
    public int PastryExcess = 0;
  
    public Pastry(int pastryQuantity) {
        PastryQuantity = pastryQuantity;
        TotalPastryPrice = getPastryTotalPrice();        
    }
    public int getPastryTotalPrice()
    {
      PastryExcess = PastryQuantity % 3;
      discountedPastries = Convert.ToInt32(Math.Round((PastryQuantity - PastryExcess) * .334));
      
      return (PastryQuantity * 2) - discountedPastries;
    }
  }
}

