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

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPairPalindromeWord()
		{
			var result = PalindromeChecker.isPalindrome("deleeled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithCharacterCase()
		{
			var result = PalindromeChecker.isPalindrome("Deleveled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithWhiteSpaces()
		{
			var result = PalindromeChecker.isPalindrome("D    elev eled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithSpecialCharacters()
		{
			var result = PalindromeChecker.isPalindrome("deleve&* {},=-_().;:'\"/\\|@#~€$!¡?¿%<>led\\");
			Assert.True(result);
		}
	}
}