using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Adı : "+product.Adi);
            Console.WriteLine("Ürün Fİyatı : "+product.Price);
            Console.WriteLine("Ürün Açıklaması : "+product.Aciklama);
            Console.WriteLine("Stok Adeti : "+product.StokAdeti);
            Console.WriteLine("************************");
        }
    }
}
