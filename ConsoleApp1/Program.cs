using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtension;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t =Parser.ToDecimal("0110111101100001100001010111111", new Notation(2));

            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
