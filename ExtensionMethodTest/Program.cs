using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTest
{
    static class StringExtension
    {
        public static string FiveString( this string msg ) => msg.Substring(0, 10);
        public static string FifyString(this string msg) => msg.Substring(0, 18);
        public static string AddEllipsis(this string msg) => msg + "...";
        public static string AddEllipsis(this string msg, string ellipsis) => $"{msg}{ellipsis}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Willkommen Deutschland";
            Console.WriteLine(message);
            Console.WriteLine(message.FiveString());
            Console.WriteLine(message.FifyString());
            Console.WriteLine(message.FifyString().AddEllipsis());
            Console.WriteLine(message.FifyString().AddEllipsis("...,"));
        }
    }
}
