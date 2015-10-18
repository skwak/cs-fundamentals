using System;

//			1.	Find the element that appears once in a sorted array where all other elements appear twice one after another. Find that element in 0(logn) complexity.
//			Input:   arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8}
//				Output:  4    

namespace kalacademyarray1
{
	class MainClass
	{
		public static void Main (string[] args)
		{  
		
			int[] exampleArray = { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };

			int lonelyNum = findLonelyNumber (exampleArray, 0, exampleArray.Length - 1);

			Console.WriteLine (lonelyNum);
		}

		private static int findLonelyNumber (int[] arr, int start, int end)
		{
			int midIndex = (start + end / 2);

			if (midIndex % 2 != 0) {
				if (arr [midIndex] == arr [midIndex - 1]) {
					return findLonelyNumber (arr, arr [midIndex + 1], arr.Length - 1);	
				} else {
					int unique = arr [midIndex - 1];
					return unique;
				}
			} else if (midIndex % 2 == 0) {
				if (arr [midIndex] == arr [midIndex - 1]) {
					return findLonelyNumber (arr, midIndex - 2, midIndex);
				} else {
					int unique = arr [midIndex];
					return unique;
				}
			} else {
				int unique = arr [start];
				return unique;
			}
				

		}
	}
}
