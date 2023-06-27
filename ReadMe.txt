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
To install the DateHelper library, you have two options:

### Option 1: Using NuGet Package Manager
1. Open the NuGet Package Manager Console in Visual Studio.
2. Run the following command to install the DateHelper library:
   ```
   Install-Package DateHelperLibrary
   ```
### Option 2: Manual Installation
1. Download the DateHelper library package from the GitHub repository.
2. Extract the contents of the package to a directory of your choice.

## Adding the Library to Your Project
To use the DateHelper library in your C# project, follow these steps:

1. Open your project in Visual Studio or any other C# development environment.
2. Right-click on the References node in your project's Solution Explorer.
3. Select "Add Reference" from the context menu.
4. In the Reference Manager window, click the "Browse" button.
5. Navigate to the directory where you extracted the DateHelper library (if you installed it manually) or search for "DateHelperLibrary" (if you installed it using NuGet).
6. Select the DateHelperLibrary.dll file and click the "Add" button.
7. Click the "OK" button to close the Reference Manager window.

## Usage
To use the DateHelper library in your C# code, follow these steps:

1. Add the following using statement at the top of your C# file:
```
using DateHelperLibrary;
```
2. Create an instance of the DateHelper class:
```
DateHelper dateHelper = new DateHelper();
```
3. You can now call the various methods provided by the DateHelper class. Here are some examples:
```
DateTime currentDateTime = dateHelper.GetCurrentDateTime();

DayOfWeek dayOfWeek = dateHelper.GetDayOfWeek(2022-05-20);

bool isLeapYear = dateHelper.IsLeapYear(2023);

DateTime futureDate = dateHelper.AddDays(2022-05-20, 5);

int age = dateHelper.CalculateAge(new DateTime(1990, 5, 15));

string formattedDateTime = dateHelper.FormatDateTime(DateTime.Now, "yyyy-MM-dd");

TimeSpan timeDifference = dateHelper.GetTimeDifference(DateTime.Now, DateTime.Now.AddHours(2));
```

## Collaborators
- Apit - `GetCurrentDateTime`
- Arar - `CalculateAge`
- Senening - `FormatDateTime`
- Sumodobila - `GetTimeDifference`
- Pepito - `GetDayOfWeek`
- Palen - `AddDays`
- Procorato - `IsLeapYear`