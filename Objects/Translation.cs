using System;
using System.Collections.Generic;

namespace NumbersToWordsApp
{
  public class Translation
  {
    public string Translator(int userInput)
    {
      Dictionary<int, string> onesPlace = new Dictionary<int, string>()
      {
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"}
      };
      Dictionary<int, string> tensPlace = new Dictionary<int, string>()
      {
        {10, "ten"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"},
        {20, "twenty"},
        {30, "thirty"},
        {40, "forty"},
        {50, "fifty"},
        {60, "sixty"},
        {70, "seventy"},
        {80, "eighty"},
        {90, "ninety"}
      };

      if (userInput == 0)
      {
        return "zero";
      }
      else if (onesPlace.ContainsKey(userInput))
      {
        return onesPlace[userInput];
      }
      else if (tensPlace.ContainsKey(userInput))
      {
        return tensPlace[userInput];
      }
      return "";
    }
  }
}
