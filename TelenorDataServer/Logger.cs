﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TelenorDataServer
{
    static class Logger
    {
        static StringBuilder builder = new StringBuilder();

        public static void Log(string text)
        {
            Console.WriteLine(text);
            builder.AppendLine(text);
        }

        public async static void WriteLogAsync()
        {
            string name = DateTime.Now.ToString("yyyy-MM-dd_hh:mm:ss") + ".txt";
            await File.WriteAllTextAsync(name, builder.ToString());
        }
    }
}