<h3 align="center">💻 Some dotnet commands</h3>

---

`dotnet <command> -n Name`
- `-n` Add a name to the command

`dotnet new console -n ProjectName`
- Create a new project

`dotnet run`
- Run the project without params

`dotnet run -- args...`
- Run with args

`dotnet new classlib`
- Create a class library

`dotnet build`
- Compile the project
- Output goes to `~/Project/bin/Debug/netX.X/Project`

`dotnet add reference MyClassLib/MyClassLib.csproj`
- Link my project to a classlib or another project
```bash
	// It works like .h/.hpp files, so include the lib with the "using" keyword

	dotnet new classlib -n MyLib
	dotnet new console -n MyProject
	dotnet add reference MyLib/MyLib.csproj

	//in my project file (.cs)
		using MyLib
```

<h3 align="center">My C# annotations</h3>

---

`Console.WriteLine($"{Sub():F2}");` 
- `F2` Indicates the number of decimal places to be seen  
- It can be used like `F1`-1 place | `F3`-3 places

`Static classes`
- Classes that can't be instantiated

`Public classes`  
- If I declare `public class Hi` its accessible in any other Projects
- If I declare `class Hi` its only accessible in the project it was created

`out`  
- It's a reference to a variable
- When calling `out` I'm required to assign a value to the variable in the function
- Use: `Function(out myVar);` or `void Function(out int number){}`
- It doesn't need to be initialized before being used as a param

`ref`
- Works similarly to `out`
- I'm not required to assign a value to the variable
- It must be initialized before being used as a param
