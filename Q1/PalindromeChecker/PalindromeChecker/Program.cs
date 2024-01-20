using System.Text.RegularExpressions;

/// <summary>
/// Class to handle and check possible palindrome cases.
/// </summary>
public class PalindromeChecker
{
	/// <summary>
	/// Method to clean a string to be checked as palindrome.
	/// </summary>
	/// <param name="input"></param>
	/// <returns>A string based on input without special characters, mark accent, white spaces and upper letters.</returns>
	private string sanitizePalindrome(string input)
	{
		var sanitiziedInput = Regex.Replace(input, "[A-Z]", upperChar => upperChar.Value.ToLower());
		sanitiziedInput = Regex.Replace(sanitiziedInput, "[&* {},=\\-_().;:'\"/|@#~€$!¡?¿%<>\\\\]", "");

		return sanitiziedInput;
	}

	/// <summary>
	/// Method to check if a string is a palindrome.
	/// This method do not take into account special characters, accent marks, and/or whitespaces 
	/// in a non case sensitive way.
	/// </summary>
	/// <param name="input">The string to be checked as palindrome.</param>
	/// <param name="sanitize">The flag to indicate if the input string need to be sanitized.</param>
	/// <returns>True if the input value is a palindrome, false otherwise</returns>
	public virtual bool checkPalindrome(string input, bool sanitize = true)
	{
		string sanitizedInput = input;

		if(sanitize)
		{
			sanitizedInput = sanitizePalindrome(input);
		}

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

	/// <summary>
	/// Method that check if an object value is a palindrome.
	/// The parameter can be a different primitive type like string, integer or floating decimals.
	/// </summary>
	/// <param name="input">The value to be checked as palindrome.</param>
	/// <returns>True if the input is a palindrome, false otherwise.</returns>
	public virtual bool isPalindrome(object input)
	{
		if (input == null)
			return false;
	
		Type type = input.GetType();

		switch (Type.GetTypeCode(type))
		{
			case TypeCode.String:
				return checkPalindrome((string)input);
			case TypeCode.Int16:
			case TypeCode.Int32:
			case TypeCode.Int64:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				var stringNumber = input.ToString();
				return checkPalindrome(stringNumber, false);
			case TypeCode.Decimal:
			case TypeCode.Double:
			case TypeCode.Single:
				var stringDecimal = input.ToString();
				var stringDecimalWithoutSuffix = Regex.Replace(stringDecimal, "[dDfFmM]", "");
				return checkPalindrome(stringDecimalWithoutSuffix, false);
			default:
				return false;
		}
	}
}


/// <summary>
/// This class tests the PalindromeChecker by reading string values from console but its prepared to handle more primitive input types.
/// </summary>
class Program
{
	static void Main(string[] args)
	{

		Console.WriteLine("Introduce a value to check if its a palindrome");
		
		string input = Console.ReadLine();

		PalindromeChecker palindromeChecker = new PalindromeChecker();
		Console.WriteLine($"{input} is a palindrome? {palindromeChecker.isPalindrome(input)}");
	}
}
