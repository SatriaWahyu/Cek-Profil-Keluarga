using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.AbstracInterface
{
    class MakananAsin : IMakanan
    {
        public void Makanan()
        {
            Console.WriteLine("Suka Makan Asin");
            Console.WriteLine("1> Kerupuk");
            Console.WriteLine("2> Ikan asin");
            Console.WriteLine("3> Telur asin");
        }
    }
}
