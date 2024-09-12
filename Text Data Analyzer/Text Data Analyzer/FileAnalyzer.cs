using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{  // base class
    public class FileAnalyzer
    {
        private AnalysisResults _results;
        public AnalysisResults GetResults()
        {
            return _results;
        }
        public void SetResults(AnalysisResults results)
        {
            _results = results;
        }
    }
}
