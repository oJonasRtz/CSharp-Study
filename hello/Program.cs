using System;

class Hello
{
	static void DrawText(string text, string? text2 = null)
	{
		if (!string.IsNullOrEmpty(text2))
			Console.WriteLine($"My first text: {text}\nMy second text: {text2}");
		else
			Console.WriteLine($"I got only: {text}");
	}
	static void Main()
	{
		DrawText("Hello world", "I'm learning c#");
		DrawText("Say hi", null);
	}
}


