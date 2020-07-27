using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.PolyInheri
{
    class KelasInduk
    {
        // properties
        public string Nama { get; set; }

        // method
        public virtual void Hoby()
        {
            Console.WriteLine("Apa Hobymu");
        }
        public virtual void BerapaKali()
        {
            Console.WriteLine("Berapa kali melakukan Hobymu");
        }
    }
}
