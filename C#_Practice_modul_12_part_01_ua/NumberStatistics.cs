using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_12_part_01_ua
{

    public static class NumberStatistics
    {
        public static void GenerateNumbersAndSaveToFile()
        {
            Random random = new Random();
            int[] numbers = new int[10000]; 

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10001); 
            }

            string evenFilePath = "even_numbers.txt";
            string oddFilePath = "odd_numbers.txt";

            using (StreamWriter evenWriter = new StreamWriter(evenFilePath))
            using (StreamWriter oddWriter = new StreamWriter(oddFilePath))
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenWriter.WriteLine(number);
                    }
                    else
                    {
                        oddWriter.WriteLine(number);
                    }
                }
            }

            Console.WriteLine("Numbers generated and saved to files.");

            ShowStatistics(numbers);
        }

        private static void ShowStatistics(int[] numbers)
        {
            int evenCount = 0;
            int oddCount = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine($"Total numbers: {numbers.Length}");
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }
}
