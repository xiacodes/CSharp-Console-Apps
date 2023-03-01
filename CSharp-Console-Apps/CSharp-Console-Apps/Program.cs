﻿using System.Threading;
using CSharp_Console_Apps.HelloWorld;

class Program
{

    string[] programs = { "HelloWorld", "Calculator", "TemperatureConverter", "InterestCalculator", "GradeCalculator", "ArraySumCalculator" };

    // #The Different Class Objects
    HelloWorld hw = new HelloWorld();

    static void Main(string[] args)
    {
        MainMenu();
    }

    private static void MainMenu()
    {
        // #The Different Class Objects
        HelloWorld hw = new HelloWorld();

        IntroductionPart();

        bool continueLoop = true;

        while (continueLoop)
        {
            Console.WriteLine("\nPick a program option:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > 6)
            {
                Console.WriteLine("\nPlease pick a number from the list above.");
                ResetScreen(1500);
                MainMenu();
                return;
            }
            else if (choice == 1){
                Console.WriteLine("\nHello!");
                continueLoop = false;
            }

            switch (choice)
            {
                case 1:
                    ResetScreen(1200);
                    hw.Main();
                    break;
            }
        }






    }

    private static void ResetScreen(int seconds)
    {
        Thread.Sleep(seconds);
        Console.Clear();
    }

    private static void IntroductionPart()
    {
        Console.WriteLine(">> | MAIN MENU | <<\n");
        Console.WriteLine("Hello and welcome to XiaCodes' C# Console Applications Collection!");
        Console.WriteLine("Here are the available programs: \n");

        string[] programs = { "HelloWorld", "Calculator", "TemperatureConverter", "InterestCalculator", "GradeCalculator", "ArraySumCalculator" };
        for (int i = 0; i < programs.Length; i++)
        {
            int num = i + 1;
            Console.WriteLine($"[ {num} ] {programs[i]}\n");
        }
    }
}