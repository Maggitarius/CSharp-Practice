    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Practice7
    {
        internal class menu
        {
            
            public static int Show(int minstr, int maxstr)
            {
                int pos = 2;
                ConsoleKeyInfo key;

                do
                {
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minstr)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxstr)
                    pos++;
                else if (key.Key == ConsoleKey.Escape)
                    return -1;
                } while (key.Key != ConsoleKey.Enter);

                return pos;
            }
        }
    }
