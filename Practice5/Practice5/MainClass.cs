namespace Practice5
{
    internal class MainClass
    {
        static List<Punkt> vibor = new List<Punkt>();
        static Dictionary<string, int> save = new Dictionary<string, int>();
        static List<string> listsave = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                GlavnoeMenu();
                int pos = new Strelka(3, 10).Strelochka();
                if (pos == menudlyapunktov.ListZakazov.Count())
                {
                    File.AppendAllText("история.txt", "-------------------------------------" + "\n");
                    File.AppendAllText("история.txt", "  Заказ от: " + DateTime.Now + "\n" + "\n");
                    foreach (var item in save)
                    {
                        File.AppendAllText("история.txt", item.Key + ", " + "\n");
                    }
                    File.AppendAllText("история.txt", "\n" + "Сумма вашего заказа:" + GlavnoeMenu() + "\n");
                    File.AppendAllText("история.txt", "-------------------------------------");
                    return;
                }
                MenuPunctov(pos);
                int posit = new Strelka(2, menudlyapunktov.ListZakazov[pos].Count() + 1).Strelochka();
                savevibor(menudlyapunktov.ListZakazov[pos][posit]);
            }
        }

        static int GlavnoeMenu()
        {
            int summa = 0;
            Console.Clear();
            Console.WriteLine("Добро пожаловать в нашу РеальноНерельануюСуперМегаУльтраВнепространственную4D-кондитерскую!");
            Console.WriteLine("Для того, чтобы заказать у нас тортек, выберите его компоненты:");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("  1.Форма Тортека");
            Console.WriteLine("  2.Размер Тортека");
            Console.WriteLine("  3.Цвет Тортека");
            Console.WriteLine("  4.С каким вкусом будет Тортек");
            Console.WriteLine("  5.Какая глазурь будет у Тортека");
            Console.WriteLine("  6.Какой декор будет у Тортека");
            Console.WriteLine("  7.Сколько будет Тортеков");
            Console.WriteLine("  Конец заказа");
            Console.Write("-------------------------------------------------------------------------------------------");
            Console.Write("\n" + "В вашем заказе есть:");
            foreach (var item in save)
            {
                Console.Write(item.Key);
            }
            Console.Write("\n" + "Сумма ваше чека:");
            foreach (var item in save)
            {
                summa = summa + item.Value;
            }
            Console.Write(" " + summa);
            return summa;
        }

        static void MenuPunctov(int pos)
        {
            Console.Clear();
            Console.WriteLine("Выберите желаемое:");
            Console.WriteLine("------------------");
            foreach (var i in menudlyapunktov.ListZakazov[pos])
            {
                Console.WriteLine(i.nazvanie + ' ' + i.price);
            }
        }

        static void savevibor(Punkt pox)
        {
            save.Add(pox.nazvanie, pox.price);
        }
    }
}