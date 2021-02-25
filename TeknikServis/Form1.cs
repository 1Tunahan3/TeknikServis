using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.ColorPick.Picker;
using TeknikServis.Formlar;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunListele frm=new FrmUrunListele();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniUrun frm = new FrmYeniUrun();
            frm.Show();
        }

        private void btnKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniKategori frm=new FrmYeniKategori();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmİstatistik frm = new Frmİstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMarkalar frm = new FrmMarkalar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCariIller frm = new FrmCariIller();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CariListesi frm = new CariListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartman frm=new FrmDepartman();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYeniDepartman frm=new FrmYeniDepartman();
            frm.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel frm=new FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKurlar frm = new FrmKurlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYoutube frm = new FrmYoutube();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotlar frm = new FrmNotlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArızaListesi frm = new FrmArızaListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunSatis frm = new FrmUrunSatis();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSatislar frm = new FrmSatislar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaliÜrünKaydi frm = new FrmArizaliÜrünKaydi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaDetaylar frm = new FrmArizaDetaylar();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmArizaliDetayUrunListesi frm = new FrmArizaliDetayUrunListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturaListesi frm = new FrmFaturaListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFaturaKalem frm = new FrmFaturaKalem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmFaturaKalemleri frm = new FrmFaturaKalemleri();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
