using System;

namespace Patika.bir.bir
{
    class Patika
    {
        static int sayiAdedi;
        static void Main(string[] args)
        {
            int[] sayiDizi;


            SayiAdediIste();
            sayiDizi = Dondur();
            Kontrol(sayiDizi);

        }

        static void SayiAdediIste()
        {
            bool bayrak = false;
            Console.WriteLine("Kontrol etmemizi istediğiniz sayı adedini giriniz");

            while (!bayrak)
            {
                try
                {
                    sayiAdedi = Convert.ToInt32(Console.ReadLine());
                    bayrak = true;

                    if (sayiAdedi < 0)
                    {
                        Console.WriteLine("Lütfen pozitif sayı girin");
                        bayrak = false;
                    }
                    else
                    {

                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen SAYI girin");
                    bayrak = false;

                }
            }

        }

        static int[] Dondur()
        {
            Console.Clear();

            int[] sayiDizi = new int[sayiAdedi];
            int sayiKontrol;
            for (int i = 0; i < sayiAdedi; i++)
            {
                Console.WriteLine("Kontrol etmemizi istediğiniz sayıyı giriniz");

                bool bayrak = false;
                while (!bayrak)
                {
                    try
                    {
                        sayiKontrol = Convert.ToInt32(Console.ReadLine());
                        bayrak = true;

                        if (sayiKontrol < 0)
                        {
                            Console.WriteLine("Lütfen pozitif sayı girin");
                            bayrak = false;
                        }
                        else
                        {
                            sayiDizi[i] = sayiKontrol;
                        }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Lütfen SAYI girin");
                        bayrak = false;

                    }
                }
            }

            return sayiDizi;


        }

        static void Kontrol(int[] sayiDizi)
        {
            Console.WriteLine("Çift sayılar");
            foreach (var item in sayiDizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

}