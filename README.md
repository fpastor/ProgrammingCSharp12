# Programming C# 12 Exercises

Repository for exercises and experiments while working through _Programming C# 12_.

## Requirements

- .NET SDK 10.0 or newer
- PowerShell, Windows Terminal, or another shell capable of running `dotnet`

Check your SDK installation with:

```powershell
dotnet --version
```

## Project structure

```text
ProgrammingCSharp12
  Chapter01
    HelloWorld
    Averages
      Averages
      Averages.Tests
```

## Chapter 1

### HelloWorld

Basic console application

### Averages

Console application that calculates the arithmetic mean of the numbers passed as command-line arguments.

```powershell
dotnet run --project .\Chapter01\Averages\Averages -- 1 2 3 4 5
```
