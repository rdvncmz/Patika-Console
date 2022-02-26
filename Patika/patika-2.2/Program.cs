using System;

namespace patika_2._2
{
    class Program
    {
        static int[] sayilar = new int[20];
        static int kucukOrtalama = 0;
        static int buyukOrtalama = 0;
        static void Main(string[] args)
        {
            SayiAl();
            EnBuyuk();
            EnKucuk();
            Toplam();
        }

        private static void Toplam()
        {
            buyukOrtalama += kucukOrtalama;
            Console.WriteLine("İki ortalamanın toplamı " + buyukOrtalama);
        }

        private static void EnKucuk()
        {
            Array.Sort(sayilar);

            for (int i = 0; i <= 2; i++)
            {
                kucukOrtalama = kucukOrtalama + sayilar[i];

                Console.Write($"En küçük {i + 1}. sayı: ");
                Console.Write(sayilar[i] + "\n");
            }
                kucukOrtalama /= 3;
            Console.WriteLine("Üç büyük sayının ortalaması : " + kucukOrtalama);
        }

        private static void EnBuyuk()
        {
            Array.Sort(sayilar);
            Array.Reverse(sayilar);

            for (int i = 0; i <= 2; i++)
            {
                buyukOrtalama = buyukOrtalama + sayilar[i];

                Console.Write($"En büyük {i + 1}. sayı: ");
                Console.Write(sayilar[i] + "\n");
            }
            buyukOrtalama /= 3;
            Console.WriteLine("Üç büyük sayının ortalaması : " + buyukOrtalama);

        }

        private static void SayiAl()
        {
            bool bayrak = false;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");
                bayrak = true;

                while (bayrak)
                {
                    try
                    {
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        bayrak = false;
                    }
                    catch
                    {
                        Console.WriteLine("Lütfen SAYI girin");
                        bayrak = true;
                    }
                }
            }
        }
    }
}
