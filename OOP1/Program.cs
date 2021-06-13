using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 250;
            product1.UnitsInStock = 10;

            Product product2 = new Product
            {
                Id = 3,
                CategoryId = 3,
                ProductName = "Bilgisayar",
                UnitPrice = 5500,
                UnitsInStock = 23
            };

            
          
            /* Add Methodunu Çalıştır.. */
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine("***********************");
            productManager.Add(product2);

        }
    }
}
