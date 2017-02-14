using System;
using System.Collections.Generic;

namespace AnagramApp.Objects
{
  public class Anagram
  {

    public string _startingWord;
    public string _option1Word;
    public string _option2Word;
    public string _option3Word;

    public List<string> outputList;

    public char[] _startingArray;
    public char[] _option1Array;
    public char[] _option2Array;
    public char[] _option3Array;



    public Anagram(string startingWord, string option1Word, string option2Word, string option3Word)
    {
      _option1Word = option1Word;
      _option2Word = option2Word;
      _option3Word = option3Word;
      _startingWord = startingWord;
      outputList = new List<string>();
    }



    public void MatchingWord()
    {
      _startingArray = _startingWord.ToCharArray();
      _option1Array = _option1Word.ToCharArray();
      _option2Array = _option2Word.ToCharArray();
      _option3Array = _option3Word.ToCharArray();

      int count1 = 0;
      int count2 = 0;
      int count3 = 0;

      for(int i = 0; i < _startingArray.Length; i++)
      {
        for(int j = 0; j < _startingArray.Length; j++)
        {
          if (_startingArray[i] == _option1Array[j])
          {
            count1++;
          }
          if (_startingArray[i] == _option2Array[j])
          {
            count2++;
          }
          if (_startingArray[i] == _option3Array[j])
          {
            count3++;
          }
          //startingarray = car
          //optionarray = rac
        }
      }

      if (count1 == _startingArray.Length)
      {
        outputList.Add(_option1Word);
      }

      if (count2 == _startingArray.Length)
      {
        outputList.Add(_option2Word);
      }

      if (count3 == _startingArray.Length)
      {
        outputList.Add(_option3Word);
      }
    }

    //Anagram testObject = new Anagram("car", "rac", "dad", "dead")
  }
}
