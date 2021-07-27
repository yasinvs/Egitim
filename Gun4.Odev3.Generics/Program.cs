using System;
using System.Collections.Generic;

namespace Gun4.Odev3.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kaynak ; https://www.ismailgursoy.com.tr/generic-type-collections-generic-tipinde-koleksiyonlar/
            // Klasik tipli koleksiyon sınıfları içerisine aldıkları elemanların hepsini object türünde saklar. Ve bu durum performans kaybına sebep olur, çünkü boxing ve unboxing işlemleri yapılmaktadır.
            // Performans kaybının yanı sıra aynı zamanda tür güvenliği (type safety) ‘de klasik tip koleksiyonlarda söz konusu değildir. .NET 2.0 ile birlikte System.Collections.Generic isim alanında bütün koleksiyonların Generic tipli versiyonları mevcuttur. Bu sayede generic koleksiyonlar ile performans daha da arttırılmış ve tür güvenliği de sağlanmıştır.

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> // Generic Class --- T (Type) Tip belirtmek gerekiyor
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
