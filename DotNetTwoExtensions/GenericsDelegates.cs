using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetExtensions
{
    public class GenericsDelegates
    {
        public delegate void Func<T>(T arg1);

        public delegate TResult Func<T, out TResult>(T arg1);

        public delegate TResult Func<T, T2, out TResult>(T arg1, T2 arg2);

        public delegate TResult Func<T, T2, T3, TResult>(T arg1, T2 arg2, T3 arg3);

        public delegate TResult Func<T, T2, T3, T4, TResult>(T arg1, T2 arg2, T3 arg3, T4 arg4);
    }
}
