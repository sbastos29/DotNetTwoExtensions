using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}

namespace DotNetExtensions
{
    public static class ExtensionMethods
    {
        public static string ToHashMD5(this string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            var returnString = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                returnString.Append(hash[i].ToString("X2"));
            }

            return returnString.ToString();
        }

        public static string GetReverse(this string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static SecureString ToSecureString(this string text)
        {
            var secureText = new SecureString();

            if (text.Length > 0)
            {
                foreach (var caracter in text.ToCharArray())
                {
                    secureText.AppendChar(caracter);
                }
            }

            return secureText;
        }
    }
}
