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
    public partial class FrmArizaliÜrünKaydi : Form
    {
        public FrmArizaliÜrünKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmArizaliÜrünKaydi_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(txtId.Text);
            t.GELISTARIHI = DateTime.Parse(txtTarih.Text);
            t.PERSONEL = short.Parse(txtPersonel.Text);
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("kayıt yapıldı");
        }
    }
}
