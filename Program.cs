using System;

namespace Piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menushka();
            ConsoleKeyInfo vibor = Console.ReadKey(true);
            zvuk(vibor);

            static void zvuk(ConsoleKeyInfo vibor)
            {
                int[] octava = oct(vibor);
                do
                {
                    vibor = Console.ReadKey(true);

                    switch (vibor.Key)
                    {
                        case ConsoleKey.Q:
                            Console.Beep(octava[0], 300);
                            break;
                        case ConsoleKey.W:
                            Console.Beep(octava[1], 300);
                            break;
                        case ConsoleKey.E:
                            Console.Beep(octava[2], 300);
                            break;
                        case ConsoleKey.R:
                            Console.Beep(octava[3], 300);
                            break;
                        case ConsoleKey.T:
                            Console.Beep(octava[4], 300);
                            break;
                        case ConsoleKey.Y:
                            Console.Beep(octava[5], 300);
                            break;
                        case ConsoleKey.U:
                            Console.Beep(octava[6], 300);
                            break;
                        case ConsoleKey.I:
                            Console.Beep(octava[7], 300);
                            break;
                        case ConsoleKey.O:
                            Console.Beep(octava[8], 300);
                            break;
                        case ConsoleKey.P:
                            Console.Beep(octava[9], 300);
                            break;
                        case ConsoleKey.C:
                            Console.Beep(octava[10], 300);
                            break;
                        case ConsoleKey.N:
                            Console.Beep(octava[11], 300);
                            break;
                        default:
                            octava = oct(vibor);
                            break;
                    }
                } while (true);
            }
            static int[] oct(ConsoleKeyInfo vibor)
            {
                int[] octava = new int[12];
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    menushka();
                    Console.WriteLine("Вы выбрали нулевую октаву:");
                    octava = new int[12] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2405, 2596, 2750, 2914, 3087 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F2)
                {
                    Console.Clear();
                    menushka();
                    Console.WriteLine("Вы выбрали первую октаву:");
                    octava = new int[12] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    menushka();
                    Console.WriteLine("Вы выбрали вторую октаву:");
                    octava = new int[12] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 };
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key == ConsoleKey.F4)
                {
                    Console.Clear();
                    menushka();
                    Console.WriteLine("Вы выбрали третью октаву:");
                    octava = new int[12] { 1308, 1386, 1468, 1556, 1648, 1746, 1850, 1960, 2077, 2200, 2331, 2469 };
                }
                if ((vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F1) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F2) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F3) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Key != ConsoleKey.F4) && (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Modifiers.HasFlag(ConsoleModifiers.Alt) && vibor.Key != ConsoleKey.Z))
                {
                    Console.Clear();
                    menushka();
                    Console.WriteLine("ВЫБЕРИТЕ ОКТАВУ КЛАВИШАМИ ОТ F1 ДО F4!");
                }
                if (vibor.Modifiers.HasFlag(ConsoleModifiers.Control) && vibor.Modifiers.HasFlag(ConsoleModifiers.Alt) && vibor.Key == ConsoleKey.Z)
                {
                    Console.Beep(2616, 300);
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
            static void menushka ()
            {
                Console.WriteLine("Вы пользуетесь пианино! Выберите нужную вам октаву: для этого зажмите CTRL, а далее выберите от F1 до F3!");
            }
        }
    }
}