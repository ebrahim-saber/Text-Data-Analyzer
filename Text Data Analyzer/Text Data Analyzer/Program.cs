namespace Text_Data_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Analyzer");
            Console.WriteLine("Please enter folder path to analyze");
            string inputFolder=Console.ReadLine();
           
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);
            if (directoryInfo.Exists ==false )
            {
                Console.WriteLine("File does not exist");
                return;
            }
            var fileNames=directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;
            foreach (var file in fileNames)
            {   if (file.IsTextFile())
                {
                 fileAnalysis = new TextFileAnalyzer(); 
                fileAnalysis.AnalyzeFile(file);
                var results = ((FileAnalyzer)fileAnalysis).GetResults();
                Console.WriteLine($"File Name :{file.Name} ");
                Console.WriteLine($"Word count :{results.WordCount} ");
                Console.WriteLine($"Character Count :{results.CharacterCount} ");
                Console.WriteLine($"Line Count :{results.LineCount} ");

                }
                else if (file.IsCSVFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File Name :{file.Name} ");
                    Console.WriteLine($"Field count :{results.FieldCount} ");

                }

            }



        }
    }
}
