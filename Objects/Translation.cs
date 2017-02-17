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
      Dictionary<int, string> justTens = new Dictionary<int, string>()
      {
        {0, "ten"},
        {1, "eleven"},
        {2, "twelve"},
        {3, "thirteen"},
        {4, "fourteen"},
        {5, "fifteen"},
        {6, "sixteen"},
        {7, "seventeen"},
        {8, "eighteen"},
        {9, "nineteen"},
      };
      Dictionary<int, string> tensPlace = new Dictionary<int, string>()
      {
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
      for (int i = (digitArray.Length - 1); i >= 0; i--)
      {
        var thisDigit = (int)char.GetNumericValue(digitArray[i]);
        // var specialDigit = (int)char.GetNumericValue(digitArray[i-1]);

        if (i == 1)
        {
          if (digitArray[i] == '1')
          {
            char jiwon = digitArray[i-1];
            int allie = (int)char.GetNumericValue(jiwon);
            Console.WriteLine(justTens[allie]);
            finalNumberReversed.Add(justTens[allie]);
            Console.WriteLine("I GOT TO HERE");
          }
          else
          {
            Console.WriteLine("FOR " + userInput);
            Console.WriteLine("FOR ONES PLACE");
            finalNumberReversed.Add(tensPlace[thisDigit]);
          }
        }
        else if (i == 0)
        {
          if (digitArray[i+1] == '1')
          {
            continue;
          }
          else
          {
            finalNumberReversed.Add(onesPlace[thisDigit]);
          }
        }
      }
      Console.WriteLine("FOR " + userInput);
      foreach (string item in finalNumberReversed)
      {
        Console.WriteLine(item);
      }

      string[] fNRArray = finalNumberReversed.ToArray();
      // Array.Reverse(fNRArray);
      string result = string.Join(" ", fNRArray);
      return result;
    }
  }
}
