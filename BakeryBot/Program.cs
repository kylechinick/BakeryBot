using System;
using System.Collections.Generic;
using System.Linq;
using BakeryBot.Models;

namespace BakeryBot
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("** BAKERYBOT IS NOW ACTIVE **");
      Console.WriteLine("Today's Menu: \n Bread  - $5 - DISCOUNT: buy 2, get 1 free! \n Pastry - $2 - DISCOUNT: 3 for $5");

      Console.WriteLine("How many BREAD orders do you want?");
      int breadOrderQuantity = int.Parse(Console.ReadLine());
      Bread bread = new Bread(breadOrderQuantity);
      double breadOrderCost = bread.getBreadCost();

      Console.WriteLine("How many PASTRY orders do you want?");
      int pastryOrderQuantity = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry(pastryOrderQuantity);
      double pastryOrderCost = pastry.getPastryCost();

      double totalOrderCost = breadOrderCost + pastryOrderCost;
      Console.WriteLine("Bread Cost: " + breadOrderCost);
      Console.WriteLine("Pastry Cost: " + pastryOrderCost);
      Console.WriteLine("Total Order Cost: " + totalOrderCost);
   }
  }
}