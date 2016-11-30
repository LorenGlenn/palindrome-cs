using Nancy;
using System;
using System.Collections.Generic;
using Palindrome.Objects;

namespace Palindrome
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];

      Get["/check"] =_=> {
        string inputString = Request.Query["input-string"];
        Checker palindromeChecker = new Checker(inputString);
        palindromeChecker.IsPalindrome();
        return View["index.cshtml", palindromeChecker];
      };
    }
  }
}
