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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp
{
    public class DiskInfo
    {
        public string DiskName { get; }
        public double DiskVolume { get; }
        public double DiskFreeSpace { get; }

        public DiskInfo(string name, double volume, double freespace)
        {
            DiskName = name;
            DiskVolume = volume;
            DiskFreeSpace = freespace;
        }
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
}
