using System;

namespace BakeryBot.Models
{
  public class MathBot
  {
    public double FirstNumberToAdd { get; set; }
    public double SecondNumberToAdd { get; set; }

    public MathBot(double firstNumberToAdd, double secondNumberToAdd)
    {
      FirstNumberToAdd = firstNumberToAdd;
      SecondNumberToAdd = secondNumberToAdd;
    }

    public double adderBot()
    {      
      double adderSum = FirstNumberToAdd + SecondNumberToAdd;
      return adderSum;
    }
  }
}