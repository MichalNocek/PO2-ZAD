using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Zadanie4
    {
        public static void Uruchom()
        {
            while (true)
            {
                Console.Write("Podaj liczbę całkowitą: ");
                int liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    break;
                }
            }
        }
    }
}
