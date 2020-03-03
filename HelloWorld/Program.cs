﻿using System;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    class Program : Calculations
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" __________");
            Console.WriteLine("| ________ |");
            Console.WriteLine("||12345678||");
            Console.WriteLine("||________||");
            Console.WriteLine("|[M|#|C][-]|");
            Console.WriteLine("|[7|8|9][+]|");
            Console.WriteLine("|[4|5|6][x]|");
            Console.WriteLine("|[1|2|3][%]|");
            Console.WriteLine("|[.|O|:][=]|");
            Console.WriteLine("|__________|");
            Console.WriteLine("");

            Console.WriteLine("Hello " + Environment.UserName + "! Welcome to my calculator app");

            double num1 = GetNumber("What is your first number?");
            double num2 = GetNumber("What is your second number?");
            double sum = AskForOperation(num1, num2);

            

            Console.WriteLine();

            Console.WriteLine("The sum is: " + sum);
        }

        public static double AskForOperation(double num1, double num2)
        {
            double sum = 0;
            Console.WriteLine("Choose your operation: * / + - ");

            string operation = Console.ReadLine();
            sum = CheckOperation(operation, num1, num2);
            return sum;
        }

        public static double CheckOperation(string operationString, double num1, double num2)
        {
            double sum = 0;
            if(operationString == "*")
            {
                sum = Multiply(num1, num2);
            } else if (operationString == "/")
            {
                sum = Divide(num1, num2);
            }  else if (operationString == "+")
            {
                sum = Add(num1, num2);
            } else if (operationString == "-")
            {
                sum = Subtract(num1, num2);
            } else
            {
                Console.WriteLine("That is not an operation! :( Try again");
                return AskForOperation(num1, num2);
            }
            return sum;

        }

        public static double GetNumber(string message)
        {
            double intNum;
            string num;
            bool canConvert;

            Console.WriteLine(message);
            num = Console.ReadLine();
            
            canConvert = double.TryParse(num, out intNum);

            if (canConvert != true)
            {
                Console.WriteLine("That isn't a number :(");
                return GetNumber("Try again, what's your number?");
            }
            else
            {
                return intNum;
            }
        }
    }
}