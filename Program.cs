using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugaslab8.ClassAnak;
using Tugaslab8.ClassInduk;

namespace Tugaslab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            ClassAnak.KaryawanTetap karyawanTetap = new ClassAnak.KaryawanTetap();
            karyawanTetap.NIK = 2617;
            karyawanTetap.NAMA = "ARIF";
            karyawanTetap.gajibulanan = 6000000;

            ClassAnak.KaryawanHarian karyawanHarian = new ClassAnak.KaryawanHarian();
            karyawanHarian.NIK = 2345;
            karyawanHarian.NAMA = "RAHMAT";
            karyawanHarian.jumlahjamkerja = 10;
            karyawanHarian.upahperjam = 150000;

            ClassAnak.Sales sales = new ClassAnak.Sales();
            sales.NIK = 2098;
            sales.NAMA = "HIDAYATULLAH";
            sales.jumlahpenjualan = 37;
            sales.komisi = 65000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, GAJI: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.GAJI());
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
