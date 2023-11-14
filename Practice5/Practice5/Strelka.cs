using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Strelka
    {
        private int minstr;
        private int maxstr;

        public Strelka(int min, int max)
        {
            minstr = min;
            maxstr = max;
        }
        public int Strelochka()
        {
            int pos = minstr;
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
                    break;
            } while (key.Key != ConsoleKey.Enter);

            return pos - minstr;
        }
    }
}
