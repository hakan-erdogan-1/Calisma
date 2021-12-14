using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }             // Primary Key
        public int CategoryId { get; set; }     // ürün kategori Id
        public string ProductName { get; set; } // Ürün adı
        public double UnitPrice { get; set; }   // Ürün Fiyatı
        public int UnitsInStock { get; set; }   // ürün stok adedi
    }
}
