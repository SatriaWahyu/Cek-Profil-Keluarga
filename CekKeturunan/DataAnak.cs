using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan
{
    class DataAnak
    {
        public int noHP;
        public string Email;

        public void tampilDataAnak()
        {
            Console.WriteLine("Nomer HP : +62" + noHP);
            Console.WriteLine("Email : " + Email);
        }
    }
}
