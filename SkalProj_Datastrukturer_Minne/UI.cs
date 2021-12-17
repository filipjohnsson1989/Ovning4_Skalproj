using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class UI
    {
        internal static void Clear()
        {
            //Console.CursorVisible = false;
            Console.Clear();
        }
        internal static ConsoleKey GetKey() => Console.ReadKey(intercept: true).Key;
        internal static void AddMessage(string message) => Console.WriteLine(message);
    }
}
