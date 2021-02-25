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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var deger = from x in db.TBLDEPARTMAN
                select new
                {
                    x.ID,
                    x.AD,
                    x.ACIKLAMA
                };
            gridControl1.DataSource = deger.ToList();



            label13.Text = db.TBLDEPARTMAN.Count().ToString();
            label14.Text = db.TBLPERSONEL.Count().ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAd.Text.Length<=50 && txtUrunAd.Text!="")
            {
                 TBLDEPARTMAN t=new TBLDEPARTMAN();
            t.AD = txtUrunAd.Text;
            t.ACIKLAMA = richTextBox1.Text;
            db.TBLDEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Hata");
            }
           
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
          var deger=  db.TBLDEPARTMAN.Find(id);
          db.TBLDEPARTMAN.Remove(deger);
          db.SaveChanges();
          MessageBox.Show("Silindi");

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtUrunId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            richTextBox1.Text= gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var deger = from x in db.TBLDEPARTMAN
                select new
                {
                    x.ID,
                    x.AD,
                    x.ACIKLAMA
                };
            gridControl1.DataSource = deger.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = txtUrunAd.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }
    }
}
