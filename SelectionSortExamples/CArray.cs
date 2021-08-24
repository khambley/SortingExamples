using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortExamples
{
	public class CArray
	{
		private int[] array;
		private int upper;
		private int numElements;

		public CArray(int size)
		{
			array = new int[size];
			upper = size - 1;
			numElements = 0;
		}
		public void Insert(int item)
		{
			array[numElements] = item;
			numElements++;
		}
		public void DisplayElements()
		{
			for(int i = 0; i <= upper; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
		public void Clear()
		{
			for(int i = 0; i <= upper; i++)
			{
				array[i] = 0;
				numElements = 0;
			}
		}
		public void SelectionSort()
		{
			int temp, smallestPosition;

			//outer loop swaps smallest element into correct position
			for(int i = 0; i <= upper; i++)
			{
				// This loop runs first, inner loop finds smallest element
				// position, then jumps out into outer loop, iterates i,
				// then and runs innner loop, finds
				// next smallest element position...and so on.
				smallestPosition = i;

				for (int j = i + 1; j <= upper; j++)
				{
					if(array[j] < array[smallestPosition])
					{
						smallestPosition = j;
					}
				}

				this.DisplayElements();

				Console.WriteLine();

				//puts smallest element value in temp holding variable
				temp = array[smallestPosition];

				//then puts smallest element value in position i in array.
				array[smallestPosition] = array[i];

				//puts smallest element value in final position.
				array[i] = temp; 
			}
		}
		public void SelectionSortDescending()
		{
			int temp, maximumPosition;

			//outer loop starts at beginning of array
			//and swaps largest element into leftmost position
			for (int i = 0; i <= upper; i++)
			{
				//Inner loop runs first, inner loop finds
				//largest element position
				maximumPosition = i;
				for (int j = i + 1; j <= upper; j++)
				{
					if (array[j] > array[maximumPosition])
					{
						maximumPosition = j;
					}
				}
				this.DisplayElements();

				Console.WriteLine();

				temp = array[maximumPosition];

				array[maximumPosition] = array[i];

				array[i] = temp;
			}
		}
		public void SelectionSortMax()
		{
			int temp, maximumPosition;
			//outer loop starts at end of array
			//and swaps largest element into rightmost position
			for (int i = upper; i >= 0; i--)
			{
				//This loop runs first, inner loop finds
				//largest element position
				maximumPosition = i;
				for (int j = i - 1; j >= 0; j--)
				{
					if (array[j] > array[maximumPosition])
					{
						maximumPosition = j;
					}
				}
				this.DisplayElements();

				Console.WriteLine();

				temp = array[maximumPosition];

				array[maximumPosition] = array[i];

				array[i] = temp;
			}
		}
	}
}
