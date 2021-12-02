using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Islemler instance = new();

            int[] sayilar = new int[20];
            int[] enKucukSayilar = new int[3];
            int[] enBuyukSayilar = new int[3];
            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = instance.SayiMi($"Lütfen {i+1}. sayi girin: ");

            Array.Sort(sayilar);
            int sayac = 0,sayac1 = 0,sayac2 = 0;
             
            foreach(var item in sayilar)
            {
                if(sayac >=0 && sayac <= 2)
                {
                    enKucukSayilar[sayac1] = item;
                    sayac1++;
                }   
                else if(sayac >= 18 && sayac <=20)
                {
                    enBuyukSayilar[sayac2] = item;
                    sayac2++;
                } 
                sayac++;        
            }
            int enKucukToplam = 0, enBuyukToplam = 0;
            foreach(var item in enKucukSayilar)
                enKucukToplam +=item;
            foreach(var item in enBuyukSayilar)
                enBuyukToplam += item;
            
            Console.WriteLine("En küçük sayıların ortalaması: " + (double)enKucukToplam/3);
            Console.WriteLine("En büyük sayıların ortalaması: " + (double)enBuyukToplam/3);
            double ortToplam = (enKucukToplam/3)+(enBuyukToplam/3) ;
            Console.WriteLine("En büyük ve en küçük sayıların ortalamalarının toplamı: " + ortToplam );

        }
    }

    class Islemler
    {
        public int SayiMi(string text)
        {
            int n = 0;
            bool result = true;
            do
            {
                System.Console.Write(text);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    result = false;
                }
                catch (System.Exception)
                {   
                    System.Console.WriteLine("Lütfen bir sayı girin!");
                }   
            } while (result);
            return n;
        }
    }
}
