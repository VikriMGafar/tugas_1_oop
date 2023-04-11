using System;
using System.Drawing;

namespace Tugas_01
{
    class Kendaraan
    {
        public string Jenis { get; set; }
        public string PlatNomor { get; set; }

        // constructor
        public Kendaraan(string jenis, string platNomor)
        {
            Jenis = jenis;
            PlatNomor = platNomor;
        }

        // method untuk mencetak informasi kendaraan
        public virtual void CetakInfo()
        {
            Console.WriteLine("Jenis Kendaraan: {0}", Jenis);
            Console.WriteLine("Nomor Plat: {0}", PlatNomor);
        }
    }

    // class turunan
    class Mobil : Kendaraan
    {
        public int JamParkir { get; set; }

        // constructor
        public Mobil(string jenis, string platNomor, int jamParkir) : base(jenis, platNomor)
        {
            JamParkir = jamParkir;
        }

        // method untuk menghitung biaya parkir mobil
        public double HitungBiayaParkir()
        {
            return JamParkir * 2000;
        }

        // override method CetakInfo() dari class Kendaraan
        public override void CetakInfo()
        {
            base.CetakInfo();
            Console.WriteLine("Lama Parkir: {0} jam", JamParkir);
            Console.WriteLine("Biaya Parkir: Rp. {0}", HitungBiayaParkir());
        }
    }

    // class turunan
    class Motor : Kendaraan
    {
        public int JamParkir { get; set; }

        // constructor
        public Motor(string jenis, string platNomor, int jamParkir) : base(jenis, platNomor)
        {
            JamParkir = jamParkir;
        }

        // method untuk menghitung biaya parkir motor
        public double HitungBiayaParkir()
        {
            return JamParkir * 1000;
        }

        // override method CetakInfo() dari class Kendaraan
        public override void CetakInfo()
        {
            base.CetakInfo();
            Console.WriteLine("Lama Parkir: {0} jam", JamParkir);
            Console.WriteLine("Biaya Parkir: Rp. {0}", HitungBiayaParkir());
        }
    }

    class Program
    {

        //static void kendaraanMasuk(string jenis, string platnomor, Kendaraan[] kendaraan)
        //{
            
        //}
        static void Main(string[] args)
        {
            // kuota/slot parkir yang tersedia
            int kuotaParkirMobil = 10;
            int kuotaParkirMotor = 20;

            // array untuk menyimpan objek kendaraan
            Kendaraan[] parkir = new Kendaraan[kuotaParkirMobil + kuotaParkirMotor];

            // menambahkan kendaraan ke array parkir
            parkir[0] = new Mobil("Sedan", "B 1234 XYZ", 3);
            parkir[1] = new Motor("Matic", "F 5678 ABC", 2);
            parkir[2] = new Mobil("SUV", "D 4321 PQR", 4);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("banyaknya : " + parkir.Length);
            Console.WriteLine("--------------------------------");
            // mencetak informasi kendaraan yang terparkir
            Console.WriteLine("Daftar Kendaraan yang Terparkir:");
            Console.WriteLine("--------------------------------");

            int jumlahKendaraan = 0;
            int jumlahMobil = 0;
            int jumlahMotor = 0;

            foreach (Kendaraan kendaraan in parkir)
            {
                if (kendaraan != null)
                {
                    jumlahKendaraan++;
                    kendaraan.CetakInfo();

                    if (kendaraan is Mobil)
                    {
                        jumlahMobil++;
                    }
                    else if (kendaraan is Motor)
                    {
                        jumlahMotor++;
                    }
                }
            }

            // mencetak jumlah kendaraan yang terparkir
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Jumlah Kendaraan yang Terparkir: {0}", jumlahKendaraan);
            Console.WriteLine("Jumlah Mobil: {0}", jumlahMobil);
            Console.WriteLine("Jumlah Motor: {0}", jumlahMotor);

            Console.ReadLine();
        }
    }
}