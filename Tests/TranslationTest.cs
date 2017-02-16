using Xunit;
using System;
using System.Collections.Generic;

namespace NumbersToWordsApp
{
  public class TranslationTest
  {
    [Fact]
    public void Translator_ForNumber0_zero()
    {
      Translation testTranslation = new Translation();
      Assert.Equal("zero", testTranslation.Translator(0));
    }
    [Fact]
    public void Translator_ForSingleDigitNumber_written_number()
    {
      Translation testTranslation = new Translation();
      Assert.Equal("one", testTranslation.Translator(1));
    }
  }
}
