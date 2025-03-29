using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static FirstApp.DiskInfo;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
}
