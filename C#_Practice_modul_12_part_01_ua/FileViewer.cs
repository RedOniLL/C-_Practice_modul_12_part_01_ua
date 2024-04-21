using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_12_part_01_ua
{
    public static class FileViewer
    {
        public static void ViewFileContent()
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("Error: File does not exist.");
            }
        }
    }
}
