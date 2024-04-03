// УП Практическая работа 1.4
// Задание 4. Дан файл numsTask4.txt с целыми числами, расположенными через пробел.
// Определите количество одинаковых рядом стоящих чисел

namespace YTT_4_4
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask4.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                int[] nums = new int[line.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                }

                int count = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] == nums[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {count}");
                
            }
        }
    }
}