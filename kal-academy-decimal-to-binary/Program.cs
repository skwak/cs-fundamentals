using System;
using System.Collections.Generic;

class MainClass
{


	public static void Main (string[] args)
	{

		// decimal number to binary conversion

		int number = 6;

		var stack = new Stack<int> ();
		addToStack (stack, number);


		foreach (int i in stack) Console.WriteLine (i);

	}


	private static void addToStack (Stack<int> growingStack, int num)
	{

		if (num > 0) {
			if (num % 2 == 0) {
				growingStack.Push (0);
			} 

			else {
				growingStack.Push (1);
			}

			addToStack(growingStack, num/2);
		}
			
	}


}

