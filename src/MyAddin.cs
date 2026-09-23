// Program.cs
using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Core test message
            string message = "Hello! Your C# test execution was successful.";
            
            Console.WriteLine(message);
            Console.WriteLine($"Current Timestamp: {DateTime.Now}");
        }
    }
}