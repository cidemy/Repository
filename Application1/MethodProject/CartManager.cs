using System;
using System.Collections.Generic;
using System.Text;

namespace MethodProject
{
    internal class CartManager
    {
        public void Insert(Product product)
        {
            Console.WriteLine("ürün basarıyla sepete eklendi"+product.ProductName);
        }
       
        public void UrunEkle(string ProductName, string ProductDescription,double ProductPrice)
        {
            Console.WriteLine("ürün basarıyla eklendi:"+ProductName);
        }
    }
}
