using System;

namespace BakeryBot.Models
{
  public class MathBot
  {
    public int FirstNumberToAdd { get; set; }
    public int SecondNumberToAdd { get; set; }

    public MathBot(int firstNumberToAdd, int secondNumberToAdd)
    {
      FirstNumberToAdd = firstNumberToAdd;
      SecondNumberToAdd = secondNumberToAdd;
    }

    public double adderBot()
    {      
      return 0;
    }
  }
}