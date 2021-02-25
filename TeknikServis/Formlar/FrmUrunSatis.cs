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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t=new TBLURUNHAREKET();
            t.URUN =int.Parse(txtUrunID.Text) ;
            t.ADET = short.Parse(txtAdet.Text);
            t.MUSTERI = int.Parse(txtMusteri.Text);
            t.FIYAT = decimal.Parse(txtSatisFiyati.Text);
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.PERSONEL = short.Parse(txtPersonel.Text);
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("EKLENDİ");
        }
    }
}
