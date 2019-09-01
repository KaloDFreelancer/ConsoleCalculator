using System;
using System.Linq;

namespace CalculatorLogic
{
    public class Calculator
    {
        public ConsoleColor color;
        public void Color(string colorName)
        {
            string[] result = Enum.GetNames(typeof(ConsoleColor));
            colorName= StringExtensions.FirstCharToUpper(colorName);
            if (result.Contains(colorName))
            {
               Enum.TryParse(colorName, out ConsoleColor consoleColor);
                this.color = consoleColor;
            }
        }
        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

    }
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}
