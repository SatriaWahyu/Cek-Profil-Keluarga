using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.AbstracInterface
{
    class MakananPedas : IMakanan
    {
        public void Makanan()
        {
            Console.WriteLine("Suka Makan Pedas");
            Console.WriteLine("1> Seblack");
            Console.WriteLine("2> Ayam geprek");
            Console.WriteLine("3> Ceker pedas");
            Console.WriteLine("4> Oseng mercon");
        }
    }
}
