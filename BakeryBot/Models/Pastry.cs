using System;

namespace BakeryBot.Models
{
  public class Pastry
  {
      private static double _PastryCost = 5;
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
          if (PastryQuantity < 3)
          {
            pastrySumCost = _PastryCost * PastryQuantity;
          }
          else
          {
            pastrySumCost = 
            _PastryCost * PastryQuantity 
            - (_PastryDiscount * (PastryQuantity / 3));
          }
          return pastrySumCost;
        }
    }
}