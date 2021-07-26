using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4.Ders1.OOP1
{
    class ProductManager
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi...");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi...");
        }
        

    }
}
