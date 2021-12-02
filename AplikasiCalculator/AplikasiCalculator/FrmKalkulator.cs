using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorApp
{
    public partial class FrmKalkulator : Form
    {
        public delegate void CreateUpdateEventHandler(Kalkulator kal);
        public event CreateUpdateEventHandler OnKal;

        public Kalkulator kal;

        public FrmKalkulator()
        {
            InitializeComponent();
        }

        public FrmKalkulator(string tittle)
            : this()
        {
            this.Text = tittle;
        }
		
        private void btnProses_Click(object sender, EventArgs e)
        {
            kal  = new Kalkulator();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);

            if (cmbOperasi.Text == "Penjumlahan")
                kal.Hasil = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);

            if (cmbOperasi.Text == "Pengurangan")
                kal.Hasil = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);

            if (cmbOperasi.Text == "Perkalian")
                kal.Hasil = string.Format("Hasil Penjumlahan {0} x {1} = {2}", a, b, a * b);

            if (cmbOperasi.Text == "Pembagian")
                kal.Hasil = string.Format("Hasil Penjumlahan {0} : {1} = {2}", a, b, a / b);

            OnKal(kal);
            txtNilaiA.Clear();
            txtNilaiB.Clear();
            txtNilaiA.Focus();
        }
    }
}
