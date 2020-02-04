using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.Helpers;

namespace LogViewer.Parsing
{
    class FileParseInstruction
    {

        public FileParseInstruction(FileStringUnit fileContent, DateTime targetDate)
        {
            FileContent = fileContent;
            TargetDate = targetDate;
        }

        public FileStringUnit FileContent { get; private set; }
        public DateTime TargetDate { get; private set; }
    }
}
