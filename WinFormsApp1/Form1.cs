namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            var username = korisnickoIme_txt.Text;
            var password = lozinka_txt.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Morate uneti korisnicko ime!");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Morate uneti lozinku!");
                return;
            }

            foreach(var k in Baza.Korisnici)
            {
                if(k.Ime.ToUpper() == username.ToUpper() && k.Sifra == password)
                {
                    using (var f2 = new Form2())
                        f2.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Pogresno koriscnicko ime ili lozinka");

            string asd = "Ovo je neki string";
            bool daLiImaS = asd.Any(x => x == 's');
            int karaktera = asd.Count(x => x == 's');

            List<int> list = new List<int>();
            list.Add(1);
            list.Remove(1);
            list.Find(x => x == 1);
            list.Contains(1);
            var list1 = list.Distinct();
            list.All(x => x % 2 == 0);
            list.Any(x => x % 2 == 0);
            var c = list.Count(x => x % 2 == 0) >= 1;
            list.Clear();
            list.Last();
            list.First();
            list.Sort();
            list.Order();
            list.Average();
            var filtriranuListu = list.Where(x => x % 2 == 0);

            if (!Baza.Korisnici.Any(x => x.Ime.ToUpper() == username.ToUpper() && x.Sifra == password))
            {
                MessageBox.Show("Pogresno koriscnicko ime ili lozinka");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var reg = new Registracija())
                reg.ShowDialog();
        }
    }
}