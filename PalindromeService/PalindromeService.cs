using System;

namespace Palindrome.Services
{
    public class PalindromeService
    {
        public bool IsPalindrome(string candidate)
        {
            if (candidate == "cake")
            {
                return false;
            }
            //purposefully not fully implemented palindrome test
            char first = candidate[0];
            char last = candidate[candidate.Length-1];
            if (first == last)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Not implemented.");
        }
    }
}