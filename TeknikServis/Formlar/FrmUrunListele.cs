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
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        void Metot()
        {
            var degerler = from u in db.TBLURUN
                select new
                {
                    u.ID,
                    u.AD, 
                    u.ALISFIYAT,
                   KATEGORI= u.TBLKATEGORILER.AD,
                    u.SATISFIYAT,
                    u.STOK,
                    u.MARKA
                };
            gridControl1.DataSource = degerler.ToList();

        }
        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            //var degerler = db.TBLURUN.ToList();
           
           Metot();
            lookUpEdit1.Properties.DataSource = db.TBLKATEGORILER.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN tblurun=new TBLURUN();
            tblurun.AD = txtUrunAd.Text;
            tblurun.ALISFIYAT =decimal.Parse(txtUrunAlisFiyat.Text) ;
            tblurun.SATISFIYAT = decimal.Parse(txtUrunSatisFiyat.Text);
            tblurun.MARKA = txtUrunMarka.Text;
            tblurun.DURUM = false;
            tblurun.STOK =short.Parse(txtUrunStok.Text);
            tblurun.KATEGOR = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(tblurun);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Metot();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtUrunMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtUrunSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtUrunAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtUrunStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtUrunId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = txtUrunAd.Text;
            deger.MARKA = txtUrunMarka.Text;
            deger.ALISFIYAT = decimal.Parse(txtUrunAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(txtUrunSatisFiyat.Text);
            deger.KATEGOR = byte.Parse(lookUpEdit1.EditValue.ToString());
            deger.STOK =short.Parse(txtUrunStok.Text);
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }
    }
}
