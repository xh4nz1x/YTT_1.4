// УП Практическая работа 1.4
// Задание 5. Даны вещественные числа a и b.
// Определите, принадлежит ли точка с координатами (a; b) заштрихованной области

namespace YTT_4_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a >= -1 & a <= 3 & b >= -2 & b <= 4)
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