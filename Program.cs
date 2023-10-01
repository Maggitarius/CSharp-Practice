Console.WriteLine("Добро пожаловать в Калькулятор!");
Console.WriteLine("Выберите операцию и введите её номер:");
Console.WriteLine("1. Сложить 2 числа ");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Найти квадратный корень из числа");
Console.WriteLine("6. Найти 1 процент из числа");
Console.WriteLine("7. Возвести в степень N первое число");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
int vibor = int.Parse(Console.ReadLine());
double otvet = 0; 
do
{
        if (vibor >= 1 && vibor <= 9)
        {
            while (vibor != 9)
            {
                if (vibor == 1)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число:");
                    double y = double.Parse(Console.ReadLine());
                    otvet = x + y;
                    Console.WriteLine("Результат:" + otvet);
                    break;
                }
                if (vibor == 2)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число:");
                    double y = double.Parse(Console.ReadLine());
                    otvet = x - y;
                    Console.WriteLine("Результат:" + otvet);
                    break;
                }
                if (vibor == 3)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число:");
                    double y = double.Parse(Console.ReadLine());
                    otvet = x * y;
                    Console.WriteLine("Результат:" + otvet);
                    break;
                }
                if (vibor == 4)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число:");
                    double y = double.Parse(Console.ReadLine());
                    if (y != 0)
                    {
                        otvet = x / y;
                        Console.WriteLine("Результат:" + otvet);
                        break;
                    }
                    if (y == 0) ;
                    {
                        Console.WriteLine("Нельзя делить на ноль!");
                    }

                }
                if (vibor == 5)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Результат:" + Math.Sqrt(x));
                    break;
                }
                if (vibor == 6)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    otvet = x / 100;
                    Console.WriteLine("Результат:" + otvet);
                    break;
                }
                if (vibor == 7)
                {
                    Console.Write("Введите первое число:");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Введите степень:");
                    double n = double.Parse(Console.ReadLine());
                    otvet = Math.Pow(x, n);
                    Console.WriteLine("Результат:" + otvet);
                    break;
                }
                if (vibor == 8)
                {
                    Console.WriteLine("Введите число: ");
                    int a = int.Parse(Console.ReadLine());
                    int factorial = 1;
                    for (int x = 1; x <= a; x++)
                    {
                        factorial *= x;
                    }
                    Console.WriteLine("Результат:" + factorial);
                    break;
                if  (vibor == 9)
                {
                    break;
                }
                }
            }
        }
        else
        {
            Console.WriteLine("ВВЕДИТЕ ЧИСЛО ОТ 1 ДО 9!");
        }
} while (vibor != 9);