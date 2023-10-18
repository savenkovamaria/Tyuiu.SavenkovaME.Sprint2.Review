using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint2.TaskReview.V2.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.TaskReview.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* СпринтРевью #2                                                                    *");
            Console.WriteLine("* Тема: SprintReview2                                                          *");
            Console.WriteLine("* Задание TaskReview                                                           *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные  *");
            Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y в               * ");
            Console.WriteLine("* заштрихованной области.                                                      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            if (result == true)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) НЕ находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
