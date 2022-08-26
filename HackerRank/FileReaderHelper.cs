using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class FileReaderHelper
    {
        public static string ReadFileAsText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}