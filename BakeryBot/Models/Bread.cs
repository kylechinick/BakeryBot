using System;

namespace BakeryBot.Models
{
  public class Bread
  {
      private static double _BreadCost = 5;
        private double _BreadDiscount;
        public int BreadQuantity { get; set; }

        public static double BreadCost
        {
            get { return _BreadCost; }
            set { _BreadCost = value; }
        }

        public Bread(int breadQuantity)
        {
            _BreadCost = BreadCost;
            _BreadDiscount = 5;
            BreadQuantity = breadQuantity;
        }

        public double getBreadCost()
        {
          double breadSumCost = 0;
          if (BreadQuantity < 3)
          {
            breadSumCost = _BreadCost * BreadQuantity;
          }
          else if (BreadQuantity % 3 == 0)
          {
            breadSumCost = 
            _BreadCost * BreadQuantity 
            - (_BreadDiscount * (BreadQuantity / 3));
          }
          else
          {
            breadSumCost = 
            _BreadCost * BreadQuantity 
            - (_BreadDiscount * (BreadQuantity / 3));
          }
          return breadSumCost;
        }
    }
}