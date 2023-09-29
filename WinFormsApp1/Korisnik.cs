namespace WinFormsApp1
{
    public class Korisnik
    {
        public string Ime { get; set; }
        public string Sifra { get; set; }

        public Korisnik() { }
        public Korisnik(string ime, string sifra)
        {
            Ime = ime;
            Sifra = sifra;
        }
    }
}
