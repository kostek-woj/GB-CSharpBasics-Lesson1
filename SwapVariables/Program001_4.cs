/************************************************************************************************
Константин Войцеховский

Написать программу обмена значениями двух переменных:
  а) с использованием третьей переменной;
  б) *без использования третьей переменной.
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVariables
{
    class Program001_4
    {
        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("SWAPBLASTER - it will swap two variables in a blink of an eye!");

            Console.Write("Enter variable A: ");
            String aVarInput = Console.ReadLine();

            Console.Write("Enter variable B: ");
            String bVarInput = Console.ReadLine();

            double aVar = Convert.ToDouble(aVarInput);
            double bVar = Convert.ToDouble(bVarInput);

            Console.WriteLine("SOURCE: A = {0} and B = {1}", aVar, bVar);
            Console.Write("Press ENTER to swap!");
            Console.Read();

            // Task A
            //double tempVar = aVar;
            //aVar = bVar;
            //bVar = tempVar;

            // Task B
            aVar += bVar;
            bVar = aVar - bVar;
            aVar = aVar - bVar;

            Console.WriteLine("RESULT: A = {0} and B = {1}", aVar, bVar);
        }
    }
}
