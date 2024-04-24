namespace C__Practice_modul_12_part_01_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int c;
            while (true) {
                Console.Write("Enter choice: ");
                c = int.Parse(Console.ReadLine());
                switch (c) { 
                    case 0:
                        FileViewer.ViewFileContent();
                        break;
                    case 1:
                        ArrayToFile.SaveArrayToFile();
                        break;
                    case 2:
                        ArrayToFile.LoadArrayFromFile(); 
                        break;
                    case 3:
                        NumberStatistics.GenerateNumbersAndSaveToFile();
                        break;
                    case 4:
                        Console.Write("Enter filepath: ");
                        string filePath = Console.ReadLine();
                        string wordToSearch = "searchWord";
                        string reversedWordToSearch = "drowhtraeS";

                        bool wordFound = FileSearch.SearchWord(filePath, wordToSearch);
                        Console.WriteLine($"Word '{wordToSearch}' found: {wordFound}");

                        int wordOccurrences = FileSearch.CountWordOccurrences(filePath, wordToSearch);
                        Console.WriteLine($"Occurrences of '{wordToSearch}' in file: {wordOccurrences}");

                        int reversedWordOccurrences = FileSearch.ReverseWordOccurrences(filePath, reversedWordToSearch);
                        Console.WriteLine($"Occurrences of '{reversedWordToSearch}' in file (reversed search): {reversedWordOccurrences}");
                        break;
                    case 5:
                        Console.Write("Enter filepath: ");
                        string filePath1 = Console.ReadLine();
                        FileStatistics.DisplayStatistics(filePath1);
                        break;
                }
            }
        }
    }
}
