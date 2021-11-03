using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 ="x";
            object o2 ='y';
            object o3 =3;
            object o4 = 2.36;

            // Değişken dönüşümleri
            string s ="20";
            int i = 20;

            string yeniDeger = s + i.ToString();

            Console.WriteLine(yeniDeger);

            int i1 = i + Convert.ToInt32(s);
            Console.WriteLine(i1);  //çıktısı 40 
            
        }
    }
}
