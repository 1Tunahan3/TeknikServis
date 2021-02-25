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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label7.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLKATEGORILER.Count().ToString();
            label3.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            label8.Text = db.TBLURUN.Count(x => x.STOK < 50).ToString();
            label17.Text = (from x in db.TBLURUN
                orderby x.STOK descending
                select x.AD).FirstOrDefault();
            label15.Text = (from x in db.TBLURUN
                orderby x.STOK ascending 
                select x.AD).FirstOrDefault();
            label11.Text = (from x in db.TBLURUN
                orderby x.SATISFIYAT descending
                select x.AD).FirstOrDefault();
            label19.Text = (from x in db.TBLURUN
                orderby x.SATISFIYAT ascending
                select x.AD).FirstOrDefault();
            label35.Text = db.TBLURUN.Count(x => x.KATEGOR == 4).ToString();
            label37.Text = db.TBLURUN.Count(x => x.KATEGOR == 1).ToString();
            label39.Text = db.TBLURUN.Count(x => x.KATEGOR == 3).ToString();
            label21.Text = (from x in db.TBLURUN
                select x.MARKA).Distinct().Count().ToString();
            label33.Text = (from x in db.TBLURUN.GroupBy(x => x.MARKA).OrderByDescending(y => y.Key) 
                select x.Key).FirstOrDefault();



        }
    }
}
