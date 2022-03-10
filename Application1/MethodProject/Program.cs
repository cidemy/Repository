using System;

namespace MethodProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "Akıllı Kol Saati";
            double ProductPrize = 277.99;
            string ProductDesc = "Mi Akıllı Kol Saati-956";

            string[] urunler = new string[] { "elma", "armut", "cilek" };
            Product urun1=new Product();
            urun1.ProductName="yogurt1kg";
            urun1.ProductPrice = 15.95;
            urun1.ProductDescription = "tava yogurt";

            Product urun2 = new Product();
            urun2.ProductName = "tozseker";
            urun2.ProductPrice = 19.99;
            urun2.ProductDescription = "kristal seker";

            Product[] products=new Product[] { urun1, urun2 };

          

        }
    }
}
