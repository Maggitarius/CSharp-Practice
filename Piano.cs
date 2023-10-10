using System;

namespace Piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы пользуетесь пианино! Выберите нужную вам октаву: для этого зажмите CTRL, а далее выберите от F1 до F3!");
            ConsoleKeyInfo vibor = Console.ReadKey(true);
            zvuk(vibor);

            static int[] oct(ConsoleKeyInfo vibor)
            {
                int[] octava = new int[12];
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Вы выбрали нулевую октаву:");
                    octava = new int[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2405, 2596, 2750, 2914, 3087 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Вы выбрали первую октаву:");
                    octava = new int[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Вы выбрали вторую октаву:");
                    octava = new int[12] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Вы выбрали третью октаву:");
                    octava = new int[12] { 1308, 1386, 1468, 1556, 1648, 1746, 1850, 1960, 2077, 2200, 2331, 2469 };
                }
                if ((vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F1) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F2) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F3) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F4) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Modifiers.HasFlag(ConsoleModifiers.Alt) && vibor.Key != ConsoleKey.Z))
                {
                    Console.WriteLine("ВЫБЕРИТЕ ОКТАВУ КЛАВИШАМИ ОТ F1 ДО F4!");
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Modifiers.HasFlag(ConsoleModifiers.Alt) && vibor.Key  == ConsoleKey.Z) 
                {
                    Console.Beep(2616,300);
                    Thread.Sleep(200);
                    Console.Beep(3111, 300);
                    Thread.Sleep(200);
                    Console.Beep(3492, 250);
                    Thread.Sleep(200);
                    Console.Beep(3111, 300);
                    Thread.Sleep(200);
                    Console.Beep(3492, 150);
                    Thread.Sleep(150);
                    Console.Beep(3492, 150);
                    Thread.Sleep(150);
                    Console.Beep(3492, 150);
                    Thread.Sleep(150);
                    Console.Beep(4662, 200);
                    Thread.Sleep(200);
                    Console.Beep(4153, 200);
                    Thread.Sleep(200);
                    Console.Beep(3920, 150);
                    Thread.Sleep(200);
                    Console.Beep(3492, 250);
                    Thread.Sleep(200);
                    Console.Beep(3920, 400);
                    Thread.Sleep(200);
                    Console.Beep(3920, 350);
                    Thread.Sleep(200);
                    Console.Beep(4662, 200);
                    Thread.Sleep(200);
                    Console.Beep(5233, 200);
                    Thread.Sleep(200);
                    Console.Beep(3920, 200);
                    Thread.Sleep(200);
                    Console.Beep(3492, 150);
                    Thread.Sleep(200);
                    Console.Beep(4662, 175);
                    Thread.Sleep(200);
                    Console.Beep(4662, 175);
                    Thread.Sleep(200);
                    Console.Beep(3920, 150);
                    Thread.Sleep(200);
                    Console.Beep(4662, 175);
                    Thread.Sleep(200);
                    Console.Beep(4662, 300);
                    Thread.Sleep(200);
                    Console.Beep(5233, 600);
                    Thread.Sleep(200);
                }
                return octava;
            }
            static void zvuk(ConsoleKeyInfo vibor)
            {
                int[] octava = oct(vibor);
                while (true)
                {
                    if (vibor.Key == ConsoleKey.Q)
                    {
                        Console.Beep(octava[0], 300);
                    }
                    else if (vibor.Key == ConsoleKey.W)
                    {
                        Console.Beep(octava[1], 300);
                    }
                    else if (vibor.Key == ConsoleKey.E)
                    {
                        Console.Beep(octava[2], 300);
                    }
                    else if (vibor.Key == ConsoleKey.R)
                    {
                        Console.Beep(octava[3], 300);
                    }
                    else if (vibor.Key == ConsoleKey.T)
                    {
                        Console.Beep(octava[4], 300);
                    }
                    else if (vibor.Key == ConsoleKey.Y)
                    {
                        Console.Beep(octava[5], 300);
                    }
                    else if (vibor.Key == ConsoleKey.U)
                    {
                        Console.Beep(octava[6], 300);
                    }
                    else if (vibor.Key == ConsoleKey.I)
                    {
                        Console.Beep(octava[7], 300);
                    }
                    else if (vibor.Key == ConsoleKey.O)
                    {
                        Console.Beep(octava[8], 300);
                    }
                    else if (vibor.Key == ConsoleKey.P)
                    {
                        Console.Beep(octava[9], 300);
                    }
                    else if (vibor.Key == ConsoleKey.C)
                    {
                        Console.Beep(octava[10], 300);
                    }
                    else if (vibor.Key == ConsoleKey.N)
                    {
                        Console.Beep(octava[11], 300);
                    }
                    else
                        octava = oct(vibor);

                    vibor = Console.ReadKey(true);
                }
            }
        }
    }
}