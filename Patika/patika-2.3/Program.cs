using System;
using System.Collections.Generic;

namespace patika_2._3
{
    class Program
    {
        static string cumle;
        static List<char> harf;
        static void Main(string[] args)
        {
            CumleAl();
            Kontrol();
            Yazdir();
        }

        private static void Yazdir()
        {
            foreach (var item in harf)
            {
                Console.Write(item + " - ");
            }
        }

        private static void Kontrol()
        {
            harf = new List<char>();
            foreach (var item in cumle)
            {
                if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
                {
                    harf.Add(item);
                }
            }
        }

        private static void CumleAl()
        {
            Console.WriteLine("Cümleyi girin");
            cumle = Console.ReadLine().ToLower();
        }
    }
}
