using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3.Ders1.Metotlar
{
    public class Urun
    {
        // iki tip class kullanımı var
        // bu şekilde özellik saklayan 
        // Property - Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati  { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
