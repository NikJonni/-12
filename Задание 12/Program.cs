using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("          Длина окружности равна = {0:f1}", Circle.ToLengthCircle(r));
            Console.WriteLine("          Площадь окружности равна = {0:f1}", Circle.ToSquareCircle(r));
            Console.Write("Введите кординату 'x' точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату 'y' точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату 'x' центра окружности: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату 'y' центра окружности: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double point = Circle.ToPointCircle(r, x1, y1, x2, y2);
            Console.ReadLine();
        }
    }
    class Circle
    {
        public static double ToLengthCircle(double radius)
        {
            double length = 2 * Math.PI * radius;
            return length;
        }
        public static double ToSquareCircle(double radius)
        {
            double square = Math.PI * Math.Pow(radius, 2);
            return square;
        }
        public static double ToPointCircle(double radius, double xPoint, double yPoint, double xCentr, double yCentr)
        {
            double point = Math.Pow(xPoint - xCentr, 2) + Math.Pow(yPoint - yCentr, 2);
            if (point <= Math.Pow(radius, 2))
                Console.WriteLine("          Точка находится в пределах окружности");
            else
                Console.WriteLine("          Точка находится за пределами окружности");
            return point;
        }
    }
}

