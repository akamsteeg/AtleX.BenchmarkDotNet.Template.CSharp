# BenchmarkDotNet.Template.CSharp

BenchmarkDotNet.Template.CSharp is a template for `dotnet new` to create a BenchmarkDotNet 
console application in C#. It allows you to easily and quickly create a small application 
to run some benchmarks.

## Installation/update

On the console, run the following command to install or update the template:

```powershell
dotnet new -i BenchmarkDotNet.Template.CSharp
```

## Using the template

Execute the following command to create a new console application to run benchmarks:

```powershell
dotnet new bdncsharp
```

You can also specify a name for the application:

```powershell
dotnet new bdncsharp --name TestBench
```

After creating the new console application, you can edit Program.cs to write the benchmarks you want to run.

## Running the benchmarks

To run the benchmarks, execute the following command in the app's directory to run the benchmarks:

```powershell
dotnet run --configuration release
```
