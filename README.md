# DateHelper Library Setup and Installation
The DateHelper library provides various methods to perform date and time operations in C#. This guide will walk you through the setup and installation process of the library.

## Features

The DateHelper library offers the following features:

- `GetCurrentDateTime`: Get the current date and time.
- `GetDayOfWeek`: Get the day of the week for a given date.
- `IsLeapYear`: Check if a given year is a leap year.
- `AddDays`: Add a specified number of days to a given date.
- `CalculateAge`: Calculate the age based on a given birthdate.
- `FormatDateTime`: Format a date and time according to a specified format.
- `GetTimeDifference`: Calculate the time difference between two dates or times.

## Prerequisites
Before you begin, ensure that you have the following prerequisites installed on your system:
- Microsoft .NET Framework (version 4.5 or later) or .NET Core (version 2.0 or later) installed.

## Installation
1. Download the **DateHelperLibrary** file from the GitHub repository.
2. Extract the contents of the file to a directory of your choice.

## Adding the Library to Your Project
To use the DateHelper library in your C# project, follow these steps:

1. Open your project in Visual Studio or any other C# development environment.
2. Right-click on the References node in your project's Solution Explorer.
3. Select "Add Reference" from the context menu.
4. In the Reference Manager window, click the "Browse" button.
5. Navigate to the directory where you extracted the DateHelperLibrary.
6. Select the `DateHelperLibrary.dll` file and click the "Add" button.
7. Click the "OK" button to close the Reference Manager window.
8. 

## Usage
To use the DateHelper library in your C# code, follow these steps:

1. Add the following using statement at the top of your C# file:
```
using DateHelperLibrary;
```
2. Create an instance of the DateHelper class:
```
DateHelperClass dateHelperClass = new DateHelperClass();
```
3. You can now call the various methods provided by the DateHelper class. Here are some examples:
```
DateTime currentDateTime = dateHelper.GetCurrentDateTime();
Console.WriteLine("Current date and time: " + currentDateTime);
```
```
Console.WriteLine("Enter a date (YYYY-MM-DD):");
DateTime date = DateTime.Parse(Console.ReadLine());
DayOfWeek dayOfWeek = dateHelper.GetDayOfWeek(date);
Console.WriteLine("Day of the week: " + dayOfWeek);
```
```
Console.WriteLine("Enter a year:");
int year = int.Parse(Console.ReadLine());
bool isLeapYear = dateHelper.IsLeapYear(year);
Console.WriteLine(year + " is a leap year: " + isLeapYear);
```
```
Console.WriteLine("Enter a date (YYYY-MM-DD):");
DateTime startDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of days to add:");
int daysToAdd = int.Parse(Console.ReadLine());
DateTime newDate = dateHelper.AddDays(startDate, daysToAdd);
Console.WriteLine("New date: " + newDate);
```
```
Console.WriteLine("Enter your birthdate (YYYY-MM-DD):");
DateTime birthdate = DateTime.Parse(Console.ReadLine());
int age = dateHelper.CalculateAge(birthdate);
Console.WriteLine("Your age is: " + age);
```
```
Console.WriteLine("Enter a date and time (YYYY-MM-DD HH:MM:SS):");
DateTime dateTime = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the format (e.g., MM/dd/yyyy HH:mm:ss):");
string format = Console.ReadLine();
string formattedDateTime = dateHelper.FormatDateTime(dateTime, format);
Console.WriteLine("Formatted date and time: " + formattedDateTime);
```
```
Console.WriteLine("Enter the start date and time (YYYY-MM-DD HH:MM:SS):");
DateTime startDateTime = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the end date and time (YYYY-MM-DD HH:MM:SS):");
DateTime endDateTime = DateTime.Parse(Console.ReadLine());
TimeSpan timeDifference = dateHelper.GetTimeDifference(startDateTime, endDateTime);
Console.WriteLine("Time difference: " + timeDifference);
```

## Collaborators
- Apit - `GetCurrentDateTime`
- Arar - `CalculateAge`
- Senening - `FormatDateTime`
- Sumodobila - `GetTimeDifference`
- Pepito - `GetDayOfWeek`
- Palen - `AddDays`
- Procorato - `IsLeapYear`
