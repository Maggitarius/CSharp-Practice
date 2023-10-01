namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать! Выберите программу, которой хотите воспользоваться:");
                Console.WriteLine("1. Игра 'Угадай число'");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делитей числа");
                Console.WriteLine("Для выхода из программы, напишите 'Выход'");
                string vbr = (Console.ReadLine());
                if (vbr == "1")
                {
                    Ugadaika();
                }
                if (vbr == "2")
                {
                    TabUmn();
                }
                if (vbr == "3")
                {
                    DelChsl();
                }
                if (vbr == "Выход")
                {
                    break;
                }
            }
        }
        static void Ugadaika()
        {
            Random rnd = new Random();
            int num = rnd.Next(100);
            while (num > 0)
            {
                Console.WriteLine("Введите число, которое было загадано:");
                int mbnum = Convert.ToInt32(Console.ReadLine());
                if (mbnum == num)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число!");
                    break;
                }
                if (mbnum > num)
                {
                    Console.WriteLine("Не угадали! Загаднное число меньше:(");
                }
                if (mbnum < num)
                {
                    Console.WriteLine("Не угадали! Загаднное число больше:(");
                }
            }
        }
        static void TabUmn()
        {
            int[,] tbl = new int[11, 11];
            int x = tbl.GetLength(0);
            int y = tbl.GetLength(1);      
            for (int i = 1; i < x; ++i){
                for (int j = 1; j < y; ++j) {
                    tbl[i, j] = i * j;
                    Console.Write(tbl[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void DelChsl()
        {
            {
            Console.WriteLine("Введите число, делите которого хотите узнать:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; ++i)
            {
                if (n % i == 0)
                { 
                    Console.Write(i + "   ");
                }
            }
            Console.WriteLine();
            }
        }
    }
}