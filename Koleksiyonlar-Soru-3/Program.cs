using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler instance = new();

            ArrayList sesLiOlanlar = new ArrayList();

            string cumle = instance.YaziAl("Lütfen cümleyi girin: ");
            
            string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliHarfler.Contains(cumle[i]))
                {
                    sayac++;
                    sesLiOlanlar.Add(cumle[i]);
                }
            }
            System.Console.WriteLine($"Cümle içerisinde {sayac} adet sesli harf bulunmaktadır.");
            System.Console.Write("Cümle içerisindeki sesli harfler: ");
            foreach (var item in sesLiOlanlar)
            {
                System.Console.Write(item + " ");
            }
        }
    }
    class Islemler
    {
        public string YaziAl(string text)
        {
            string giris;

            while (true)
            {
                Console.Write(text);
                giris = Console.ReadLine();
                bool kontrol = true;

                foreach (char chr in giris)
                {
                    if (Char.IsNumber(chr))
                    {
                        Console.WriteLine("Hatali giris yapildi. Tekrar deneyin. ");
                        kontrol = false;
                        break;
                    }
                }
                if (kontrol == true)
                {
                    return giris;
                }
            }
        }
    }
}
