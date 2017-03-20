using System;
using System.Collections.Generic;
using System.Text;
using DotNetExtensions;

namespace UsingDotNetTwoExtensions
{
    public static class NewExtensions
    {
        public static int ToInt(this string text)
        {
            return int.Parse(text);
        }
    }
}
