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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM T=new TBLNOTLARIM();
            T.BASLIK = txtUrunAd.Text;
            T.ICERIK = textBox1.Text;
            T.DURUM = false;
            db.TBLNOTLARIM.Add(T);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
         var deger=  db.TBLNOTLARIM.Find(id);
         deger.DURUM = true;
         db.SaveChanges();
         MessageBox.Show("Okundu Bilgisi Güncellendi");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == true).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
