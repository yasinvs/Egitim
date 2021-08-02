using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5.Ders2.OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {

            krediManager.Hesapla();
        }
    }
}
