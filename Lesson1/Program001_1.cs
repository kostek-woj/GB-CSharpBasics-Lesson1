/************************************************************************************************
Константин Войцеховский

Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
В результате вся информация выводится в одну строчку:
  а) используя склеивание;
  б) используя форматированный вывод;
  в) используя вывод со знаком $.
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Program001_1
    {
        static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            int initialConsoleCursorSize = Console.CursorSize;
            Console.CursorSize = 100;

            Console.WriteLine("Welcome to \"Lё Questionnaire\"!\n\r");

            Console.Write("What is your first name? ");
            String userFirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            String userLastName = Console.ReadLine();

            Console.Write("What is your age? ");
            String userAge = Console.ReadLine();

            Console.Write("What is your height? ");
            String userHeight = Console.ReadLine();

            Console.Write("What is your weight? ");
            String userWeight = Console.ReadLine();

            double userWeightD = Convert.ToDouble(userWeight);
            double userHeightD = Convert.ToDouble(userHeight);
            int userAgeI = Convert.ToInt32(userAge);

            // A + B
            //Console.WriteLine("Hello, " + userFirstName + " " + userLastName + "! "
            //                    + "{0:N2} kg, {1:N2} tall, {2} years old!",
            //                    userWeightD, userHeightD, userAgeI);

            // C
            Console.WriteLine($"Hello, {userFirstName} {userLastName}! {userWeightD:N2} kg, {userHeightD:N2} tall, {userAgeI} years old!");



            Console.CursorSize = initialConsoleCursorSize;
        }
    }
}
