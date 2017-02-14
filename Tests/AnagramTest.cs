using Xunit;
using System.Collections.Generic;
using AnagramApp.Objects;

namespace AnagramApp
{
  public class AnagramTest
  {
    [Fact]
    public void MatchingWord_isAnagram_TrueMatch()

    {
      //Arrange
      Anagram testObject = new Anagram("rac", "car", "arc", "the");

      string anagram1 = "car";
      string anagram2 = "arc";
      List<string> testList = new List<string>();
      testList.Add(anagram1);
      testList.Add(anagram2);

      //Act
      testObject.MatchingWord();

      //Assert
      Assert.Equal(testObject.outputList, testList);
    }
  }
}
