using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleLib.Tests
{
    [TestClass()]
    public class ConsoleOutputTests
    {
        private readonly ConsoleWritingTool console = new ConsoleWritingTool();
        private readonly StringWriter stringWriter = new StringWriter();

        [TestInitialize()]
        public void SetOut()
        {
            Console.SetOut(stringWriter);
        }

        [TestCleanup()]
        public void CleanUp()
        {
            StreamWriter standardOut = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            Console.SetOut(standardOut);
        }

        [TestMethod()]
        public void ConsoleOutputArrayTest()
        {
            string[] _args = { "This ", "is ", "Sparta " };
            string _expected = "This is Sparta";
            console.Write(_args);
            Assert.AreEqual(_expected, stringWriter.ToString().Trim());
        }

    }
}