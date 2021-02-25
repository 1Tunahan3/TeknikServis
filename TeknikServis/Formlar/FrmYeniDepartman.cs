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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            t.AD = textBox1.Text;
            db.TBLDEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }
    }
}
