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

		[Fact]
		public void isPalindomeMustReturnTrueWhenReceivesAPalindromeOfNumbersInAString()
		{
			var result = PalindromeChecker.isPalindrome("1234321");
			Assert.True(result);
		}

		[Fact]
		public void isPalindomeMustReturnTrueWhenReceivesAPalindromeOfNumbers()
		{
			var result = PalindromeChecker.isPalindrome(1234321);
			Assert.True(result);
		}

		[Fact]
		public void isPalindomeMustReturnFalseWhenReceivesAPNonalindromeOfNumbersInAString()
		{
			var result = PalindromeChecker.isPalindrome("91234321");
			Assert.False(result);
		}

		[Fact]
		public void isPalindomeMustReturnFalseWhenReceivesANonPalindromeOfNumbers()
		{
			var result = PalindromeChecker.isPalindrome(91234321);
			Assert.False(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeFloatNumber()
		{
			var result = PalindromeChecker.isPalindrome(10.01);
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesANonPalindromeFloatNumber()
		{
			var result = PalindromeChecker.isPalindrome(10.11);
			Assert.False(result);
		}
	}
}