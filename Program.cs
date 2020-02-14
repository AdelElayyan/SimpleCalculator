using NCalc;
using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 0.0, secondNumber = 0.0;
            double result=0.0;
            char Operator;
            char x = ' ';


            do
            {
                
                firstNumber = Convert.ToDouble( Console.ReadLine());
                Operator = Convert.ToChar(Console.ReadLine());
                if (Operator != '=')
                {
                    secondNumber = Convert.ToDouble( Console.ReadLine());
                    switch (Operator)
                    {
                        case '+':
                            result = firstNumber + secondNumber;
                            break;

                        case '-':
                            result = firstNumber - secondNumber;
                            break;

                        case '*':
                            result = firstNumber * secondNumber;
                            break;

                        case '/':
                            result = firstNumber / secondNumber;
                            break;

                        default:
                            break;

                    }
                }
                else
                {
                    switch (x)
                    {
                        case '+':
                            result = result + firstNumber;
                            break;

                        case '-':
                            result = result - firstNumber;
                            break;

                        case '*':
                            result = result * firstNumber;
                            break;

                        case '/':
                            result = result / firstNumber;
                            break;

                        default:
                            break;

                    }
                }
                if (Operator == '=')
                    break;
                Operator = Convert.ToChar(Console.ReadLine());
                x = Operator;
            } while (Operator != '=');

            Console.WriteLine(result);
        }
    }
}
