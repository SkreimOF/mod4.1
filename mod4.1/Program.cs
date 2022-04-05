/*using System;
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
    public static void Main (string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы:");
        var color = Console.ReadLine();
        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Your color is Red!");
        }
        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Your color is Green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Your color is Cyan! (or not:)");
        }
    }
}