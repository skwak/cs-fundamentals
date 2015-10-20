using System;
using System.Collections.Generic;

namespace kalacademystack7
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			//7. Evaluate an expression given only single digits and only 2 operators * and +.

			string expression = "2 + 5 * 6 + 1";

			string[] chars = expression.Split (' ');

			Console.WriteLine (chars);

			foreach(string s in chars) Console.WriteLine(s);

			var stack = new Stack<int> ();

		}
	}
}
