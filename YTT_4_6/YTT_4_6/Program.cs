// УП Практическая работа 1.4
// Задание 6. Даны вещественные числа a и b.
// Определите, принадлежит ли точка с координатами (a; b) заштрихованной области

namespace YTT_4_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = (0 - a) * ((-3) - 2) - ((-2) - 0) * (2 - b);
            double y = ((-2) - a) * ((-3) - (-3)) - (2 - (-2)) * ((-3) - b);
            double z = (2 - a) * (2 - (-3)) - (0 - 2) * ((-3) - b);
            if ((x >= 0 && y >= 0 && z >= 0) || (x <= 0 && y <= 0 && z <= 0))
            {
                Console.WriteLine($"({a},{b}) - принадлежит заштрихованной области");
            }
            else
            {
                Console.WriteLine($"({a},{b}) - не принадлежит заштрихованной области");
            }
        }
    }
}