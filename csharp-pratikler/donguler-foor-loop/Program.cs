﻿using System;

namespace donguler_foor_loop
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Ekrandan girilen sayıya kadar olan tek saılarını ekrana yazdır.
/*            Console.Write("lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamının yazdırılması.
            Console.Write("lütfen bir sayı giriniz:");
            int sayı = int.Parse(Console.ReadLine());
            int tektoplam  = 0;
            int cifttoplam = 0;
            for (int i = 1; i <= sayı; i++)
            {
                if (i%2 == 1)
                    tektoplam += i; //tektoplam = tektoplam + i
                else
                    cifttoplam += i; //çiftoplam = çifttoplam + i
            }
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + cifttoplam);

            ALT SATIRLARI DENEMEK İÇİN KAPATILDI */ 
        
            //break, continue 

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    break;
                Console.WriteLine(i);
            }

             for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
