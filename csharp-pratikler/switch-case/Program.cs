﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month) 
            {
                case 1:
                    Console.WriteLine("Ocak ayındasın.");
                    break;
                case 2:
                    Console.WriteLine("şubat");
                    break;
                case 4:
                    Console.WriteLine("nisan");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 5:
                    Console.WriteLine("mayıs");
                    break;
                default:
                    Console.WriteLine("yanlış veri girdisi.");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış ayındasın.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahardasın.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındasın.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahardasın.");
                    break;
                default:
                break;
            }

        }
    }
}
