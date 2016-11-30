using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome.Objects
{
  public class Checker
  {
    private string _inputString;
    private bool _isPalindrome;

    public Checker(string newInputString)
    {
      _inputString = newInputString.ToLower();
    }


    public string GetInputString()
    {
      return _inputString;
    }

    public bool GetIsPalindrome()
    {
      return  _isPalindrome;
    }

    public void IsPalindrome()
    {
      string pattern = "[^a-zA-Z\\d:]";
      Regex regToRemove = new Regex(pattern);
      string cleanString = regToRemove.Replace(_inputString, "");
      string reverseString = "";
      for (int i = cleanString.Length - 1; i >= 0; i--)
      {
        reverseString += cleanString[i];
      }
      _isPalindrome = reverseString == cleanString;
    }
  }
}
