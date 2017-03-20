using System;
using System.Collections.Generic;
using System.Text;
using DotNetExtensions;

namespace UsingDotNetTwoExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Test string extension";

            var hashMD5 = text.ToHashMD5();

            Console.Write(hashMD5);

            Console.Write("1".ToInt());
        }
    }
}
