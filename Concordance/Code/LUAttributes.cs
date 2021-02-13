using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public static class LUAttributes
    {
        public enum groupPhrase { Group, Phrase, None };
        public static string filesPathFromRoot = "Data\\files\\";
        public static string pathToRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\");
        public static string pathToFilesFolder = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), filesPathFromRoot);
        public static string metadataBegin = "**BEGIN METADATA**";
        public static string metadataEnd = "**END METADATA**";
        public static string chapterMark = "-----";
    }
}
