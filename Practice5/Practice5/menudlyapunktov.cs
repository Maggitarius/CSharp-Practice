using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class menudlyapunktov
    {
        public static List<List<Punkt>> ListZakazov = new List<List<Punkt>>()
        {
            new List<Punkt>()
            {
                new Punkt("  Октагон", 500),
                new Punkt("  Додекаэдр",1000),
                new Punkt("  Тетрагонтриотаэдр", 2500)
            },
            new List<Punkt>()
            {
                new Punkt("  Микротортек", 100),
                new Punkt("  Нормтортек", 300),
                new Punkt("  Гигатортек", 500)
            },
            new List<Punkt>()
            {
                new Punkt("  Цвет Морской Волны", 250),
                new Punkt("  СероБуроМалиновый", 250),
                new Punkt("  Пивной", 250)
            },
            new List<Punkt>()
            {
                new Punkt("  Пивной", 5000), //на самом деле бесценно
                new Punkt("  Дотавый)))", 100),
                new Punkt("  Вкус Баранки из Дества", 2000000000) //на самом деле это тоже бесценно
            },
            new List<Punkt>()
            {
                new Punkt("  Зеркальная", 500),
                new Punkt("  Прозрачная", 500),
                new Punkt("  Пивная", 500)
            },
            new List<Punkt>()
            {
                new Punkt("  Бутылка Пива", 500),
                new Punkt("  Мраморная статуя Давида", 1000),
                new Punkt("  Плакат 'Три Дня Дождя'", 2500)
            },
            new List<Punkt>()
            {
                new Punkt("  Мало", 10000),
                new Punkt("  Нормик", 10000),
                new Punkt("  Ты сколько не сьешь", 500000)
            }
        };
    }
}
