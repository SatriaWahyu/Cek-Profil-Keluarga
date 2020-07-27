using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.PolyInheri
{
    class Berenang : KelasInduk
    {
        public override void Hoby()
        {
            Console.WriteLine("Hoby Berenang");
        }
        public override void BerapaKali()
        {
            Console.WriteLine("Berenang 5x dalam seminggu");
        }
    }
}
