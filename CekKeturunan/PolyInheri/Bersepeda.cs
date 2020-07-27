using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.PolyInheri
{
    class Bersepeda : KelasInduk
    {
        public override void Hoby()
        {
            Console.WriteLine("Hoby bersepeda");
        }
        public override void BerapaKali()
        {
            Console.WriteLine("Bersepeda 2x dalam seminggu");
        }
    }
}
