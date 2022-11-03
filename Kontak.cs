namespace KonsolPhonebook
{
    internal class Kontak
    {
        public Kontak(string nama, string nomor) // constructor
        {
            Nama = nama;
            Nomor = nomor;
        }

        // properties
        public string Nama { get; set; }

        public string Nomor { get; set; }
    }
}