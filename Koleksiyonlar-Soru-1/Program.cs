using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler instance = new();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                int sayi = instance.PozitifSayiMi($"Lütfen {i+1}. sayıyı girin: ");
                bool sonuc = instance.AsalMi(sayi);
                if(sonuc == true)
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanlar.Add(sayi);
            }
            asalSayilar.Sort();
            asalOlmayanlar.Sort();
            System.Console.Write("Asal olanlar: ");
            foreach (var item in asalSayilar)
                System.Console.Write(item + " ");
            
            System.Console.WriteLine(" ");
            System.Console.Write("Asal olmayanlar: ");
            foreach (var item in asalOlmayanlar)
                System.Console.Write(item + " ");
            
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Asal sayı adedi: {asalSayilar.Count}");
            System.Console.WriteLine($"Asal olmayan sayı adedi: {asalOlmayanlar.Count}");

            int aSayilarToplam = 0;
            int aSayiOlmayanlarToplam = 0;

            foreach (var item in asalSayilar)
                aSayilarToplam += (int)item;                
            
            foreach (var item in asalOlmayanlar)
                aSayiOlmayanlarToplam += (int)item;

            
            if (asalSayilar.Count != 0)
            {
                System.Console.WriteLine("Asal sayıların toplamının ortalaması: " + (aSayilarToplam / asalSayilar.Count));
            }
            if (asalOlmayanlar.Count != 0)
            {
                System.Console.WriteLine("Asal olmayan sayıların toplamının ortalaması: " + aSayiOlmayanlarToplam / asalOlmayanlar.Count);
            }    

        }
    }
    class Islemler
    {
        public int PozitifSayiMi(string text)
        {
            int n = 0;
            bool result = true;
            do
            {
                System.Console.Write(text);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n>=0)
                    {
                        result = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Lütfen pozitif bir sayı girin!");
                        result = true;
                    }
                }
                catch (System.Exception)
                {   
                    System.Console.WriteLine("Lütfen bir sayı girin!");
                }   
            } while (result);
            return n;
        }

        public bool AsalMi (int n)
        {
            int kontrol = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    kontrol++;
            }
            if(kontrol != 0)
                return false;
            else
                return true;
        }
    }
}
