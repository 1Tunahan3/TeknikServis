using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var deger = from x in db.TBLFATURADETAY
                select new
                {
                    x.FATURADETAYID, x.URUN, x.ADET, x.FIYAT, x.TUTAR, x.FATURAID
                };
            gridControl1.DataSource = deger.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t=new TBLFATURADETAY();
            t.URUN = txtUrunAd.Text;
            t.ADET =short.Parse(textBox1.Text) ;
            t.FIYAT = decimal.Parse(textBox2.Text);
            t.TUTAR = decimal.Parse(textBox3.Text);
            t.FATURAID = int.Parse(textBox4.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }
    }
}
