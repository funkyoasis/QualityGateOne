using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QualityGate
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public static int IntegerPasser(int[] inputArray)
		{
			List<string> stringList= new List<string> { };
			string newString = "";
			foreach (int num in inputArray)
			{
				
				stringList.Add(Convert.ToString(num));
				
			}
			foreach (string str in stringList)
			{
				newString += str;
			}

			var convertedInt = Convert.ToInt32(newString);
			return convertedInt;
	
		}
	}
}
