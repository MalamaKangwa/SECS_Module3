using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLib
{
    public static class StringBuilderTools
    {
        public static StringBuilder ArrayStringBuilder(StringBuilder objStringBuilder, string[] arrayString)
        {
            foreach (string arrayElement in arrayString)
            {
                objStringBuilder.Append("" + arrayElement);
            }
            return objStringBuilder;
        }


        public static StringBuilder StringBuilderFactory(string textString)
        {
            int intStringLenght = textString.Length;
            StringBuilder stringBuilder = new StringBuilder(textString, intStringLenght);
            return stringBuilder;
        }

        public static StringBuilder StringBuilderFactory(string[] textArray)
        {
            StringBuilder stringBuilderObject = new StringBuilder();
            stringBuilderObject = ArrayStringBuilder(stringBuilderObject, textArray);
            return stringBuilderObject;
        }

    }
}
