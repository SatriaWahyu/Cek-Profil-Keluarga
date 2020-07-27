using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.Inheri
{
    class Anak
    {
        private string JenisKelaminAnak { get; set; }
        private string NamaAnak { get; set; }
        private string PekerjaanAnak { get; set; }
        private string AlamatSekarangAnak { get; set; }
        private int TahunLahirAnak { get; set; }

        public Anak(string kelamin, string nama, string pekerjaan, string alamat, int lahir)
        {
            JenisKelaminAnak = kelamin;
            NamaAnak = nama;
            PekerjaanAnak = pekerjaan;
            AlamatSekarangAnak = alamat;
            TahunLahirAnak = lahir;
        }

        public void tampilInfoAnak()
        {
            int umurAnak = 2020 - TahunLahirAnak;
            Console.WriteLine("Nama lengkap : " + NamaAnak);
            Console.WriteLine("Jenis kelamin : " + JenisKelaminAnak);
            Console.WriteLine("Umur : " + umurAnak);
            Console.WriteLine("Pekerjaan : " + PekerjaanAnak);
            Console.WriteLine("Alamat tinggal : " + AlamatSekarangAnak);
        }
    }
}
