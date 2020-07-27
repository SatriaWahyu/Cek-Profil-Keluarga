using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.AbstracInterface
{
    class MakananManis : IMakanan
    {
        public void Makanan()
        {
            Console.WriteLine("Suka Makan Manis");
            Console.WriteLine("1> Manisan");
            Console.WriteLine("2> Martabak");
            Console.WriteLine("3> Gudeg");
        }
    }
}
