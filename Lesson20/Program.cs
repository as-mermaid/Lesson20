using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());    

            MyDelegate myDelegate = GetCircleLenth;
            Console.WriteLine($"Длина окружности {myDelegate(r)}");

            myDelegate = GetCircleArea;
            Console.WriteLine($"Площадь круга {myDelegate(r)}");

            myDelegate = GetSphereVolume;
            Console.WriteLine($"Объем шара {myDelegate(r)}");

            Console.ReadKey();
        }

        static double GetCircleLenth(double r) => 2 * Math.PI * r;
        static double GetCircleArea(double r) => Math.PI * r * r;
        static double GetSphereVolume(double r) => (double)4 / 3 * Math.PI * r * r * r;

    }
}
