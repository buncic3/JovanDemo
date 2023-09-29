using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("Korisnik", typeof(string));
            dt.Columns.Add("Sifra", typeof(string));

            foreach(var k in Baza.Korisnici)
            {
                var dr = dt.NewRow();
                dr["Korisnik"] = k.Ime;
                dr["Sifra"] = k.Sifra;
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
