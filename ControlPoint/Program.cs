namespace ControlPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, _switch;
            while (true)
            {
                Console.WriteLine("Это вариант 14");
                Console.Write("Выберете задание от 1 до 3: ");
                _switch = Convert.ToInt32(Console.ReadLine());
                switch (_switch)
                {
                    case 1:
                        Console.WriteLine("Число a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Число b:");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Число c:");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Сумма: " + (a + b + c) + " Произведение: " + (a * b * c));
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("Скорость в км/ч:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Скорость часов(целых):");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Проехал: " + a * b);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Сторона квадрата: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("В каком типе измерения?");
                        string type = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Площадь куба: " + a * a + " " + type + " квадратных");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Не коректный выбор, попробуйте ещё раз");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
