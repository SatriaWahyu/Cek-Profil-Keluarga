using System;
using System.Collections.Generic;
using System.Text;

namespace CekKeturunan.Inheri
{
    class AnakSudahMenikah : Anak
    {
        public string PendidikanTerakhir { get; set; }
        public int GajiHarian { get; set; }
        public int JumlahAnak { get; set; }
        public AnakSudahMenikah(string kelamin, string nama, string pekerjaan, string alamat, int lahir, string penTerakhir, int gajiHari, int jumlahanak) : base(kelamin, nama, pekerjaan, alamat, lahir)
        {
            kelamin = kelamin;
            nama = nama;
            pekerjaan = pekerjaan;
            alamat = alamat;
            lahir = lahir;
            PendidikanTerakhir = penTerakhir;
            GajiHarian = gajiHari;
            JumlahAnak = jumlahanak;
        }
        public void tampilInfoAnakSudahMenikah()
        {
            int gajiBulanan = 30 * GajiHarian;
            Console.WriteLine("Pendidikan terakhir : " + PendidikanTerakhir);
            Console.WriteLine("Gaji bulanan : " + gajiBulanan);
            Console.WriteLine("Jumlah anak : " + JumlahAnak);
        }
    }
}
