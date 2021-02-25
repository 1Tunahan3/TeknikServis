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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db=new DbTeknikServisEntities();
            TBLURUNTAKIP t=new TBLURUNTAKIP();
            t.ACIKLAMA = richTextBox1.Text;
            t.TARIH =DateTime.Parse(textBox2.Text) ;
            t.SERINO = textBox1.Text;
            db.TBLURUNTAKIP.Add(t);
            db.SaveChanges();
            MessageBox.Show("OLDU");
        }
    }
}
