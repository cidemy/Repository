using System;

namespace Application2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            string kitap1 = "C# programlama";

            string kitap2= "Mvc Dunyası";
            string[] kitaplar = new string[] { "C# programlama", "mvc dünyası" };
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(kitaplar[i]);
            }
        }
    }
}
