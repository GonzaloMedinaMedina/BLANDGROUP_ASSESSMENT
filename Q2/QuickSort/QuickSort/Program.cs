public class Program
{
	/// <summary>
	/// Sort the subarray of the array numbers based on a pivot value.
	/// The pivot value is taked from the last subarray position.
	/// The subarray is sorted having the values less than the pivot on the left side 
	/// and the values greater than the pivot on the right side.
	/// </summary>
	/// <param name="numbers">The array that contains the elements</param>
	/// <param name="startIndex">The first index of the subarray to be ordered.</param>
	/// <param name="endIndex">The last index of the subarray to be ordered.</param>
	/// <returns>The next pivot index</returns>
	static int partialSort(float[] numbers, int startIndex, int endIndex)
	{
		float pivot = numbers[endIndex];
		int i = startIndex,
			j = endIndex - 1;

		while (i < j)
		{
			while (numbers[i] < pivot)
			{
				i++;
			}

			while (numbers[j] > pivot)
			{
				j--;
			}

			if (i < j)
			{
				float bigValue = numbers[i];
				numbers[i] = numbers[j];
				numbers[j] = bigValue;
				i++;
			}
		}

		if (numbers[endIndex] < numbers[i])
		{
			float temp = numbers[i];
			numbers[i] = numbers[endIndex];
			numbers[endIndex] = temp;
		}

		return i;
	}

	/// <summary>
	/// Method that performs the QuickSort algorithm on an array of objects.
	/// </summary>
	/// <param name="numbers">The array to be sorted</param>
	/// <param name="startIndex">The first</param>
	/// <param name="endIndex"></param>
	static void quickSort(float[] numbers, int startIndex, int endIndex)
	{
		if (startIndex < endIndex)
		{
			int pivotIndex = partialSort(numbers, startIndex, endIndex);
			quickSort(numbers, startIndex, pivotIndex - 1);
			quickSort(numbers, pivotIndex + 1, endIndex);
		}
	}

	static void Main(string[] args)
	{
		Console.Write("Enter number of elements: ");
		string sizeString = Console.ReadLine();
		int size = int.Parse(String.IsNullOrWhiteSpace(sizeString) ? "-1" : sizeString);

		if (size > 10 || size < 1)
		{
			Console.Write("Enter a size number from 1 to 10");
			Environment.Exit(0);
		}

		float[] numbers = new float[size];

		for (int i = 0; i<size; i++)
		{
			Console.Write("Enter an integer or a decimal with point value: ");
			float value = float.Parse(Console.ReadLine());
			numbers[i] = value;
		}

		float[] sortedNumbers = numbers.ToArray();
		quickSort(sortedNumbers, 0, sortedNumbers.Length - 1);

		Console.Write("\nElements introduced by user: ");
		for (int i = 0; i < size; i++)
		{
			Console.Write(numbers[i] + " ");
		}

		Console.Write("\nSorted elements: ");
		for (int i = 0; i < size; i++)
		{
			Console.Write(sortedNumbers[i] + " ");
		}
	}
}