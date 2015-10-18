using System;
using System.Collections.Generic;

// Reverse a stack and put the reversed value back in the same stack. You can use only one other stack and a temp variable.
namespace kalacademystack8
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var stack = new Stack<int>();
			stack.Push (1);
			stack.Push (2);
			stack.Push (3);

			Console.WriteLine ("1st stack in the beginning...");

			foreach (int i in stack) Console.WriteLine(i);

			var otherStack = new Stack<int> ();

		
			int rounds = stack.Count - 1;

			while (rounds > 0) {
				int temp = stack.Pop ();

				for (var i = 0; i < rounds; i++) {
					otherStack.Push(stack.Pop ());
				}

				otherStack.Push (temp);

				int count = stack.Count;

				// push anything remaining from stack into otherStack
				if (count > 0) {

					for (var num = 0; num < count; num++) {
						otherStack.Push (stack.Pop ());
					}

				}

				int otherCount = otherStack.Count;

				// push elements from otherStack into the original stack
				for (var i = 0; i < otherCount; i++) {
					stack.Push (otherStack.Pop ());
				}
						
				rounds--;

			}


			Console.WriteLine ("1st stack in the end...");

			foreach (int i in stack) Console.WriteLine (i);


		}
	}
}
