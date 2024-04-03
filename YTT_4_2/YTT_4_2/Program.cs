// УП Практическая работа 1.4
// Задание 2. Дан файл numsTask2.txt с вещественными числами, расположенными через «;».
// Переберите все числа до 0.
// Определите сумму положительных элементов получившейся последовательности

namespace YTT_4_2
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask2.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(';');
                double[] nums = new double[line.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToDouble(line[i]);
                }

                double sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        if (nums[i] != 0 & nums[i] > 0)
                        {
                            sum += nums[i];
                        }
                    }
                    else if (nums[i] == 0)
                    {
                        Console.WriteLine($"Сумма положительных элементов последовательности: {sum}");
                    }
                }
            }
        }
    }
}