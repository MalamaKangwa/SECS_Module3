using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLib
{
    public class ConsoleOutput 
    {
        public static void WriteToConsole(string stringInput)
        {
            StringBuilder textStringBuilder = StringBuilderTools.StringBuilderFactory(stringInput);
            Console.WriteLine(textStringBuilder);
        }

        public static void WriteToConsole(string[] arrayInput)
        {
            StringBuilder arrayStringBuilder = StringBuilderTools.StringBuilderFactory(arrayInput);
            Console.WriteLine(arrayStringBuilder);
        }

        public string ReadFromConsole()
        {
            string inputString = Console.ReadLine();
            return inputString;
        }

    }
}
