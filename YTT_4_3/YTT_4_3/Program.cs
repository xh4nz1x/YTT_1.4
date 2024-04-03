// УП Практическая работа 1.4
// Задание 3. Дан файл numsTask3.txt с целыми числами, расположенными через «,».
// Переберите все числа до 0.
// Определите отношение минимального и максимального элементов друг к другу

namespace YTT_4_3
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask3.txt";
            
            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(',');
                int[] nums = new int[line.Length];
                
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = Convert.ToInt32(line[i]);
                }
                int min = nums[0], max = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        if (nums[i] > max)
                        {
                            max = nums[i];
                        }
                        else if (nums[i] < min)
                        {
                            min = nums[i];
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Отношение минимального и максимального элементов друг к другу: {max / min}");
                    }
                }
            }
        }
    }
}