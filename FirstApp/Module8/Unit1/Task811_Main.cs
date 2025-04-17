using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstApp.Module8.Unit1.Task811.DiskInfo_Task811;

namespace FirstApp.Module8.Unit1.Task811
{
    public class Main_Task811
    {
        public static void Main()
        {
            Console.WriteLine("Программа завершена...");
        }
    }
    public class DiskInfo_Task811
    {
        public string DiskName { get; }
        public double DiskTotalSpace { get; }
        public double DiskFreeSpace { get; }

        public DiskInfo_Task811(string name, double totalSpace, double freeSpace)
        {
            DiskName = name;
            DiskTotalSpace = totalSpace;
            DiskFreeSpace = freeSpace;
        }

        public class Folder_Task811
        {
            public List<string> Files { get; set; } = [];
        }

    }

    public class Folders_Task811<TKey>
        where TKey : notnull
    {
        public Dictionary<TKey, Folder_Task811> Files { get; set; } = [];

        public void CreatingFolder(TKey nameFolder)
        {
            Files.Add(nameFolder, new Folder_Task811());
        }
    }
}
