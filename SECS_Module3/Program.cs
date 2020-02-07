using System;
using ConsoleLib;

namespace SECS_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWritingTool consoleTools = new ConsoleWritingTool();
            consoleTools.Write(args);
            Console.ReadKey();
        }
    }
}


