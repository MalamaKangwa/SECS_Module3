using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLib
{
    public interface IConsoleTools
    {
        public void Write(string stringInput);
        public void Write(string[] stringInput);
        //public string ReadFromConsole();
    }
}

