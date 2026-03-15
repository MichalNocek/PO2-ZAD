using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Zadanie5
    {
        public static void Uruchom()
        {
            Console.Write("Podaj ilosc liczb (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] liczby = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Podaj liczbe {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        double temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;
                    }
                }
            }
             
            Console.WriteLine("Posortowane liczby:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
