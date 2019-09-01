using System;
using System.Linq;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please select your preferred language (English or Bulgarian): ");
            var languageSet = Console.ReadLine().ToLower();
            var resultEnums = Enum.GetNames(typeof(Languages));
            languageSet = StringExtensions.FirstCharToUpper(languageSet);
            var result = String.Empty;
            var firstOperand = String.Empty;
            var secondOperand = String.Empty;
            var colorOfConsole = String.Empty;

            if (resultEnums.Contains(languageSet))
            {
                if (languageSet == "Bulgarian")
                {
                    Console.Write("Напишете желаното действие (събиране, изваждане, умножение, деление): ... ");
                    result = Console.ReadLine();

                    Console.Write("Попълнете първото число: ");
                    firstOperand = Console.ReadLine();

                    Console.Write("Сега, моля попълнете второто число: ");
                    secondOperand = Console.ReadLine();

                    Console.Write("Сега, моля въведете желания цвят от вас, по който да ви се покаже конзолата (Черен, Тъмносин, Тъмнозелен, Циан, Тъмночервен, Пурпурен, Тъмножълт, Сив, Тъмносив, Син, Зелен, Червен, Жълт, Бял): ");
                    colorOfConsole = Console.ReadLine().ToLower();
                    switch (colorOfConsole)
                    {
                        case "черен":
                            colorOfConsole = "Black";
                            break;
                        case "тъмносин":
                            colorOfConsole = "DarkBlue";
                            break;
                        case "тъмнозелен":
                            colorOfConsole = "DarkGreen";
                            break;
                        case "циан":
                            colorOfConsole = "Cyan";
                            break;
                        case "тъмночервен":
                            colorOfConsole = "DarkRed";
                            break;
                        case "пурпурен":
                            colorOfConsole = "Magenta";
                            break;
                        case "тъмножълт":
                            colorOfConsole = "DarkYellow";
                            break;
                        case "сив":
                            colorOfConsole = "Gray";
                            break;
                        case "тъмносив":
                            colorOfConsole = "DarkGray";
                            break;
                        case "син":
                            colorOfConsole = "Blue";
                            break;
                        case "зелен":
                            colorOfConsole = "Green";
                            break;
                        case "червен":
                            colorOfConsole = "Red";
                            break;
                        case "жълт":
                            colorOfConsole = "Yellow";
                            break;
                        case "бял":
                            colorOfConsole = "White";
                            break;
                    }
                }
                else {
                    Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
                    result = Console.ReadLine();

                    Console.Write("Please type the first operand: ");
                    firstOperand = Console.ReadLine();

                    Console.Write("Now, Please type the second operand: ");
                    secondOperand = Console.ReadLine();

                    Console.Write("Now, Please type the desired color of the results (Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White): ");
                    colorOfConsole = Console.ReadLine();
                }
            }
            var calculator = new Calculator();



            if (result == "sum" || result == "събиране")
            {
                calculator.Color(colorOfConsole.ToLower());
                calculator.Sum(Convert.ToDouble(firstOperand), Convert.ToDouble(secondOperand));
            }
            else
            {
                if (result == "subtract" || result == "изваждане")
                {
                    calculator.Color(colorOfConsole.ToLower());
                    calculator.Subtract(Convert.ToDouble(firstOperand), Convert.ToDouble(secondOperand));
                }
                else
                {
                    if (result == "multiply" || result == "умножение")
                    {
                        calculator.Color(colorOfConsole.ToLower());
                        calculator.Multiply(Convert.ToDouble(firstOperand), Convert.ToDouble(secondOperand));
                    }
                    else
                    {
                        if (result == "divide" || result == "деление")
                        {
                            calculator.Color(colorOfConsole.ToLower());
                            calculator.Divide(Convert.ToDouble(firstOperand), Convert.ToDouble(secondOperand));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
