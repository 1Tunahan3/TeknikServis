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
    public partial class FrmCariIller : Form
    {
        public FrmCariIller()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        private void FrmCariIller_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 15);
            chartControl1.Series["Series 1"].Points.AddPoint("Adana", 12);
            chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 4);

            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                İl = z.Key, Toplam = z.Count()
            }).ToList();
        }

    }
}
