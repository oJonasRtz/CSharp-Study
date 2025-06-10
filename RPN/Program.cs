using System;

public class RPN
{
	#region Private

	#endregion

	#region Public
	int Calculate(in string input)
	{
		
	}
	#endregion
}

class Program
{
	static void Main(string[] args)
	{
		if (args.Length != 1)
			return;
		RPN a;
		a.Calculate(args[0]);
	}
}