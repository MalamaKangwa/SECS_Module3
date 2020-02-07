using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLib
{
    public class ConsoleWritingTool: IConsoleTools
    {
        public void Write(string stringText)
        {
            ConsoleOutput.WriteToConsole(stringText);
        }

        public void Write(string[] arrayText)
        {
            ConsoleOutput.WriteToConsole(arrayText);
        }

        /*public string ReadFromConsole()
        {
            return Console.ReadLine();
        }*/
    }
}
