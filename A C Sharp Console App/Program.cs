using System;

namespace A_C_Sharp_Console_App
{
	class Program
	{
		static void Main(string[] args)
		{
			double width, height, woodLength, glassArea;
			string widthString, heightString;

			string firstName, lastName;
			Console.WriteLine("Enter your first name: ");
			firstName = Console.ReadLine();

			Console.WriteLine("Enter your first name: ");
			lastName = Console.ReadLine();

			Console.WriteLine("Enter the length of the wood: ");
			widthString = Console.ReadLine();
			width = double.Parse(widthString);

			Console.WriteLine("Enter the length of the glass: ");
			heightString = Console.ReadLine();
			height = double.Parse(heightString);

			woodLength = 2 * (width + height) * 3.25;
			glassArea = 2 * (width * height);

			Console.WriteLine("The length of the wood is " + woodLength + " feet");
			Console.WriteLine("The area of the glass is " + glassArea + " square metres");
		}
	}
}
