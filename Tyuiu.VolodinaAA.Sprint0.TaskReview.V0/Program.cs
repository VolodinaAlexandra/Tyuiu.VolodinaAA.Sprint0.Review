using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.VolodinaAA.Sprint0.TaskReview.V0
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.Title = "Спринт#0 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#0                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по проекту                             *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет (x+y+z)*5        *");
            Console.WriteLine("* и выводит результат на экран.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* x=1; y=2; z=3                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (x+y+z)*5 = " + DataService.Calc(1, 2, 3) + "                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
