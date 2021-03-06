﻿# Requirements
* Following are required to be installed and setup on your desktop.
    * Windows 10 Professional Edition (preferred)
        * I am yet to test this build in Windows 10 Home edition or another alternative operating systems (Linux / Macos) environment.
    * Visual Studio 2019 Community Edition
    * .NET Core 5
    * git
    * PowerShell

# Directories

Following is the screenshot of the root directory for the repository.
![repositoryscreenshot](./media/root-screenshot.jpg)

The *datasrc* folder is where the sample input file is. the *media* folder consists of the screenshot video of how the project can be executed and the output after the execution.

# Project Layout
The *PokerHandSorterConsoleApp* folder is the VS 2019 solution folder which consist of the implementation. Below is the screenshot of the solution folder organisation.

![solution-folder](./media/solution-folders.jpg)

The solution is broken down into Models, Models' extensions, Service layer and it interfaces and the main program console. Rules and logics for the PokerHand is in GameRules folder. 

The implementation is as simple as it can be. Builder design pattern is the only pattern used. The rules were broken into static classes which resides in GameRules folder. 

The Game theme is brought into the implementation as a way to allow the project to support different game rules in future.

There were two test projects introduced to cover tests for the PokerHand rules and logics and for the service layer.

The idea to make Service layer seperated for the console application is to allow for the implementation pattern to support various outputs like web app or web api support.

# Downloading the source code
You can use git to clone from this repository. Alternatively, you can download as a zip package source code from the provided tagged release link:
[https://github.com/vaananart/argenti-cloud-poker-hand-sorter-exercise/releases/tag/1.0](https://github.com/vaananart/argenti-cloud-poker-hand-sorter-exercise/releases/tag/1.0)

# Build Instructions

Two powershell scripts where added to make clean build and to execute the compiled solutions from the root level. They are:
* .\build.ps1
* .\run-sample-input.ps1

Compiled app will be in the *.\PokerHandSorterConsoleApp\output\net5.0*

Alternatively, in the cmd terminal you can go into the solution folder and execute the following command:

```
dotnet clean;dotnet build
```

After that you have copy over the input file (poker-hands.txt). The next section explain the execution instruction.

# Execution Instructions

There is a powershell script named *run-sample-input.ps1* prepared to execute the run command against the compiled app. You can execute this command for the root of the repository.

Alternatively, in cmd terminal, the *output\net5.0* folder location, you have to execute the following command:
```
cat .\poker-hands.txt|.\PokerHandConsole.exe
```
