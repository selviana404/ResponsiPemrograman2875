using System;
namespace ResponsiPemrograman2875
{
    class Program
    {
        static void Main(string[]args)
        {
            Karyawan karyawan1 = new Karyawan(19112875, "Selviana", 3000000);
            Karyawan karyawan2 = new Karyawan(19112976, "Andita", 2000000);

            Console.WriteLine("NIK \t Nama \t Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            karyawan1.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asyiiiiik naik gaji 10%!!");

            Console.WriteLine("NIK \t Nama \t Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            karyawan1.naikGaji();
            karyawan2.naikGaji();
            Console.ReadKey();
        }
    }
    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }
        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if(gaji < 0)
            {
                this.gajiBulanan = 0;
            } 
            else 
            {
                this.gajiBulanan = gaji;
            }
        }
        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
        public void naikGaji()
        {
            double tmp = 0;
            tmp =  0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }
    }
}