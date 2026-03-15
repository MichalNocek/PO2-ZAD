using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
   

class Zadanie1
    {
        public static void Uruchom()
        {
            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe (a wynosi 0).");
                return;
            }

            double delta = (b * b) - (4 * a * c);
            Console.WriteLine($"Delta = {delta}");

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x0 = -b / (2 * a);
                Console.WriteLine($"x0 = {x0}");
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
            }
        }
    }

}

