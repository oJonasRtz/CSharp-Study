using System;

static class Calculator
{
	#region Variables
	private static double n1;
	private static double n2;
	#endregion

	#region Private functions
	private static void SetColour()
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
	}

	private static double ReadNumber(string prompt)
	{
		string? input = null;
		double result;

		do
		{
			SetColour();
			Console.Write($"{prompt}: ");
			Console.ResetColor();
			input = Console.ReadLine();
		} while (string.IsNullOrEmpty(input) || !double.TryParse(input, out result));

		return (result);
	}
	private static double Sum() { return (n1 + n2); }
	private static double Sub() { return (n1 - n2); }
	private static double Div()
	{
		if (n2 == 0)
			throw (new System.Exception("Division by zero is forbiden."));
		return (n1 / n2);
	}
	private static double Mult() { return (n1 * n2); }
	private delegate double Operation();
	private static void ShowResult(string message, Operation op)
	{
		try
		{
			SetColour();
			Console.Write($"{message}: ");
			Console.ResetColor();
			Console.WriteLine($"{op():F2}");
		}
		catch (System.Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	#endregion

	#region Public functions
	public static void GetInput()
	{
		n1 = ReadNumber("Enter the first number");
		n2 = ReadNumber("Enter the second number");
	}

	public static void Calculate()
	{
		Console.WriteLine(new string('-', 40));

		ShowResult("Sum", Sum);
		ShowResult("Sub", Sub);
		ShowResult("Mult", Mult);
		ShowResult("Div", Div);
	}
	#endregion
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
