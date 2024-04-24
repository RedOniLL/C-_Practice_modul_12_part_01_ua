using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_12_part_01_ua
{
    public static class FileStatistics
    {
        public static void DisplayStatistics(string filePath)
        {
            string fileContent = ReadFileContent(filePath);
            int sentenceCount = CountSentences(fileContent);
            int uppercaseCount = CountUppercaseLetters(fileContent);
            int lowercaseCount = CountLowercaseLetters(fileContent);
            int vowelsCount = CountVowels(fileContent);
            int consonantsCount = CountConsonants(fileContent);
            int digitsCount = CountDigits(fileContent);

            Console.WriteLine($"Number of sentences: {sentenceCount}");
            Console.WriteLine($"Number of uppercase letters: {uppercaseCount}");
            Console.WriteLine($"Number of lowercase letters: {lowercaseCount}");
            Console.WriteLine($"Number of vowels: {vowelsCount}");
            Console.WriteLine($"Number of consonants: {consonantsCount}");
            Console.WriteLine($"Number of digits: {digitsCount}");
        }

        private static string ReadFileContent(string filePath)
        {
            string content = "";
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    content += reader.ReadLine();
                }
            }
            return content;
        }

        private static int CountSentences(string content)
        {
            string[] sentences = content.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return sentences.Length;
        }

        private static int CountUppercaseLetters(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountLowercaseLetters(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountVowels(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if ("AEIOUaeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountConsonants(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (char.IsLetter(c) && !"AEIOUaeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        private static int CountDigits(string content)
        {
            int count = 0;
            foreach (char c in content)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
