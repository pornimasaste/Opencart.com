C# Selenium Automation Framework

This project is a Selenium WebDriver automation framework built with C# (.NET).
It follows best practices like Page Object Model (POM), NUnit, and Extent Reports for clean, scalable, and maintainable test automation.

Tech Stack -
•	Language: C#
•	Framework: .NET
•	Automation Tool: Selenium WebDriver
•	Test Framework: NUnit
•	IDE: Visual Studio Code / Visual Studio
•	Reporting: Extent Reports
•	Browser: Google Chrome

Project Structure -

ProjectRoot/
│
├── Dependencies/
│   
│
├── Base/
│   └── BaseTest.cs
│
├── Pages/
│   ├── AddtoCartPage.cs
│   ├
│   └── CheckoutPage.cs
│
├── Reports/
│   └── ExtentReport.html
│── README.md
├── UnitTests1/
│   └── CheckoutFlowTests.cs
│

Prerequisites -

-NET SDK

-dotnet :17.14.1

-Google Chrome : Version 144.0.7559.133 (Official Build) (64-bit)

-Visual Studio : 2026

-NuGet Package Manager

Required NuGet Packages -
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package ExtentReports

How to Run Tests -

From the project root directory:
-Bash

-dotnet test

This will:

-Launch Chrome

-Execute Selenium tests

-Generate Extent HTML report

Extent Report -

After execution, the report is generated at:

bin/Debug/netX.X/Reports/ExtentReport.html


Open it in any browser to view:

-Test status (Pass / Fail)

-Logs


