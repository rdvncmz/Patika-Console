using System;
using System.Collections.Generic;

namespace koleksiyonlarList
{

    class Program
    {
        static int[] sayilar = new int[20];
        static List<int> asal;
        static List<int> asalDegil;
        static void Main(string[] args)
        {
            SayiAl();
            Kontrol();
            Sırala();
            Yazdir();
        }

        private static void Yazdir()
        {
            int toplam = 0;
            Console.WriteLine("Asal Sayılar");

            foreach (var item in asal)
            {
                Console.WriteLine(item);
                toplam = toplam + item;
            }

            Console.WriteLine("\n Asal sayı miktarı: " + asal.Count);
            Console.WriteLine("Asal sayıların ortalaması: " + toplam/asal.Count);
            
            Console.WriteLine();

            Console.WriteLine("------------------");
            
            Console.WriteLine();
            
            Console.WriteLine("Asal Olmayan Sayılar");
            toplam = 0;
            foreach (var item in asalDegil)
            {
                Console.WriteLine(item);
                toplam = toplam + item;
            }

            Console.WriteLine("\n Asal olmayan sayı miktarı: " + asalDegil.Count);
            Console.WriteLine("Asal olmayan sayıların ortalaması: " + toplam/asalDegil.Count);



        }

        private static void Sırala()
        {

            asal.Sort();
            asal.Reverse();

            asalDegil.Sort();
            asalDegil.Reverse();

        }

        private static void Kontrol()
        {
            asal = new List<int>();
            asalDegil = new List<int>();

            bool bayrak = false;

            for (int i = 0; i < 20; i++)
            {
                bayrak = false;

                for (int j = 2; j < sayilar[i]; j++)
                {
                    if (sayilar[i] % j == 0)
                    {
                        asalDegil.Add(sayilar[i]);
                        bayrak = true;
                        break;
                    }
                }

                if (!bayrak)
                {
                    asal.Add(sayilar[i]);
                }
            }
        }

        private static void SayiAl()
        {
            for (int i = 0; i < 20; i++)
            {
            bool bayrak = true;
                Console.WriteLine($"{i + 1}. sayıyı girin");

                while (bayrak)
                {
                    try
                    {

                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        bayrak = false;

                        if (sayilar[i] <= 0)
                        {
                            Console.WriteLine("Lütfen 0' dan büyük değer girin");
                            bayrak = true;

                        }

                    }
                    catch (System.Exception)
                    {
                            Console.WriteLine("Lütfen ''SAYI'' girin");
                        bayrak = true;
                    }
                }

            }
        }
    }
}
