using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.Inheri
{
    class AnakKerja : Anak
    {
        public string PendidikanTerakhir { get; set; }
        public int GajiHarian { get; set; }
        public AnakKerja(string kelamin, string nama, string pekerjaan, string alamat, int lahir, string penTerakhir, int gajiHari) :base(kelamin, nama, pekerjaan, alamat, lahir)
        {
            kelamin = kelamin;
            nama = nama;
            pekerjaan = pekerjaan;
            alamat = alamat;
            lahir = lahir;
            PendidikanTerakhir = penTerakhir;
            GajiHarian = gajiHari;
        }
        public void tampilInfoAnakKerja()
        {
            int gajiBulanan = 30 * GajiHarian;
            Console.WriteLine("Pendidikan terakhir : " + PendidikanTerakhir);
            Console.WriteLine("Gaji bulanan : " + gajiBulanan);
        }
    }
}
