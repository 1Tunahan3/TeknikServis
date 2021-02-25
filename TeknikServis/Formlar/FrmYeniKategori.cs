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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORILER t=new TBLKATEGORILER();
            t.AD = txtUrunAd.Text;
            db.TBLKATEGORILER.Add(t);
            db.SaveChanges();
            Console.WriteLine("Eklendi");
        }
    }
}
