using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class MyClass
    {

        static int consoleWidth = Console.WindowWidth;
        static int consoleHeight = Console.WindowHeight;

        public static void PrintCenteredAtXY(String text) {
            Console.SetCursorPosition((consoleWidth - text.Length) / 2, consoleHeight / 2);
            Console.WriteLine(text);
        }

        public static void Pause(string message) {
            Console.Write(message);
            Console.ReadKey();
        }
    }
}
