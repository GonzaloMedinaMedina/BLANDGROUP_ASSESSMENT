public class PalindromeChecker
{
	public static bool isPalindrome(string input)
	{
		int backwardIndex = input.Length - 1;

		for (int forwardIndex = 0; forwardIndex < input.Length; forwardIndex++)
		{
			if (input[forwardIndex] != input[backwardIndex])
			{
				return false;
			}
			backwardIndex--;
		}

		return true;
	}
}

class Program
{
	static void Main(string[] args)
	{
		String test = "deleveled";
		Console.WriteLine("is palindrome: " + PalindromeChecker.isPalindrome(test));
	}
}
