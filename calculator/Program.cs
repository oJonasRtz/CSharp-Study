using System;

static class Calculator
{
	private static int n1;
	private static int n2;
	
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
		} while (string.IsNullOrEmpty(input) || !int.TryParse(input, out n1));

		do
		{
			SetColour();
			Console.Write("Enter second number: ");
			Console.ResetColor();
			input = Console.ReadLine();
		} while (string.IsNullOrEmpty(input) || !int.TryParse(input, out n2));
	}

	private static double Sum() { return (n1 + n2); }
	private static double Sub() { return (n1 - n2); }
	private static double Div() { return (n1 / n2); }
	private static double Mult() { return (n1 * n2); }

	public static void Calculate()
	{
		Console.WriteLine(new string('-', 40));

		SetColour();
		Console.Write("Sum: ");
		Console.ResetColor();
		Console.WriteLine($"{Sum()}:F2");

		SetColour();
		Console.Write("Sub: ");
		Console.ResetColor();
		Console.WriteLine($"{Sub()}:F2");

		SetColour();
		Console.Write("Div: ");
		Console.ResetColor();
		if (n2 == 0)
			Console.WriteLine("Division by zero is forbiden.");
		else
			Console.WriteLine($"{Div()}:F2");

		SetColour();
		Console.Write("Mult: ");
		Console.ResetColor();
		Console.WriteLine($"{Mult()}:F2");
	}
}

class Program
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
