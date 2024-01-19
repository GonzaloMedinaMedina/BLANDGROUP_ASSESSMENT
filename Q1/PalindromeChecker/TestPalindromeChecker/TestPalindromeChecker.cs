namespace TestPalindromeChecker
{
	public class TestPalindromeChecker
	{
		[Fact]
		public void isPalindromeMustReturnFalseWhenReceivesNonPalindromeWord()
		{
			var result = PalindromeChecker.isPalindrome("nonPalindrome");
			Assert.False(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWord()
		{
			var result = PalindromeChecker.isPalindrome("deleveled");
			Assert.True(result);
		}
	}
}