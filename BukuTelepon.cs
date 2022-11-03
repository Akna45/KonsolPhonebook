using System;
using System.Collections.Generic;
using System.Linq;

namespace KonsolPhonebook // mengelola kontak
{
    internal class BukuTelepon
    {
        private List<Kontak> _kontak { get; set; } = new List<Kontak>();// lambda expression
        // mengimplementasikan daftar dahulu agar bisa diinput

        private void lihatDetailKontak(Kontak kontak)
        {
            Console.WriteLine($"Kontak : {kontak.Nama}, {kontak.Nomor}");
        }

        private void lihatDetailKontak(List<Kontak> kontaks)
        {
            foreach (var kontak in kontaks)
            {
                lihatDetailKontak(kontak);
            }
        }

        public void tambahKontak(Kontak kontak) // menambahkan
        {
            _kontak.Add(kontak); // menambahkan daftar ke list
        }

        public void lihatKontak(string nomor)
        {
            var kontak = _kontak.Where(c => c.Nomor.Contains(nomor)).ToList();
            if (kontak == null)
            {
                Console.WriteLine("Maaf, kontak tak ditemukan");
            }
            else
            {
                lihatDetailKontak(kontak);
            }
        }

        public void lihatSemuaKontak()
        {
            lihatDetailKontak(_kontak);
        }

        public void lihatKontakYangSama(string kalimatCari)
        {
            var kontakSama = _kontak.Where(c => c.Nama.Contains(kalimatCari)).ToList();
            if (kontakSama == null)
            {
                Console.WriteLine("Maaf, kontak tak ditemukan");
            }
            else
            {
                lihatDetailKontak(kontakSama);
            }
        }
    }
}

/*
istilah :
    refactor : membersihkan dan menyederhanakan kode agar lebih mudah dipakai dan dibaca
*/