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

        private static void EnKucuk()
        {
            Console.WriteLine("İki ortalamanın toplamı" + kucukOrtalama + buyukOrtalama);
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

            Console.WriteLine("Üç büyük sayının ortalaması : " + kucukOrtalama / 3);
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

            Console.WriteLine("Üç büyük sayının ortalaması : " + buyukOrtalama / 3);

        }

        private static void SayiAl()
        {
            bool bayrak = false;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. sayıyı giriniz");

                try
                {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}
