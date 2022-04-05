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
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл while");
        int k = 0;
        do
        {
            Console.WriteLine(k);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "Red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color on the skreen!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Your color on the skreen!");
                    break;
            }

    k++;

        }
            while (k < 3) ;
    }
}