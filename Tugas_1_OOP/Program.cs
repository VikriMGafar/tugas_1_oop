using System;

namespace Tugas_01
{
    
    class slotParkir
    {
        //public string PlatMotor { get; set; }
        static public int Jumlahslot { get; private set; } = 15;
        public int Jumlahkendaraan { get; private set; } = 0;

        //public Prodi(string namaProdi)
        //{
        //    JumlahProdi++
        //    NamaProdi = namaProdi;
        //}

        //public Prodi(string NamaProdi, Dosen kaprodi) : this(NamaProdi)
        //{
        //    Kaprodi = kaprodi;
        //}

        public void motorMasuk()
        {
            Jumlahkendaraan++;
            Jumlahslot--;
        }

        public void motorKeluar()
        {
            Jumlahkendaraan++;
            Jumlahslot--;
        }
    }

    class Kendaraan
    {
        public string platKendaraan { get; set; }
        public string NomorIndukMahasiswa { get; set; }
        public string TempatTanggalLahir { get; set; }
        //public Prodi ProgramStudi { get; set; }
        //public Dosen PembimbingAkademik { get; set; }
        static public int JumlahKendaraan { get; private set; } = 0;

        public Kendaraan(string platKendaraan)
        {
            JumlahKendaraan++;
            this.platKendaraan = platKendaraan;
            Console.WriteLine("Kendaraan masuk, plat nomor : " + platKendaraan);
        }

        public Kendaraan(string namaMahasiswa, Prodi programStudi) : this(namaMahasiswa)
        {
            ProgramStudi = programStudi;
            ProgramStudi.tambahMahasiswa();
            Console.WriteLine("\tProgram Studi: " + programStudi.NamaProdi);
        }

        public Kendaraan(string namaMahasiswa, Prodi programStudi, string nomorInduk, string tempatTanggalLahir) : this(namaMahasiswa, programStudi)
        {
            NomorIndukMahasiswa = nomorInduk;
            TempatTanggalLahir = tempatTanggalLahir;

            Console.WriteLine("\tNomor Induk Mahasiswa: " + NomorIndukMahasiswa);
            Console.WriteLine("\tTempat Tanggal lahir: " + TempatTanggalLahir);
        }
    }
    class Program
    {


        static void BacaSlotDB(string fileParkir, Dictionary<int, Kendaraan> platKendaraan)
        {
            const string folderOutput = "../../../output/";
            if (!Directory.Exists(folderOutput))
            {
                Directory.CreateDirectory(folderOutput);
            }

            string fileOutput = folderOutput + "mahasiswa.CSV";
            string hasil = "No., NIM, Nama Mahasiswa, Tempat Lahir, Tanggal Lahir\n";
            try
            {
                string mhs = File.ReadAllText(fileParkir);
                string[] baris = mhs.Split("\n");
                
                DateTime now = DateTime.Now();
                Kendaraan m = new Kendaraan(kolom[1], prodi, kolom[0], kolom[2]);
                
                
                for (int i = 0; i < baris.Length; i++)
                {
                    //116103001|Reynaldi|Jakarta, 12/05/1998
                    string[] kolom = baris[i].Split("|");

                    //Kendaraan Plat Jam Masuk, jam Keluar
                    
                    
                    string[] ttl = kolom[2].Split(",");
                    DateTime date = DateTime.Parse(ttl[1]);

                    Console.WriteLine(date);

                    mahasiswa.Add(i, m);
                    hasil += (i + 1) + ", " + kolom[0] + ", " + kolom[1] + ", " + prodi.NamaProdi + ", " + ttl[0] + ", " + date + "\n";
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            File.WriteAllText(fileOutput, hasil);
            fileOutput = Path.GetFullPath(fileOutput);
            Console.WriteLine("\nOutput telah ditulis ke File " + fileOutput);
        }
        static void Main(string[] args)
        {


           //// Inisialisasi variabel
           //const int MAX_SLOTS = 10;
           //int emptySlots = MAX_SLOTS;
           // double hourlyRate = 10;
           //DateTime[] slots = new DateTime[MAX_SLOTS];

           // // Loop utama
           //while (true)
           // {
           //     Console.WriteLine("Welcome to the parking system.");
           //     Console.WriteLine("Empty slots: " + emptySlots);
           //     Console.WriteLine("Hourly rate: $" + hourlyRate);
           //     Console.WriteLine("1. Park a vehicle");
           //     Console.WriteLine("2. Remove a vehicle");
           //     Console.WriteLine("3. Exit");
           //     Console.Write("Please enter your choice: ");
           //     int choice = int.Parse(Console.ReadLine());

           //     if (choice == 1)
           //     {
           //         if (emptySlots == 0)
           //         {
           //             Console.WriteLine("Sorry, the parking lot is full.");
           //             continue;
           //         }

           //         // Cari slot kosong
           //         int slotNumber = -1;
           //         for (int i = 0; i < MAX_SLOTS; i++)
           //         {
           //             if (slots[i] == DateTime.MinValue)
           //             {
           //                 slotNumber = i;
           //                 break;
           //             }
           //         }

           //         //Tandai slot sebagai terisi dan catat waktu masuk kendaraan
           //         slots[slotNumber] = DateTime.Now;
           //         emptySlots--;
           //         Console.WriteLine("Vehicle parked in slot " + (slotNumber + 1) + ".");
           //     }
           //     else if (choice == 2)
           //     {
           //         // Cari nomor slot yang ingin dikosongkan
           //         Console.Write("Please enter the slot number: ");
           //         int slotNumber = int.Parse(Console.ReadLine()) - 1;

           //         if (slots[slotNumber] == DateTime.MinValue)
           //         {
           //             Console.WriteLine("Sorry, the slot is already empty.");
           //             continue;
           //         }

           //         // Hitung biaya parkir dan catat waktu keluar kendaraan
           //         TimeSpan duration = DateTime.Now - slots[slotNumber];
           //         double totalCharge = Math.Ceiling(duration.TotalHours) * hourlyRate;
           //         slots[slotNumber] = DateTime.MinValue;
           //         emptySlots++;
           //         Console.WriteLine("Vehicle removed from slot " + (slotNumber + 1) + ".");
           //         Console.WriteLine("Total charge: $" + totalCharge);
           //     }
           //     else if (choice == 3)
           //     {
           //         Console.WriteLine("Goodbye!");
           //         break;
           //     }
           //     else
           //     {
           //         Console.WriteLine("Invalid choice. Please try again.");
           //     }

           //     Console.WriteLine();
           // }
        }
    }
}
