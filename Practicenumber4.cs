using Practice4;

internal class Practicenumber4
{
    static void Main(string[] args)
    {
        bool vihod = false;
        DateTime date = DateTime.Today;

        while (vihod != true)
        {
            string name = "Покушать вкусно";
            string description = "Покушать что угодно, кроме холодца, печенки и прочей гадости";
            DateTime kogdasdelat = new DateTime(2023, 10, 20);
            Zametka note1 = new Zametka(name, description, kogdasdelat);

            string name2 = "Жоска поиграть в компик";
            string description2 = "Ваще с кайфом люто зарубиться в DOKA2.Kishki Edition";
            DateTime kogdasdelat2 = new DateTime(2023, 10, 28);
            Zametka note2 = new Zametka(name2, description2, kogdasdelat2);

            string name3 = "Почитать Ницше, Аристотеля и прочих безработных";
            string description3 = "Пора бы ума понобрать, за книги сесть конкретно";
            DateTime kogdasdelat3 = new DateTime(2023, 11, 07);
            Zametka note3 = new Zametka(name3, description3, kogdasdelat3);

            string name4 = "Так уж и быть, сходить на пары";
            string description4 = "А вообще, ну их нафек)))";
            DateTime kogdasdelat4 = new DateTime(2023, 10, 31);
            Zametka note4 = new Zametka(name4, description4, kogdasdelat4);

            string name5 = "Нереально зачиллиться в кроватки с чипсеками и покемонами";
            string description5 = "С кайфиком лежать, смотреть все серии покемонов и гробить своё здоровье мерзкой американской гадостью";
            DateTime kogdasdelat5 = new DateTime(2023, 11, 28);
            Zametka note5 = new Zametka(name5, description5, kogdasdelat5);



            Console.Clear();
            Console.WriteLine("Заметки на: " + date.ToShortDateString());
            Console.WriteLine("----------------------");
            if (new DateTime(2023, 10, 20) == date)
            {
                 note1.VivodNazvaniya();
            }
            else if (new DateTime(2023, 10, 28) == date)
            {
                 note2.VivodNazvaniya();
            }
            else if (new DateTime(2023, 11, 07) == date)
            {
                note3.VivodNazvaniya();
            }
            else if (new DateTime(2023, 10, 31) == date)
            {
                note4.VivodNazvaniya();
            }
            else if (new DateTime(2023, 11, 28) == date)
            {
                note5.VivodNazvaniya();
            }

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.RightArrow) { date = date.AddDays(1); }
            else if (key.Key == ConsoleKey.LeftArrow) { date = date.AddDays(-1); }
            else if (key.Key == ConsoleKey.Escape) { break; }

            int pos = 2;
            if (key.Key == ConsoleKey.DownArrow)
            {
                while (key.Key != ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");
                    if (key.Key == ConsoleKey.UpArrow && pos != 2)
                        pos--;
                    else if (key.Key == ConsoleKey.DownArrow)
                        pos++;
                }

                if (pos == 2 && key.Key == ConsoleKey.Enter && new DateTime(2023, 10, 20) == date)
                {
                    Console.Clear();
                    note1.VivodOpisaniya();
                    Console.ReadKey();
                }
                else if (pos == 2 && key.Key == ConsoleKey.Enter && new DateTime(2023, 10, 28) == date)
                {
                    Console.Clear();
                    note2.VivodOpisaniya();
                    Console.ReadKey();
                }
                else if (pos == 2 && key.Key == ConsoleKey.Enter && new DateTime(2023, 11, 01) == date)
                {
                    Console.Clear();
                    note3.VivodOpisaniya();
                    Console.ReadKey();
                }
                else if (pos == 2 && key.Key == ConsoleKey.Enter && new DateTime(2023, 10, 31) == date)
                {
                    Console.Clear();
                    note4.VivodOpisaniya();
                    Console.ReadKey();
                }
                else if (pos == 2 && key.Key == ConsoleKey.Enter && new DateTime(2023, 11, 28) == date)
                {
                    Console.Clear();
                    note5.VivodOpisaniya();
                    Console.ReadKey();
                }
            }
        }
    }
 }

internal class Zametka
{
    public string Name;
    public string Description;
    public DateTime KogdaSdelat;

    public Zametka(string name, string description, DateTime kogdasdelat)
    {
        Name = name;
        Description = description;
        KogdaSdelat = kogdasdelat;
    }

    public void VivodNazvaniya()
    {
        Console.WriteLine("  " + Name);
    }

    public void VivodOpisaniya()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Description);
        Console.WriteLine(KogdaSdelat.ToString("dd.MM.yyyy"));
    }
}