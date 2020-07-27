using System;
using CekKeturunan.Inheri;
using CekKeturunan.PolyInheri;
using CekKeturunan.PolyInter;
using CekKeturunan.AbstracInterface;

namespace CekKeturunan
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int pilih;
            do
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("\tCEK PROFIL DAN DETAIL DARI KELUARGA ANDA");
                Console.WriteLine("\tterakhir update 25 July 2020");
                Console.WriteLine("============================================");
                Console.WriteLine("");
                Console.WriteLine("1. Cek Keturunanmu");
                Console.WriteLine("2. Exit");
                Console.Write("Input nomor menu [1..2]: ");
                pilih = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");
                switch (pilih)
                {
                    case 1:
                        cekKeturunan();
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                }
            }
            while (pilih != 0);
        }

        static void Anak1()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 083129351;
            DA.Email = "swoe@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolA();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananPedas();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Bersepeda();

            // INHERITANCE
            Anak anak = new Anak("Perempuan", "Pratiwi Putri", "Mahasiswa", "Jakarta", 1995);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            Console.WriteLine("--------");
            KI.Hoby();
            KI.BerapaKali();
            Console.WriteLine("--------");
            makan.Makanan();
        }
        static void Anak2()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 081277491;
            DA.Email = "cozpa@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolB();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananAsin();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Berenang();

            // INHERITANCE
            AnakSudahMenikah anak = new AnakSudahMenikah("Perempuan", "Wulan Tika", "HRD", "Jakarta Selatan", 1980, "Sarjana Psikologi", 120000, 3);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            Console.WriteLine("--------");
            anak.tampilInfoAnakSudahMenikah();
            Console.WriteLine("--------");
            KI.Hoby();
            KI.BerapaKali();
            Console.WriteLine("--------");
            makan.Makanan();
        }
        static void Anak3()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 0877192841;
            DA.Email = "qowpak@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolAB();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananManis();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Berenang();

            // INHERITANCE
            Anak anak = new Anak("Laki-Laki", "Dony Jurwo", "Pelajar", "Bantul", 2000);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            Console.WriteLine("--------");
            makan.Makanan();
        }
        static void Anak4()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 084184782;
            DA.Email = "Hujor@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolO();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananPedas();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Berenang();


            // INHERITANCE
            AnakKerja anak = new AnakKerja("Perempuan", "Wulan Tika", "HRD", "Jakarta Selatan", 1980, "Sarjana Psikologi", 120000);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            anak.tampilInfoAnakKerja();
            Console.WriteLine("--------");
            makan.Makanan();
        }
        static void Anak5()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 0893324;
            DA.Email = "DonyAnd@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolAB();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananManis();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Berenang();


            // INHERITANCE
            AnakKerja anak = new AnakKerja("Laki-Laki", "Dony Andhika", "Front End Developer", "Jakarta Utara", 1999, "Sarjana Informatika", 200000);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            anak.tampilInfoAnakKerja();
            Console.WriteLine("--------");
            makan.Makanan();
        }
        static void Anak6()
        {
            // ENCAPSULATION
            DataAnak DA = new DataAnak();
            DA.noHP = 0872622;
            DA.Email = "EkiPut@gmail.com";

            // POLYMORPHSIM INTERFACE
            Menampilkan mp = new Menampilkan();
            IGolDarah gol;
            gol = new GolB();

            // ABSTRACTION INTERFACE
            IMakanan makan;
            makan = new MakananAsin();

            // POLYMORPHSIM PEWARISAN
            KelasInduk KI;
            KI = new Bersepeda();

            // INHERITANCE
            Anak anak = new Anak("Perempuan", "Eki Putri", "Pelajar", "Sleman", 2002);

            // OUTPUT
            anak.tampilInfoAnak();
            gol.Print(mp);
            Console.WriteLine("--------");
            DA.tampilDataAnak();
            Console.WriteLine("--------");
            KI.Hoby();
            KI.BerapaKali();
            Console.WriteLine("--------");
            makan.Makanan();
        }

        static void cekKeturunan()
        {
            // START CLASS + OBJECT
            // DATA 1
            DataOrangtua dt = new DataOrangtua();
            dt.NamaBapak = "Sumardi";
            dt.TahunLahirBapak = 1969;
            dt.AlamatAsliBapak = "Magelang, Jawa Tengah";
            dt.NamaIbu = "Juriyem";
            dt.TahunLahirIbu = 1970;
            dt.AlamatAsliIbu = "Kulon Progo, DIY";
            // DATA 2
            DataOrangtua dt2 = new DataOrangtua();
            dt2.NamaBapak = "Harjono";
            dt2.TahunLahirBapak = 1952;
            dt2.AlamatAsliBapak = "Kalimantan Selatan";
            dt2.NamaIbu = "Sumiyem";
            dt2.TahunLahirIbu = 1955;
            dt2.AlamatAsliIbu = "Aceh";
            // DATA 3
            DataOrangtua dt3 = new DataOrangtua();
            dt3.NamaBapak = "Wahyu Utomo";
            dt3.TahunLahirBapak = 1976;
            dt3.AlamatAsliBapak = "Klaten, Jawa Tengah";
            dt3.NamaIbu = "Warni Utami";
            dt3.TahunLahirIbu = 1970;
            dt3.AlamatAsliIbu = "Klaten, Jawa Tengah";
            // DATA 4
            DataOrangtua dt4 = new DataOrangtua();
            dt4.NamaBapak = "Jono Wijoyo";
            dt4.TahunLahirBapak = 1968;
            dt4.AlamatAsliBapak = "Sleman , Daerah Istimewa Yogyakarta";
            dt4.NamaIbu = "Dinna Putri";
            dt4.TahunLahirIbu = 1965;
            dt4.AlamatAsliIbu = "Sleman , Daerah Istimewa Yogyakarta";
            // END CLASS + OBJECT


            // ARRAY UNTUK SEARCH DATA
            string[] ArrnamaIbu = { "Juriyem", "Sumiyem", "Warni Utami", "Dinna Putri" };


            Console.WriteLine("============================================");
            Console.WriteLine("\tEDISI TAHUN 2020 BULAN JULY");
            Console.WriteLine("============================================");

            Console.Write("Nama ibu anda : ");
            string namaIbu = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");

            // Mencari data ibu
            bool result = Array.IndexOf(ArrnamaIbu, namaIbu) >= 0;

            if (result == true)
            {
                if (namaIbu == "Juriyem")
                {
                    dt.tampilDataOrangtua();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("\tDATA ANAK");
                    Console.WriteLine("--------------------------------------------");
                    Anak1();
                    Console.WriteLine("--------------------------------------------");
                    Anak2();
                    Console.WriteLine("--------------------------------------------");
                    Anak5();
                }
                else if (namaIbu == "Sumiyem")
                {
                    dt2.tampilDataOrangtua();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("\tDATA ANAK");
                    Console.WriteLine("--------------------------------------------");
                    Anak3();
                }
                else if (namaIbu == "Dinna Putri")
                {
                    dt2.tampilDataOrangtua();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("\tDATA ANAK");
                    Console.WriteLine("--------------------------------------------");
                    Anak4();

                }
                else if (namaIbu == "Warni Utami")
                {
                    dt2.tampilDataOrangtua();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("\tDATA ANAK");
                    Console.WriteLine("--------------------------------------------");
                    Anak6();
                }

            }
            else
            {
                Console.WriteLine("Maaf, data keluarga anda belum terdaftar dalam sistem kami!");
            }


            Console.ReadKey();
        }
    }  
}
