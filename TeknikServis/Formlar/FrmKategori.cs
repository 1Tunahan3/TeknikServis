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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from t in db.TBLKATEGORILER
                select new
                {
                    t.ID,
                    t.AD
                };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORILER t=new TBLKATEGORILER();
            t.AD = txtUrunAd.Text;
            db.TBLKATEGORILER.Add(t);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var degerler = from t in db.TBLKATEGORILER
                select new
                {
                    t.ID,
                    t.AD
                };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtUrunId.Text);
            var deger = db.TBLKATEGORILER.Find(id);
            db.TBLKATEGORILER.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.TBLKATEGORILER.Find(id);
            deger.AD = txtUrunAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }
    }
}
