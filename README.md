<h3 align="center">💻 Some dotnet commands</h3>

---

`dotnet <command> -n Name`
- "-n" Add a name to the command

`dotnet new console -n ProjectName`
- Create a new project

`dotnet run`
- Run the project-with no params

`dotnet run -- args...`
- Run with args

`dotnet new classlib`
- Create a class library

`dotnet build`
- Compile the project
- Output goes to ~/Project/bin/Debug/netX.X/Project

`dotnet add reference MyClassLib/MyClassLib.csproj`
- Link my project to a classlib or another project
```bash
	// It works like .h/.hpp files so include lib with "using"

	dotnet new classlib -n MyLib
	dotnet new console -n MyProject

	in my project folder
		using MyLib

```

<h3 align="center">C# Coments</h3>

---

`Console.WriteLine($"{Sub():F2}");` 
- "F2" Indicate the number of decimal places to be seen  
- It can be used like "F1"-1 place | "F3"-3 places

`Static classes`
- Classes that can't be instanciated

`Public classes`  
- If I declare `public class Hi` its accessable in any other Projects
- If I declare `class Hi` its only accessable in the project it was created
