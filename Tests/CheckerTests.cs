using Xunit;
using System;
using Palindrome.Objects;

namespace PalindromeTest
{
  public class CheckerTests
  {
    [Theory]
    [InlineData("101", true)]
    [InlineData("dog", false)]
    [InlineData("hello olleh", true)]
    [InlineData("a man a plan a canal panama", true)]
    [InlineData("Sore wAs I ere I saW Eros", true)]
    [InlineData("I, man, am regal; a German am I.", true)]
    public void CheckerTheory(string inputString, bool expectedResult)
    {
      Checker testChecker = new Checker(inputString);
      testChecker.IsPalindrome();
      Assert.Equal(expectedResult, testChecker.GetIsPalindrome());
    }
  }
}
