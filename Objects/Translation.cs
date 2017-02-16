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
        {0, "zero"},
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
        // {10, "ten"},
        // {12, "twelve"},
        // {13, "thirteen"},
        // {14, "fourteen"},
        // {15, "fifteen"},
        // {16, "sixteen"},
        // {17, "seventeen"},
        // {18, "eighteen"},
        // {19, "nineteen"},
        {2, "twenty"},
        {3, "thirty"},
        {4, "forty"},
        {5, "fifty"},
        {6, "sixty"},
        {7, "seventy"},
        {8, "eighty"},
        {9, "ninety"}
      };

      char[] digitArray = userInput.ToString().ToCharArray();
      Array.Reverse(digitArray);

      List<string> finalNumberReversed = new List<string>{};

      for (int i = 0; i < digitArray.Length; i++)
      {
        if (i == 0)
        {
          finalNumberReversed.Add(onesPlace[(int)char.GetNumericValue(digitArray[i])]);
        }
        else if (i == 1)
        {
          finalNumberReversed.Add(tensPlace[(int)char.GetNumericValue(digitArray[i])]);
        }
      }

      foreach (string index in finalNumberReversed)
      {
        Console.WriteLine(finalNumberReversed);
      }
      string[] fNRArray = finalNumberReversed.ToArray();
      Array.Reverse(fNRArray);
      // List<string> finalNumber = List<string>.Reverse(finalNumberReversed);
      string result = string.Join(" ", fNRArray);
      return result;
      // return "";
      // if (userInput == 0)
      // {
      //   return "zero";
      // }
      // else if (onesPlace.ContainsKey(userInput))
      // {
      //   return onesPlace[userInput];
      // }
      // else if (tensPlace.ContainsKey(userInput))
      // {
      //   return tensPlace[userInput];
      // }
      // return "";
    }
  }
}
