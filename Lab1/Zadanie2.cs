using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Zadanie2
    {
        public static void Uruchom()
        {
            double[] liczby = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                liczby[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double iloczyn = 1;
            double min = liczby[0];
            double max = liczby[0];

            for (int i = 0; i < 10; i++)
            {
                suma += liczby[i];
                iloczyn *= liczby[i];

                if (liczby[i] < min) min = liczby[i];
                if (liczby[i] > max) max = liczby[i];
            }

            double srednia = suma / 10.0;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Iloczyn: {iloczyn}");
            Console.WriteLine($"Średnia: {srednia}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maksimum: {max}");
        }

    }
}
