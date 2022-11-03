using System;

namespace KonsolPhonebook
{
    internal class Program
    {// timestamp : 25:15 (jaga-jaga jika lupa)
        private static void Main(string[] args) // titik masuk program
        {
            Console.WriteLine("Halo, selamat datang di aplikasi konsol kontak saya!");
            Console.WriteLine("pilih operasi yang ingin anda lakukan :");
            Console.WriteLine("1. buat kontak");
            Console.WriteLine("2. cari kontak berdasarkan angka");
            Console.WriteLine("3. lihat semua kontak");
            Console.WriteLine("4. cari kontak berdasarkan nama");
            Console.WriteLine("tolong tekan huruf \"x\" jika ingin kembali");
            Console.WriteLine("tekan angka yang sesuai dengan daftar operasi di atas");

            var inputUser = Console.ReadLine(); // input pengguna

            var bukuKontak = new BukuTelepon(); // input disimpan ke sini

            while (true) // memastikan program tak berhenti prematur dengan nilai benar (selalu dijalankan)
            {
                switch (inputUser)
                {
                    case "1":
                        Console.WriteLine("Nama Kontak :");
                        var nama = Console.ReadLine();
                        Console.WriteLine("Nomor Kontak :");
                        var nomor = Console.ReadLine();

                        var kontakBaru = new Kontak(nama, nomor);
                        bukuKontak.tambahKontak(kontakBaru);
                        break;

                    case "2":
                        Console.WriteLine("Nomor Kontak yang ingin dicari :");
                        var cariAngka = Console.ReadLine();
                        bukuKontak.lihatKontak(cariAngka);
                        break;

                    case "3":
                        bukuKontak.lihatSemuaKontak();
                        break;

                    case "4":
                        Console.WriteLine("Nama Kontak yang ingin dicari :");
                        var cariNama = Console.ReadLine();
                        bukuKontak.lihatKontakYangSama(cariNama);
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("tolong pilih operasi yang valid untuk melanjutkan");
                        break;
                }

                Console.WriteLine("Pilih operasi lain : ");
                inputUser = Console.ReadLine();
            }
        }
    }
}

/*
daftar bug :
    2. operasi 3 hanya memunculkan "kontak", tidak nama dan no. kontak (solved, kesalahan logika dan nama variabel)
    3. exception di op 4 (solved, kesalahan logika dan nama variabel)
    4. operasi 2 setelah semua angka diinput masih tidak dapat dicari (solved, kode awal kurang berguna, harus copas method lain)
    5. bagian if-else deprecated karena hasil selalu tidak null ketika salah input
*/