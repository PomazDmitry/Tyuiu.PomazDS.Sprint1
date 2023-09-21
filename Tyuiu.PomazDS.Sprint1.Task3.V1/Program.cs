using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PomazDS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.PomazDS.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Помаз Д.С | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Помаз Дмитрий Сергеевич | ИИПб-23-2                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные         *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране      *");
            Console.WriteLine("* Расчеты: Объявите необходимые переменные и напишите программу           *");
            Console.WriteLine("* вычисления объема цилиндра, предполагающий ввод исходных данных.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double r, h;

            Console.WriteLine("Введите радиус цилиндра");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра");
            h = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CylinderVolume(r,h));

            Console.ReadKey();
        }
    }
}
