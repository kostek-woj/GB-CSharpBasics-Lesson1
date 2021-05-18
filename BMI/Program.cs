/************************************************************************************************
Константин Войцеховский

Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class BMI
    {
        static void Main(string[] args) {
            
            Console.OutputEncoding = Encoding.Unicode;
            int initialConsoleCursorSize = Console.CursorSize;
            ConsoleColor initialConsoleForegroundColor = Console.ForegroundColor;
            Console.CursorSize = 100;

            Console.Write("Welcome to BMI Assessor!");

            Console.Write("Please enter your height (m): ");
            String height = Console.ReadLine();

            Console.Write("Enter your weight (kg): ");
            String weight = Console.ReadLine();

            Double indexBMI = Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(height), 2);

            Console.WriteLine("Your BMI index is {0:F2}", indexBMI);

            if (indexBMI >= 30) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uh-oh, you are obese... Please seek some help!");
            }
            else if (indexBMI <= 30 && indexBMI >= 25) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hmm... You seem a bit overweight...");
            } else if (indexBMI <= 25 && indexBMI >= 18.5) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey! Your weight is totally healthy. Congrats!");
            } else if (indexBMI <= 18.5 && indexBMI >= 16) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ts-ts-ts... You look thin...");
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quick! Give him something to eat!");
            }

            Console.ForegroundColor = initialConsoleForegroundColor;
            Console.CursorSize = initialConsoleCursorSize;

        }
    }
}
