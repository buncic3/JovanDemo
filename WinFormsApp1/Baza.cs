namespace WinFormsApp1
{
    public static class Baza
    {
        private static int _kMaxNum = 100;
        public static List<Korisnik> Korisnici { get; set; } = new List<Korisnik>()
        {
            new Korisnik("SYSDBA", "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
            new Korisnik("Korisnik" + Random.Shared.Next(_kMaxNum), "M"),
        };
    }
}
