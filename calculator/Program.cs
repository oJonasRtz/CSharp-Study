using System;

static class Calculator
{
	private static double n1;
	private static double n2;
	
	private static void	SetColour() {Console.ForegroundColor = ConsoleColor.Yellow;}
	public static void GetInput()
	{
		string? input = null;

		do
		{
			SetColour();
			Console.Write("Enter first number: ");
			Console.ResetColor();
			input = Console.ReadLine();
		} while (string.IsNullOrEmpty(input) || !double.TryParse(input, out n1));

		do
		{
			SetColour();
			Console.Write("Enter second number: ");
			Console.ResetColor();
			input = Console.ReadLine();
		} while (string.IsNullOrEmpty(input) || !double.TryParse(input, out n2));
	}

	private static double Sum() { return (n1 + n2); }
	private static double Sub() { return (n1 - n2); }
	private static double Div() { return (n1 / n2); }
	private static double Mult() { return (n1 * n2); }

	private delegate double Operation();
	private static void ShowResult(string message, Operation op)
	{
		SetColour();
		Console.Write($"{message} ");
		Console.ResetColor();
		Console.WriteLine($"{op():F2}");
	}
	public static void Calculate()
	{
		Console.WriteLine(new string('-', 40));

		ShowResult("Sum", Sum);
		ShowResult("Sub", Sub);
		ShowResult("Mult", Mult);
		if (n2 == 0)
		{
			SetColour();
			Console.Write("Div: ");
			Console.ResetColor();
			Console.WriteLine("Division by zero is forbiden.");
		} else
			ShowResult("Div", Div);
	}
}

class MyCalculator
{
	static void Main()
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("\t\tCalculator");
		Console.ResetColor();
		Console.WriteLine(new string('-', 40));
		Calculator.GetInput();
		Calculator.Calculate();
	}
}
