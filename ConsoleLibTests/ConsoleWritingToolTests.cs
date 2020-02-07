using ConsoleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleLibTests
{
    [TestClass()]
    public class ConsoleWritingToolTests
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

        public void WriteLineTest()
        {
            string expectedString = "Hello World";

            console.Write(expectedString);
            Assert.AreEqual(expectedString, stringWriter.ToString().Trim()); ;
        } 

        [TestMethod()]
        public void WriteLineArrayTest()
        {
            string[] inputArray = { "Malama, Stephen, Kangwa"};

            console.Write(inputArray);
            string expectedArray = "Malama, Stephen, Kangwa";
            Assert.AreEqual(expectedArray, stringWriter.ToString().Trim());
        } 


        [TestMethod()]
        public void ReadLineTest()
        {
            string consoleInput = "Malama";
            StringReader stringReader = new StringReader(consoleInput);

            Console.SetIn(stringReader);

            string result = Console.ReadLine();
            Assert.AreEqual(result, consoleInput);

        }


    }
}
