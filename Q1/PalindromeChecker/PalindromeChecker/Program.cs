using System.Text.RegularExpressions;

public class PalindromeChecker
{
	/// <summary>
	/// Method to clean a string to be checked as palindrome.
	/// </summary>
	/// <param name="input"></param>
	/// <returns>A string based on input without special characters, mark accent, white spaces and upper letters.</returns>
	private static string sanitizePalindrome(string input)
	{
		var sanitiziedInput = Regex.Replace(input, "[A-Z]", upperChar => upperChar.Value.ToLower());
		sanitiziedInput = Regex.Replace(sanitiziedInput, " ", "");

		return sanitiziedInput;
	}

	/// <summary>
	/// Method to check if a string is a palindrome.
	/// This method do not take into account special characters, accent marks, and/or whitespaces 
	/// in a non case sensitive way.
	/// </summary>
	/// <param name="input">The string to be checked as palindrome.</param>
	/// <returns>True if the input value is a palindrome, false otherwise</returns>
	public static bool isPalindrome(string input)
	{
		string sanitizedInput = sanitizePalindrome(input);

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
