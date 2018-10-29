using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class Parser
    {
        /// <summary>
        /// Hex symbols
        /// </summary>
        public const string symbols = "0123456789ABCDEF";

        /// <summary>
        /// Parse to decimal
        /// </summary>
        /// <param name="source">Input string</param>
        /// <param name="base">Base</param>
        /// <returns>Integer value in decimal</returns>
        public static int ToDecimal(this string source, int @base)
        {
            long exponent = 1;
            long result = 0;

            if (@base < 2 || @base > 16)
            {
                throw new ArgumentException();
            }
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException();
            }
            if (source.Any(Char.IsLower))
            {
                throw new ArgumentException();
            } 

            for (int i = source.Length - 1; i >= 0 ; i--)
            {
                var index = symbols.IndexOf(source[i]);

                if (index < 0 || index >= @base)
                {
                    throw new ArgumentException();
                }

                if (result + exponent * index > Int32.MaxValue)
                {
                    throw new OverflowException();
                }
                else
                {
                    result += exponent * index;
                    exponent *= @base;
                }                
            }
            return (int)result;
        }
    }
}
