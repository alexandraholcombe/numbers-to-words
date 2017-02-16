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

      if (userInput == 0)
      {
        return "zero";
      }
      else if (onesPlace.ContainsKey(userInput))
      {
        return onesPlace[userInput];
      }
      return "";
    }
  }
}
