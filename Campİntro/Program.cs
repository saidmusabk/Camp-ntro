using System;

namespace Campİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenliği
            //Do Not Repeat Yourself - kendşnş tekrarlama
            //Değer tutucu - Alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Yükseliş oku");
            }
            else
            {
                Console.WriteLine("Değişmedi oku");
            }

            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Kayıt Ol Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);


            Console.ReadLine();
        }
    }
}
