using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();

            exception.Data.Add("Дата исключения: ", DateTime.Now);
        }
    }
}