using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atamam ve işlemli atama.
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);


            //mantık operatörleri
            // ||, &&, ! 
            
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
            Console.WriteLine("süper");

            if(isSuccess || isCompleted)
            Console.WriteLine("güzel");

            if(isSuccess && !isCompleted)
            Console.WriteLine("iyi");

            //ilişkisel operatörler
            // <,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool sonuç = a<b;
            Console.WriteLine(sonuç);
            sonuç = a>b;
            Console.WriteLine(sonuç);
            sonuç = a>=b;
            Console.WriteLine(sonuç);
            sonuç = a<=b;
            Console.WriteLine(sonuç);
            sonuç = a==b;
            Console.WriteLine(sonuç);
            


            // aritmetik operatörler
            //+,-,*,/

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 ++; 
            Console.WriteLine(sonuc1);


            // % : mod alma.

            int sonuc2 =20%3;
            Console.WriteLine(sonuc2);
            
        }
    }
}
