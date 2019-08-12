using System;

namespace Arrays2
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Edge Tech Academy";
			Console.WriteLine("My name is '" + name + "' and it is " + name.Length + " characters long");

			bool hasTech = name.Contains("Tech");
			Console.WriteLine("Does my name contain Tech? " + (hasTech ? "Why yes is does!" : "No Tech :-("));

			bool isBoring = name.Contains("boring stuff");
			Console.WriteLine("Does my name contain 'boring stuff'? " + (isBoring ? "Not So!" : "All exciting stuff"));

			bool ending = name.EndsWith("h Academy");
			Console.WriteLine("Does my name end with 'h Academy'? " + (ending ? "yup" : "nope"));

			bool starting = name.StartsWith("Edge");
			Console.WriteLine("Does my name start with 'Edge'? " + (starting ? "yup" : "nope"));

			bool doTheyMatch = name.Equals("EDGE tech ACADemy");
			Console.WriteLine("Are they equal? " + (doTheyMatch ? "yup" : "nope"));

			bool ignoreCase = name.Equals("EDGE tech ACADemy", StringComparison.CurrentCultureIgnoreCase);
			Console.WriteLine("Can I compare and ignore case? " + (ignoreCase ? "yup" : "nope"));

			Console.ReadLine();
		}
	}
}
