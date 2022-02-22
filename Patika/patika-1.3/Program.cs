using System;

namespace Patika.bir.uc
{
    class Patika
    {
        static int kelimeAdedi;
        static string[] kelime;
        static void Main(string[] args)
        {
            sayiIste();
            DiziDoldur();
            Yazdir();

        }

        private static void Yazdir()
        {
            Console.WriteLine("KELİMELER TERSTEN YAZDIRILIYOR");
            
                for (int i = kelimeAdedi-1; i>=0; i--)
                {
                 Console.WriteLine(kelime[i]);   
                }
                Console.WriteLine();
            
        }

        private static void DiziDoldur()
        {
            bool kelimeBos = false;
            kelime = new string[kelimeAdedi];
            

            for (int i = 0; i < kelimeAdedi; i++)
            {
                Console.WriteLine($"{i+1}. kelimeyi girin");
                kelime[i] = Console.ReadLine();
                while (!kelimeBos)
                {
                    if (kelime[i] == "")
                    {
                        Console.WriteLine("Lütfen kelime girin");
                        kelime[i] = Console.ReadLine();
                        kelimeBos = false;

                    }
                    else
                    {
                        kelimeBos = true;
                    }
                }
            }
        }

        private static void sayiIste()
        {
            bool bayrak = false;

            Console.WriteLine("Lütfen girmek istediğiniz kelime miktarını girin");

            while (!bayrak)
            {
                try
                {
                    bayrak = true;
                    kelimeAdedi = Convert.ToInt32(Console.ReadLine());

                    if (kelimeAdedi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif değer girin");
                        bayrak = false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen SAYI girin");
                    bayrak = false;
                }
            }

        }
    }
}