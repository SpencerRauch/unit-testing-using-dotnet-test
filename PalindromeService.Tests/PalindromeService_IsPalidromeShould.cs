using Xunit;
using Palindrome.Services;
using System.Reflection;

namespace Palindrome.UnitTests.Services
{

    public class PalindromeService_IsPalindromeShould
    {
        public PalindromeService_IsPalindromeShould()
        {
            PalindromeService _palindromeService = new PalindromeService();
        }

        [Theory]
        [InlineData("cake")]
        [InlineData("pie")]
        [InlineData("tort")]
        public void IsPalindrome_Inputs_ReturnFalse(string value)
        {
            var palindromeService = new PalindromeService();
            bool result = palindromeService.IsPalindrome(value);

            Assert.False(result, $"{value} should not be a palindrome");
        }

        [Theory]
        [InlineData("bob")]
        [InlineData("racecar")]
        [InlineData("partytrap")]
        public void IsPalindrome_Inputs_ReturnTrue(string value)
        {
            var palindromeService = new PalindromeService();
            bool result = palindromeService.IsPalindrome(value);

            Assert.True(result, $"{value} should be a palindrome");
        }
    }
}