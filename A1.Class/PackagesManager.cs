using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.Class
{
    class PackagesManager
    {
        public void Add(Packages package)
        {
            Console.WriteLine("Kayıt eklendi... {0}", package.adi);
        }

        public void Delete(Packages packages)
        {
            Console.WriteLine("Kayıt silindi... {0}", packages.adi);
        }
    }
}
