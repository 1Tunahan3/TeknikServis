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
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var deger = db.TBLURUN.OrderByDescending(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key, Toplam = z.Count()
            });

            gridControl1.DataSource = deger.ToList();


            label9.Text = db.TBLURUN.Count().ToString();
            label5.Text = (from x in db.TBLURUN
                select x.MARKA).Distinct().Count().ToString();

            label1.Text = (from x in db.TBLURUN
                orderby x.SATISFIYAT descending
                select x.MARKA).FirstOrDefault();

            label3.Text = (from x in db.TBLURUN.OrderByDescending(x => x.MARKA).GroupBy(y => y.MARKA)
                select x.Key).FirstOrDefault();

            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 9);
            chartControl1.Series["Series 1"].Points.AddPoint("Hp", 3);
            chartControl1.Series["Series 1"].Points.AddPoint("Acer", 4);

            chartControl2.Series["Series 2"].Points.AddPoint("Beyaz Eşya", 4);
            chartControl2.Series["Series 2"].Points.AddPoint("Bilgisayar", 2);
            chartControl2.Series["Series 2"].Points.AddPoint("Küçük Ev Aletleri", 7);
            chartControl2.Series["Series 2"].Points.AddPoint("Telefon", 11);
            chartControl2.Series["Series 2"].Points.AddPoint("Diğer", 10);


        }
    }
}
