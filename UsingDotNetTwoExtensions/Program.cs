using System;
using System.Collections.Generic;
using System.Text;
using DotNetExtensions;
using static DotNetExtensions.GenericsDelegates;

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

            var myNewText = GetText(GetMD5);
        }

        public static string GetText(Func<string, string> funcao)
        {
            return funcao("myOldText");
        }
        
        public static string GetMD5(string text)
        {
            return text.ToHashMD5();
        }
    }
}
