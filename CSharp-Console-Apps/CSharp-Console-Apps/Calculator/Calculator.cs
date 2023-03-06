﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Console_Apps.Calculator
{
    internal class Calculator
    {
        public void Main()
        {
            Console.WriteLine(">> | Calculator | <<\n");

            // Intro
            Console.WriteLine("This calculator console app can do: \n");
            

            // The options
            string[] operationsChoices = { "Addition", "Subtraction", "Multiplication", "Division" };
            for (int i = 0; i < operationsChoices.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine($"[ {num} ] {operationsChoices[i]}\n");
            }
            Console.WriteLine("\nPick a basic arithmetic operation:\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nLoading. . .");
            

            if (choice == 1)
            {
                Program.ResetScreen(1200);
                Addition();
            } 
            else if (choice == 2)
            {
                Program.ResetScreen(1200);
                Subtraction();
            }
            else if (choice == 3)
            {
                Program.ResetScreen(1200);
                Multiply();
            }
            else if (choice == 4)
            {
                Program.ResetScreen(1200);
                Division();
            }

        }

        public void Addition()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 1 ] Addition\n");
            Console.WriteLine("How many numbers do you want to add together?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 0;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score += number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " + ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

        }

        public void Subtraction()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 2 ] Subtraction\n");
            Console.WriteLine("How many numbers do you want to subtract from each other?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 0;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score -= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " - ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

        }

        public void Multiply()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 3 ] Multiplication\n");
            Console.WriteLine("How many numbers do you want to multiply together?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 1;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score *= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " × ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

        }

        public void Division()
        {
            Console.WriteLine(">> | Calculator | <<\n");
            Console.WriteLine("[ 4 ] Division\n");
            Console.WriteLine("How many numbers do you want to be divided from each other?");
            int numberLength = Convert.ToInt32(Console.ReadLine());

            // Loop around the number needed
            Console.WriteLine("\n ------------------- \n");
            double score = 1;
            string equation = "";

            for (int i = 1; i <= numberLength; i++)
            {
                Console.WriteLine($"Input no.{i} number needed:");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                score /= number;

                if (i == numberLength)
                {
                    equation += number + " = ";
                }
                else
                {
                    equation += number + " ÷ ";
                }
            }

            // Reveal the answer
            Console.WriteLine(" ------------------- \n");
            equation += score;

            Console.WriteLine("Answer: " + equation);

        }
    }
}
