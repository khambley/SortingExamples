using System;

namespace SelectionSortExamples
{
	class Program
	{
		static void Main(string[] args)
		{
			CArray nums = new CArray(10);
			nums.Clear();
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				nums.Insert((int)(random.NextDouble() * 100));
			}
			Console.WriteLine("Before sorting: ");
			nums.DisplayElements();
			Console.WriteLine();
			Console.WriteLine("During sorting: ");
			nums.SelectionSortMax();
			Console.WriteLine("After sorting: ");
			nums.DisplayElements();
			nums.Clear();
			Console.WriteLine();
			nums.DisplayElements();
			
		}

	}
}
