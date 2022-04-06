﻿/*using System;
class MainClass
{
    public static void Main (string[] args)
    {
        /* Console.WriteLine("Введите данные для сравнения: ");
         string a = Console.ReadLine();
         string b = Console.ReadLine();
         bool c = a == b;
         Console.WriteLine("Результат сравнения: {0}",c);
        
        int a = checked(int.Parse(Console.ReadLine()));
        int b = checked(int.Parse(Console.ReadLine()));
        double x = checked(double.Parse(Console.ReadLine()));
        double y = checked(double.Parse(Console.ReadLine()));
        bool c = (a < b) || (x > y);
        Console.WriteLine(c);
    }
}*/
using System;
class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var text = Console.ReadLine();
            if (text == "stop"){
                break;
            }
            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    continue;
            }
        }

    }
}