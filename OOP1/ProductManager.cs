using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager // ürün ile ilgili operasyonlar yer alacak
    {
        public void Add(Product product )  // product parametreli Add metodu
        {
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);
            Console.WriteLine("-----------");
        }
        public void Update(Product product)
        {
            Console.WriteLine("Güncellendi" + product.ProductName);
        }
    }
}
