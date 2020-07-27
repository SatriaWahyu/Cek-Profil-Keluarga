using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan
{
    class DataOrangtua
    {
        public string NamaBapak { get; set; }
        public string NamaIbu { get; set; }
        public int TahunLahirBapak { get; set; }
        public int TahunLahirIbu { get; set; }
        public string AlamatAsliBapak { get; set; }
        public string AlamatAsliIbu { get; set; }
        public void tampilDataOrangtua()
        {
            int umurBapak = 2020 - TahunLahirBapak;
            int umurIbu = 2020 - TahunLahirIbu;

            Console.WriteLine("Nama  bapak : " + NamaBapak);
            Console.WriteLine("Tahun lahir bapak : " + TahunLahirBapak);
            Console.WriteLine("Umur bapak : " + umurBapak);
            Console.WriteLine("Alamat asli bapak : " + AlamatAsliBapak);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Nama  ibu : " + NamaIbu);
            Console.WriteLine("Tahun lahir ibu : " + TahunLahirIbu);
            Console.WriteLine("Umur ibu : " + umurIbu);
            Console.WriteLine("Alamat asli ibu : " + AlamatAsliIbu);

        }
    }
}
