using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Price = 10;
            product1.Aciklama = "Taze Elma";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Muz";
            product2.Price = 15;
            product2.Aciklama = "Taze Muz";

            Product product3 = new Product() {
                Id = 3,
                Adi = "Karpuz",
                Price = 8,
                Aciklama = "Diyarbakır Karpuzu",
                StokAdeti = 5
            };

            
       
            Product[] products = new Product[] { product1, product2, product3, };
           
            


            foreach (var item in products)
            {
                Console.WriteLine("Ürün Adı : "+item.Adi);
                Console.WriteLine("Ürün Fiyati : "+item.Price);
                Console.WriteLine("Ürün Acıklaması : "+item.Aciklama);
                Console.WriteLine("Stok Adeti :"+item.StokAdeti);
                
                
                Console.WriteLine("**************");

            }

            Console.WriteLine("---------------- Mettotlar---------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);



        }
    }
}
