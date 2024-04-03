// УП Практическая работа 1.4
// Задание 1. Дано целое положительное число n.
// Вычислите произведение натуральных чисел, кратных трём и не превышающим число n

namespace YTT_4_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество случайных чисел: ");
            int countNums = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int sum = 0, num;
            for (int i = 0; i < countNums; i++)
            {
                num = random.Next(1, n);
                if (num % 3 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Произведение натуральных чисел, кратных трем и не превышающим число n: {sum}");
        }
    }
}