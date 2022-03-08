using System;

namespace Application2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kitap1 = "C# programlama ";
            string kitap2 = "mvc dünyası";
            string[] kitaplar = new string[] { "C# programlama ", "mvc dünyası" };
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine(kitaplar[i]);
            }
            

            
          
        }
    }
}
