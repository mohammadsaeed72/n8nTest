using System;

// Demonstrates string interpolation in C# 6/7+ using top-level statements (works with .NET 6+ as well).
string userName = "MSaeedP7";
int score = 92;
DateTime now = DateTime.Now;

// Basic interpolation
string greet = $"Hello, {userName}!";

// Interpolated with formatting for values
string details = $"User: {userName}, Score: {score}, Date: {now:yyyy-MM-dd HH:mm:ss}";

// Verbatim interpolated string (multi-line)
string multiLine = $@"Dear {userName},
Thank you for trying string interpolation in C#.
Best regards,
The Team";

// Alignment and numeric formatting in interpolation
string report = $"Name: {userName,-12} | Score: {score,6} | Date: {now:yyyy-MM-dd}");

// Escaping braces inside an interpolated string
string literalBrace = $"This is a literal brace: {{ and }}";

// Old-style concatenation for comparison
string oldWay = "Hello, " + userName + "!";

// Inline conditional expressions in interpolation
string status = $"Status: {(score >= 90 ? \"Excellent\" : \"Needs Improvement\")}";

// Null-coalescing in interpolation
string? maybeName = null;
string nullAware = $"Name: {maybeName ?? \"Unknown\"}";

Console.WriteLine(greet);
Console.WriteLine(details);
Console.WriteLine(multiLine);
Console.WriteLine(report);
Console.WriteLine(literalBrace);
Console.WriteLine("Old way: " + oldWay);
Console.WriteLine(status);
Console.WriteLine(nullAware);
