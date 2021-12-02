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
    public partial class FrmHasilPerhitungan : Form
    {
        private List<Kalkulator> listofKalkulator = new List<Kalkulator>();

        public FrmHasilPerhitungan()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwHasilPerhitungan.View = View.Details;

            lvwHasilPerhitungan.Columns.Add("", 0, HorizontalAlignment.Center);
            lvwHasilPerhitungan.Columns.Add("", 200, HorizontalAlignment.Center);
        }

        private void FrmKalkulator_OnKal(Kalkulator kal)
        {
            listofKalkulator.Add(kal);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(kal.Hasil);

            lvwHasilPerhitungan.Items.Add(item);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmKalkulator frmkalkulator = new FrmKalkulator("Kalkulator");
            frmkalkulator.OnKal += FrmKalkulator_OnKal;
            frmkalkulator.ShowDialog();
        }
    }
}
