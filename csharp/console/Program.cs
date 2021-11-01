  using System;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("adınızı girin:");
            string name= Console.ReadLine();
            Console.WriteLine("soyadınızı girin:");
            string surname= Console.ReadLine();
            
            Console.WriteLine("merhaba" + name + " " + surname);
        }
    }
}
