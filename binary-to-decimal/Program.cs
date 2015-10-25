using System;
using System.Collections.Generic;

namespace binarytodecimal
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			// 6 as decimal

			double[] arr = { 1, 1, 0 };

			Console.WriteLine(findDecimal (arr));

		}

		private static double findDecimal(double[] arr) 
		{
			var listOfNums = new List<double>();


			Array.Reverse(arr);

			for (var index = 0; index < arr.Length; index++) {
				if (arr [index] == 1) {
					listOfNums.Add (Math.Pow (2, index));
				}

			}
			
			return getSum(listOfNums);
		}

		private static double getSum(List<double> numberList) 
		{

			double sum = 0;

			for (var index = 0; index < numberList.Count; index++) 
			{
				sum = numberList [index] + sum;

			}

			return sum;

		}

	}
}
