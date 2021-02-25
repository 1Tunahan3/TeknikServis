using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var deger = from x in db.TBLFATURABILGI
                select new
                {
                    x.ID,
                    x.SERI,
                    x.SIRANO,
                    x.TARIH,
                    x.SAAT,
                    x.VERGIDAIRE,
                    CARI=x.TBLCARI.AD +x.TBLCARI.SOYAD,
                    PERSONEL=x.TBLPERSONEL.AD+ x.TBLPERSONEL.SOYAD
                };
            gridControl1.DataSource = deger.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           TBLFATURABILGI t=new TBLFATURABILGI();
            t.SERI = txtUrunAd.Text;
            t.SIRANO = textBox1.Text;
            t.TARIH = Convert.ToDateTime(textBox2.Text);
            t.SAAT = textBox3.Text;
            t.VERGIDAIRE = textBox4.Text;
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
            db.TBLFATURABILGI.Add(t); 
                            db.SaveChanges();
                            

                     MessageBox.Show("OKEY");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var deger = from x in db.TBLFATURABILGI
                select new
                {
                    x.ID,
                    x.SERI,
                    x.SIRANO,
                    x.TARIH,
                    x.SAAT,
                    x.VERGIDAIRE,
                    CARI = x.TBLCARI.AD + x.TBLCARI.SOYAD,
                    PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD
                };
            gridControl1.DataSource = deger.ToList();
        }
    }
}
