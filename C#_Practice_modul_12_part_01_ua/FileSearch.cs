using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_12_part_01_ua
{
    public static class FileSearch
    {
        public static bool SearchWord(string filePath, string word)
        {
            string content = ReadFileContent(filePath);
            return content.Contains(word);
        }

        public static int CountWordOccurrences(string filePath, string word)
        {
            string content = ReadFileContent(filePath);
            int count = CountOccurrences(content, word);
            return count;
        }

        public static int ReverseWordOccurrences(string filePath, string word)
        {
            string content = ReadFileContent(filePath);
            string reversedWord = ReverseString(word);
            int count = CountOccurrences(content, reversedWord);
            return count;
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

        private static int CountOccurrences(string content, string word)
        {
            int count = 0;
            int index = 0;

            while ((index = content.IndexOf(word, index)) != -1)
            {
                index += word.Length;
                count++;
            }

            return count;
        }

        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
