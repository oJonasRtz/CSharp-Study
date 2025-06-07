using System;

class Hello
{
	static int Main(string[] argv)
	{
		if (argv.Length != 1)
			Console.WriteLine("Hello world");
		else
			Console.WriteLine($"Hello {argv[0]}");
		return (0);
	}
}
