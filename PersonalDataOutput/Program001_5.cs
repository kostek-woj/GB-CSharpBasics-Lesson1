/************************************************************************************************
Константин Войцеховский

а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace PersonalDataOutput
{
    class Program001_5
    {
        static int consoleWidth = Console.WindowWidth;
        static int consoleHeight = Console.WindowHeight;


        static void PrintCenteredAtY(String text, int y) {
            Console.SetCursorPosition((consoleWidth - text.Length) / 2, y);
            Console.WriteLine(text);
        }


        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Shine in all your glory in Console!");

            Console.Write("Enter your first name: ");
            String nameFirst = Console.ReadLine();

            Console.Write("Enter your last name: ");
            String nameLast = Console.ReadLine();

            Console.Write("Enter the name of your current city: ");
            String city = Console.ReadLine();

            
            int positionTop = (consoleHeight - 3) / 2;

            Console.Clear();
            
            // A + B
            //Console.SetCursorPosition((consoleWidth - nameFirst.Length) / 2, positionTop++);
            //Console.WriteLine(nameFirst);

            //Console.SetCursorPosition((consoleWidth - nameLast.Length) / 2, positionTop++);
            //Console.WriteLine(nameLast);

            //Console.SetCursorPosition((consoleWidth - city.Length) / 2, positionTop);
            //Console.WriteLine(city);

            // C
            PrintCenteredAtY(nameFirst, positionTop++);
            PrintCenteredAtY(nameLast, positionTop++);
            PrintCenteredAtY(city, positionTop);

            Console.SetCursorPosition((consoleWidth - 32) / 2, positionTop + 7); // Position of "Press any key..."
            MyClass.Pause("");

            Console.Clear();
            MyClass.PrintCenteredAtXY("Look at me!");
            MyClass.Pause("And press any key to exit...");

        }
    }
}
