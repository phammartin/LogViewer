using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogViewer.Helpers
{
    static class FileUtil
    {
        public static string ReadFiletoString(string filepath)
        {
            using (StreamReader sr = new StreamReader(filepath))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// Returns a list of all files nested in a root directory, its subdirectories, and descendent subdirectories.
        /// </summary>
        /// <param name="rootFolderpath">The root directory that will be processed.</param>
        /// <returns></returns>
        public static FileInfo[] GetNestedFileInfo(string rootFolderpath)
        {
            var outAllFileInfo = new List<FileInfo>();
            var rootFolderInfo = new DirectoryInfo(rootFolderpath);
            buildFileInfoRecursive(rootFolderInfo, outAllFileInfo);
            return outAllFileInfo.ToArray();
        }

        /// <summary>
        /// Recursively builds a list of all files that are contained in and underneath a root directory.
        /// </summary>
        /// <param name="folderInfo">The folder path whose contents will be added to the file list. Text file filtering is not built-in.</param>
        /// <param name="outFileInfoList">The aggregated list that is appended to during each method call.</param>
        /// <remarks>
        /// TODO: Exclude text files from the out list.
        /// </remarks>
        private static void buildFileInfoRecursive(DirectoryInfo folderInfo, List<FileInfo> outFileInfoList)
        {
            outFileInfoList.AddRange(folderInfo.GetFiles());
            foreach (var subFolder in folderInfo.GetDirectories())
            {
                buildFileInfoRecursive(subFolder, outFileInfoList);
            }
        }
    }
}
