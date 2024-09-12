using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    public interface IFileAnalysis 
    {
        void AnalyzeFile(FileInfo fileInfo);
    }
}
