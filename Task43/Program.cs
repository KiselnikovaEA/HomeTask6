using System;

namespace HomeTasks_KisEA
{
    class Program       // Программа принимает коэффициенты функций двух прямых
    {                   // и показывает точку их пересечения
        static void Main (string[] args)
        {
            double[] findIntersectionPoint(double k1, double b1, double k2, double b2)
            {
                double[] array = new double[2];
                array[0] = (b2 - b1) / (k1 - k2);
                array[1] = k1 * array[0] + b1;
                return array;
            }

            int countOfIntersectionPoints(double k1, double b1, double k2, double b2)
            {
                if(k1 == k2 && b1 != b2) return 0;
                else if (k1 / k2 == b1 / b2) return 2;
                else return 1;
            }
                Console.WriteLine("Даны два уравнения вида y=kx+b. Введите коэффициенты k и b:");
                Console.Write("k1 = ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("b1 = ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("k2 = ");
                double k2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("b2 = ");
                double b2 = Convert.ToDouble(Console.ReadLine());

                int count = countOfIntersectionPoints(k1, b1, k2, b2);
                if(count == 2) Console.WriteLine("Две прямые совпадают");
                else if(count == 0) Console.WriteLine("Две прямые параллельны");
                else
                {
                    double[] IntersectionPoint = findIntersectionPoint(k1,b1,k2,b2);
                    Console.WriteLine($"Точка пересечания двух прямых: ({IntersectionPoint[0]};{IntersectionPoint[1]})");
                }
        }
    }
}