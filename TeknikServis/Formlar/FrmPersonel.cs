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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var deger = from x in db.TBLPERSONEL
                select new
                {
                    x.ID,
                    x.AD,
                    x.SOYAD,
                    x.MAIL
                };
            gridControl1.DataSource = deger.ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                select new
                {
                    x.ID,
                    x.AD
                }).ToList();
        }
    }
}
