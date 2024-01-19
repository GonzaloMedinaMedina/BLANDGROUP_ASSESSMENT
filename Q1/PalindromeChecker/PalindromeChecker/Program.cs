using System.Text.RegularExpressions;

public class PalindromeChecker
{
	public static bool isPalindrome(string input)
	{
		string sanitizedInput = Regex.Replace(input, "[A-Z]", upperChar => upperChar.Value.ToLower());

		int backwardIndex = sanitizedInput.Length - 1;

		for (int forwardIndex = 0; forwardIndex < sanitizedInput.Length; forwardIndex++)
		{
			if (sanitizedInput[forwardIndex] != sanitizedInput[backwardIndex])
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
