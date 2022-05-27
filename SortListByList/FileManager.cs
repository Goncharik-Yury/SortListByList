using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SortListByList
{
    public class FileManager
    {
        public void Sort(List<string> sorted, List<string> toSort)
        {
            var outputFilePath = $"{Constants.filesFolder}{Constants.separator}{Constants.outputFileName}";
            var notFoundFilePath = $"{Constants.filesFolder}{Constants.separator}{Constants.notFoundFileName}";

            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }
            if (File.Exists(notFoundFilePath))
            {
                File.Delete(notFoundFilePath);
            }

            using StreamWriter file = new StreamWriter(outputFilePath);
            using StreamWriter fileNotFound = new StreamWriter(notFoundFilePath);

            foreach (var itemS in sorted)
            {
                var isFound = false;
                foreach (var itemT in toSort)
                {
                    if (itemT.Contains(";" + itemS + ";"))
                    {
                        file.WriteLine(itemT);
                        isFound = true;
                    }
                }
                if (!isFound)
                {

                    fileNotFound.WriteLine(itemS);
                }

            }
        }

        //public string FindInStrigByRegEx(Regex regex)
        //{

        //}
    }
}
