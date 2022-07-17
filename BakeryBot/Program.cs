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
      Console.WriteLine("Welcome to Pierre's Bakery!\n");
      Console.WriteLine("Today's Menu: \n Bread  - $5 - DISCOUNT: buy 2, get 1 free! \n Pastry - $2 - DISCOUNT: 3 for $5\n");

      Console.WriteLine("How many BREAD orders do you want?");
      int breadOrderQuantity = int.Parse(Console.ReadLine());
      Bread bread = new Bread(breadOrderQuantity);
      double breadOrderCost = bread.getBreadCost();
      Console.WriteLine("");

      Console.WriteLine("How many PASTRY orders do you want?");
      int pastryOrderQuantity = int.Parse(Console.ReadLine());
      Pastry pastry = new Pastry(pastryOrderQuantity);
      double pastryOrderCost = pastry.getPastryCost();
      Console.WriteLine("");

      MathBot mathBot = new MathBot(breadOrderCost, pastryOrderCost);
      double totalOrderCost = mathBot.adderBot();
      Console.WriteLine("\n Bread Cost: $" + breadOrderCost);
      Console.WriteLine("\n Pastry Cost: $" + pastryOrderCost);
      Console.WriteLine("\n --> Total Order Cost: $" + totalOrderCost);

      Console.WriteLine("");
      Console.WriteLine("Thank you for your order. We hope to see you again soon!\n");
   }
  }
}