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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            var deger = from x in db.TBLURUNHAREKET
                select new
                {
                    x.HAREKETID, 
                    x.TBLURUN.AD, 
                    MUSTERI = x.TBLCARI.AD + x.TBLCARI.SOYAD, 
                    PERSONEL = x.TBLPERSONEL.AD + x.TBLPERSONEL.SOYAD,
                    x.ADET,
                    x.FIYAT,
                    x.TARIH,
                    x.URUNSERINO,
                   
                   
                };
            gridControl1.DataSource = deger.ToList();
        }
    }
}
