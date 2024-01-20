using Moq;

namespace TestPalindromeChecker
{
	public class TestPalindromeChecker
	{
		private PalindromeChecker? _palindromeChecker;
		public PalindromeChecker palindromeChecker
		{
			get 
			{
				if (_palindromeChecker == null)
				{
					_palindromeChecker = new PalindromeChecker ();
				}

				return _palindromeChecker;
			}
			set { _palindromeChecker = value; }
		}


		[Fact]
		public void isPalindromeMustReturnFalseWhenReceivesNonPalindromeWord()
		{
			var result = palindromeChecker.isPalindrome("nonPalindrome");
			Assert.False(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWord()
		{
			var result = palindromeChecker.isPalindrome("deleveled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPairPalindromeWord()
		{
			var result = palindromeChecker.isPalindrome("deleeled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithCharacterCase()
		{
			var result = palindromeChecker.isPalindrome("Deleveled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithWhiteSpaces()
		{
			var result = palindromeChecker.isPalindrome("D    elev eled");
			Assert.True(result);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeWithSpecialCharacters()
		{
			var result = palindromeChecker.isPalindrome("deleve&* {},=-_().;:'\"/\\|@#~€$!¡?¿%<>led\\");
			Assert.True(result);
		}

		[Fact]
		public void isPalindomeMustReturnTrueWhenReceivesAPalindromeOfNumbersInAString()
		{
			var result = palindromeChecker.isPalindrome("1234321");
			Assert.True(result);
		}

		[Fact]
		public void isPalindomeMustReturnTrueWhenReceivesAPalindromeOfNumbers()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(1234321);
			Assert.True(result);
			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)));
		}

		[Fact]
		public void isPalindomeMustReturnFalseWhenReceivesAPNonalindromeOfNumbersInAString()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome("91234321");
			Assert.False(result);
			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == true)));
		}

		[Fact]
		public void isPalindomeMustReturnFalseWhenReceivesANonPalindromeOfNumbers()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(91234321);
			Assert.False(result);
			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)));
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeDoubleNumber()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(10.01);
			Assert.True(result);
			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)), Times.Once);
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesANonPalindromeDoubleNumber()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(10.11);
			Assert.False(result);
			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)));
		}


		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeFloatNumberWithSuffix()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(10.01f);
			Assert.True(result);
			
			result = palindromeChecker.isPalindrome(10.01F);
			Assert.True(result);

			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)), Times.Exactly(2));
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeDoubleNumberWithSuffix()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(10.01d);
			Assert.True(result);

			result = palindromeChecker.isPalindrome(10.01D);
			Assert.True(result);

			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)), Times.Exactly(2));
		}

		[Fact]
		public void isPalindromeMustReturnTrueWhenReceivesAPalindromeDecimalNumberWithSuffix()
		{
			var palindromeCheckerMock = new Mock<PalindromeChecker>();
			palindromeCheckerMock.CallBase = true;
			palindromeChecker = palindromeCheckerMock.Object;

			var result = palindromeChecker.isPalindrome(10.01m);
			Assert.True(result);

			result = palindromeChecker.isPalindrome(10.01M);
			Assert.True(result);

			palindromeCheckerMock.Verify(x => x.checkPalindrome(It.IsAny<string>(), It.Is<bool>(y => y == false)), Times.Exactly(2));
		}

		[Fact]
		public void isPalindromeMustReturnFalseWhenReceivesANullValue()
		{
			var result = palindromeChecker.isPalindrome(null);
			Assert.False(result);
		}
	}
}