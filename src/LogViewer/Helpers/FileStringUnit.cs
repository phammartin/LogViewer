using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.Helpers
{
    class FileStringUnit
    {
        public FileStringUnit(string filepath, string content)
        {
            Filepath = filepath;
            Content = content;
        }

        public void Clear()
        {
            Content = null;
        }

        public string Filepath { get; }
        public string Content { get; set; }
    }
}
