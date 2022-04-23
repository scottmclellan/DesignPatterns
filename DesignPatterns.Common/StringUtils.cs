using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common
{
    public static class StringUtils
    {
        public static string FormatCamelCaseString(this string camelCaseString)
        {
            List<char> formattedText = new List<char>();

            for (int i = camelCaseString.Length - 1; i >= 0; i--)
            {
                formattedText.Add(camelCaseString[i]);
                if (camelCaseString[i] == char.ToUpper(camelCaseString[i]) && i > 0)
                {
                    formattedText.Add(' ');
                }
            }
            formattedText.Reverse();

            return string.Join("", formattedText);
        }
    }
}
