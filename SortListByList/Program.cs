using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortListByList
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Main start...");

            MainAsync(args);

            Console.WriteLine("...Main end.");
        }

        private static void MainAsync(string[] args)
        {
            var sortedList = GetDataFromFile(Constants.sortedFileName);
            var listToSort = GetDataFromFile(Constants.fileToSortName);

            var fileManager = new FileManager();
            fileManager.Sort(sortedList, listToSort);
        }

        private static List<string> GetDataFromFile(string fileName)
        {
            var fileData = File.ReadAllLines($"{Constants.filesFolder}{Constants.separator}{fileName}");

            return fileData.ToList();
        }
    }
}