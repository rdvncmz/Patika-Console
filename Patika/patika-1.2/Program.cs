using System;

namespace Patika.bir.iki
{
    class Patika
    {
        static int ilkDeger;
        static int ikinciDeger;
        static int[] kontrolDeger;
        static void Main(string[] args)
        {
            DegerAl();
            DiziAl();
            Kontrol();
        }

        private static void Kontrol()
        {
            foreach (var item in kontrolDeger)
            {
                if (item == ikinciDeger || item % ikinciDeger == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void DiziAl()
        {
            int kontrol;

            kontrolDeger = new int[ilkDeger];

            for (int i = 0; i < ilkDeger; i++)
            {
                bool bayrak = false;
                Console.WriteLine($"{i + 1}. değeri girin");

                while (!bayrak)
                {
                    try
                    {
                        kontrol = Convert.ToInt32(Console.ReadLine());

                        if (kontrol < 0)
                        {
                            Console.WriteLine("Lütfen pozitif değer girin");
                            bayrak = false;
                        }
                        else
                        {
                            kontrolDeger[i] = kontrol;
                            bayrak = true;
                        }

                    }
                    catch (System.Exception)
                    {
                        bayrak = false;
                        Console.WriteLine("Lütfen SAYI girin");
                    }
                }


            }
        }

        private static void DegerAl()
        {
            bool bayrak1 = false;
            bool bayrak2 = false;
            Console.WriteLine("Kontrol ettirmek istediğiniz değer miktarını girin");

            while (!bayrak1)
            {
                try
                {
                    ilkDeger = Convert.ToInt32(Console.ReadLine());
                    bayrak1 = true;

                    if (ilkDeger < 0)
                    {
                        Console.WriteLine("Lütfen pozitif değer girin");
                        bayrak1 = false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen SAYI girin");
                    bayrak1 = false;
                }
            }


            Console.WriteLine("Karşılaştırmak istediğiniz değeri girin");

            while (!bayrak2)
            {
                try
                {
                    ikinciDeger = Convert.ToInt32(Console.ReadLine());
                    bayrak2 = true;

                    if (ikinciDeger < 0)
                    {
                        Console.WriteLine("Lütfen pozitif değer girin");
                        bayrak2 = false;
                    }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lütfen SAYI girin");
                    bayrak2 = false;
                }
            }
        }
    }
}