using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProdukSaya
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman_19.11.2634";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int menupilihan = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk Anda : ");
            Console.WriteLine("2. Hapus Produk Anda : ");
            Console.WriteLine("3. Tampilkan Produk Anda : ");
            Console.WriteLine("4. Keluar!");
        }

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Produk anda : \n");
            Produk produk = new Produk();
            Console.Write("Kode Produk anda : ");
            produk.PG_produk = Console.ReadLine();
            Console.Write("Nama Produk anda : ");
            produk.Nama_produk = Console.ReadLine();
            Console.Write("Harga Beli anda  : ");
            produk.Harga_belibarang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga Jual anda : ");
            produk.Harga_jualbarang = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(produk);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk anda\n");
            Console.Write("Kode Produk anda : ");
            string kd = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if (produk.PG_produk == kd)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData Produk Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

            int noUrut = 0;
            Console.WriteLine("Data Produk anda\n");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:N0}", noUrut, produk.PG_produk, produk.nama_produk, produk.harga_belibarang, produk.harga_jualbarang);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
