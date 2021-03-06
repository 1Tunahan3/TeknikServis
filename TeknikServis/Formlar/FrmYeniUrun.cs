﻿using System;
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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db=new DbTeknikServisEntities();
            TBLURUN t=new TBLURUN();
            t.AD = txtUrunAd.Text;
            t.ALISFIYAT =decimal.Parse(txtUrunAlıs.Text);
            t.SATISFIYAT = decimal.Parse(txtUrunSatıs.Text);
            t.KATEGOR =byte.Parse(txtUrunKategorı.Text);
            t.STOK = short.Parse(txtStok.Text);
            t.MARKA = txtUrunMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }
    }
}
