using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        public void Add(Product product)
        {
            
            Console.WriteLine("Ürün Id :"+ product.Id);
            Console.WriteLine("Ürün CategoryId :"+ product.CategoryId);
            Console.WriteLine("Ürün Adı :"+ product.ProductName);
            Console.WriteLine("Ürün Fiyatı :"+ product.UnitPrice);
            Console.WriteLine("Ürün Stok Durumu :"+ product.UnitsInStock);
        }
    }
}
