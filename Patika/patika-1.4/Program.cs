using System;

namespace Patika.bir.dort
{
    /*
    cümle iste
    boşluklardan ayır
    diziye ekle
    dizi sayısından bir çıkar cümlenin lengthinden çıkar
    */
    class Patika
    {
        static string cumle = "";
        static List<string> cumleKelime = new List<string>();
        static void Main(string[] args)
        {
            CumleGir();
            Parcala();
            Islem();
        }

        private static void Islem()
        {
            int bos = 0;
            int harf;
            int bosluk;

            harf = cumle.Length;
            bosluk = cumleKelime.Count - 1;
            harf = harf - bosluk;
            

            Console.WriteLine("Hesaplanıyor..");

            foreach (var item in cumleKelime)
            {
                if(item == ""){
                    bos ++;
                }
            }
            Console.WriteLine($"{cumleKelime.Count - bos} tane kelime var");
            Console.WriteLine($"{harf} tane harf var");
            
        }

        private static void Parcala()
        {
            string[] cumleK = cumle.Split(" ");

            cumleKelime = new List<string>(cumleK);
        }

        private static void CumleGir()
        {
            bool bayrak = false;

            Console.WriteLine("Cümle girin");

            while (!bayrak)
            {
                cumle = Console.ReadLine();

                if (cumle == "" || cumle[0] == ' ')
                {
                    Console.WriteLine("Lütfen \"cümle gir\" kısmını boş bırakmayın ve boşluk ile başlamayın");
                    bayrak = false;
                }
                else
                {
                    bayrak = true;
                }
            }

        }
    }
}