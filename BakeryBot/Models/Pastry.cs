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
        double discountedPastryQuantity = PastryQuantity / 3;
        double standardRatePastryQuantity = PastryQuantity - (discountedPastryQuantity * 3);
        pastrySumCost = (_PastryCost * standardRatePastryQuantity) + (_PastryDiscount * discountedPastryQuantity);
      }
      return pastrySumCost;
    }
  }
}