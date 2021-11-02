using System;

namespace console_deneme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminiz gir:");
            string name = Console.ReadLine();
            Console.WriteLine("soyadını gir:");
            string surname = Console.ReadLine();

            Console.WriteLine("merhaba " + name + "  " + surname);
            
        }
    }
}
