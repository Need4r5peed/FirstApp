using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstApp.DiskInfo;

namespace FirstApp
{
    public class DiskInfo
    {
        public string DiskName { get; }
        public double DiskTotalSpace { get; }
        public double DiskFreeSpace { get; }

        public DiskInfo(string name, double totalSpace, double freeSpace)
        {
            DiskName = name;
            DiskTotalSpace = totalSpace;
            DiskFreeSpace = freeSpace;
        }

        public class Folder
        {
            public List<string> Files { get; set; } = [];
        }

    }

    public class Folders<TKey>
        where TKey : notnull
    {
        public Dictionary<TKey, Folder> Files { get; set; } = [];

        public void CreatingFolder(TKey nameFolder)
        {
            Files.Add(nameFolder, new Folder());
        }
    }
}
