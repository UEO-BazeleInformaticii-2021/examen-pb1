using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("Dimensiunea array-ului:");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = ReadNumber($"element[{i}]:");
            }

            int sum = RecursivityHelper.Sum(array);
            Console.WriteLine(sum);
        }

        public static int ReadNumber(string label, int defaultValue = 0)
        {
            Console.Write(label);
            string response = Console.ReadLine();

            if (int.TryParse(response, out int result))
            {
                return result;
            }
            else
            {
                return defaultValue;
            }
        }
    }
}
