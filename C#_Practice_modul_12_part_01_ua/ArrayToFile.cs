using System;


namespace C__Practice_modul_12_part_01_ua
{
    public static class ArrayToFile
    {
        public static void SaveArrayToFile()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];
            Console.WriteLine($"Enter {arrayLength} elements for the array:");

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the file path to save the array:");
            string filePath = Console.ReadLine();

            using (var streamWriter = new StreamWriter(filePath))
            {
                foreach (int element in array)
                {
                    streamWriter.WriteLine(element);
                }
            }

            Console.WriteLine("Array successfully saved to file.");
        }

        public static void LoadArrayFromFile(string filePath)
        {
            List<int> numbersList = new List<int>();

            using (var streamReader = new StreamReader(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (int.TryParse(line, out int number))
                    {
                        numbersList.Add(number);
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing line: {line}");
                    }
                }
            }

           foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

        }
    }
}
