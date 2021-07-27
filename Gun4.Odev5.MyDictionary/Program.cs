using System;

namespace Gun4.Odev5.MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Sever");
            myDictionary.Add(2, "Başar");

            //Console.WriteLine(myDictionary.Count);
        }
    }
}