using System;

namespace BakeryBot.Models
{
  public class Pastry
  {
    private static double _PastryCost = 2;
    private double _PastryDiscount;
    public int PastryQuantity { get; set; }
    public static double PastryCost
    {
      get { return _PastryCost; }
      set { _PastryCost = value; }
    }

    public Pastry(int pastryQuantity)
    {
      _PastryCost = PastryCost;
      _PastryDiscount = 5;
      PastryQuantity = pastryQuantity;
    }
    public double getPastryCost()
    {
      double pastrySumCost = 0;
      if (PastryQuantity % 3 == 0)
      {
        pastrySumCost = _PastryDiscount * (PastryQuantity / 3); 
      }
      else
      {
        pastrySumCost = _PastryCost * PastryQuantity;
      }
      return pastrySumCost;
    }
  }
}

      // if (PastryQuantity < 3)
      // {
      //   pastrySumCost = _PastryCost * PastryQuantity;
      // }
      
// pastrySumCost = _PastryCost * (PastryQuantity / 3);

        // double numberOfDiscountedPastries = PastryQuantity / 3;

        // pastrySumCost = _PastryCost * PastryQuantity - (_PastryDiscount * (PastryQuantity / 3));

 // else if (something)
      // {
      //   double numberOfDiscountedPastries = PastryQuantity / 3;
      //   // ...?
      // }