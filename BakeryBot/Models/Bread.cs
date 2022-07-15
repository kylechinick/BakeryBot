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
            _BreadDiscount = 0.5;
            BreadQuantity = breadQuantity;
        }

        public double getBreadCost()
        {
          return 1;
        }
    }
}