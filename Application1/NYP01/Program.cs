using MethodProject;
using System;

namespace NYP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.usage 

           Product product = new Product();
            product.Id = 1;
            product.CategoryId= 1;
            product.ProductName = "makarna 500gr.";
            product.UnitPrice = 5.95;
            product.UnitInStock = 600;

            //2.usage

            Product product2 = new Product { Id = 2, CategoryId = 2, ProductName = "çikolata" ,UnitPrice=3.99,UnitInStock=1400};

            CartManager Cart = new CartManager();
            Cart.UrunEkle("çilek","yerliceilek",5);

        }
    }
}
