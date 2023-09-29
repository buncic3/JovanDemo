namespace WinFormsApp1
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;

            if(string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Morate uneti korisnicko ime!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Morate uneti lozinku!");
                return;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Korisnicko ime mora imati vise od 3 karaktera!");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Lozinka mora imati vise od 8 karaktera!");
                return;
            }

            if(Baza.Korisnici.Any(x => x.Ime.ToUpper() == username.ToUpper()))
            {
                MessageBox.Show("Korisnicko ime je vec zauzeto!");
                return;
            }

            Baza.Korisnici.Add(new Korisnik()
            {
                Ime = username,
                Sifra = password
            });

            MessageBox.Show("Uspesno ste se registrovali!");
        }
    }
}
