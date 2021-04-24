using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      bool runBakery = true;
      bool runBread = true;
      bool runPastry = false;
      int breadQuantity = -1;
      int pastryQuantity = -1;


      while (runBakery) {
        while (runBread) {
          Console.WriteLine("Hello, welcome to Pierre's Bakery!\n\nA single loaf of bread costs $5 and a single pastry costs $2.\n\nToday we have some special promotions!\n \u2022 Buy 2 loaves of bread and get one free.\n \u2022 Buy 3 pastries for $5.\n\nThe discount will be applied to your total.\n\nHow many loaves of bread would you like? (please enter numbers only)");
          string breadAnswer = System.Console.ReadLine();
          try
            {
                breadQuantity = Convert.ToInt32(breadAnswer);
          }
          catch (FormatException)
          {
              Console.WriteLine("Sorry, I didn't understand that! I'm just a robot. How many loaves of bread would you like? (pleaseenter numbers only)");
              breadAnswer = System.Console.ReadLine();
          }
          Bread newBread = new Bread(breadQuantity);
          
          if (newBread != null) {
            runBread = false;
            runPastry = true;
          }        
        }
        
        while (runPastry) {
          Console.WriteLine("How many pastries would you like? (please enter numbers only)");
          string pastryAnswer = System.Console.ReadLine();
          try
          {
              pastryQuantity = Convert.ToInt32(pastryAnswer);
          }
          catch (FormatException)
          {
              Console.WriteLine("Sorry, I didn't understand that! I'm just a robot. How many pastries would you like? (please enter numbers only)");
              pastryAnswer = System.Console.ReadLine();
          }
          Pastry newPastry = new Pastry(pastryQuantity);
          
          if (newPastry != null) {
            runPastry = false;
          } 
        }

        if (breadQuantity > 0 || pastryQuantity > 0) {
          runBakery = false;
        }
      }
    }
  }
}


