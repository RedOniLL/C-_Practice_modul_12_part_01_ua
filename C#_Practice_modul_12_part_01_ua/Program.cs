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
                }
            }
        }
    }
}
