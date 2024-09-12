using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    internal class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis 
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] fileString = File.ReadAllLines(fileInfo.FullName);
            var rowElements = fileString[0].Split(',');
            AnalysisResults results = new AnalysisResults();
            results.FieldCount = rowElements.Length;
            SetResults(results);

            
        }
    }
}
