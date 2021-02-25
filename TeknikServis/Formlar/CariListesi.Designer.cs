
namespace TeknikServis.Formlar
{
    partial class CariListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunSatisFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(14, 197);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1106, 414);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1180, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cari ID";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Enabled = false;
            this.txtUrunId.Location = new System.Drawing.Point(1275, 52);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(158, 22);
            this.txtUrunId.TabIndex = 35;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1168, 543);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(149, 36);
            this.btnListele.TabIndex = 34;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(1340, 486);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(149, 36);
            this.btnSilme.TabIndex = 33;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1340, 543);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 36);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelleme";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1168, 486);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 36);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1180, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Soyad";
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Location = new System.Drawing.Point(1275, 130);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(158, 22);
            this.txtUrunMarka.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1180, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1180, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "İl";
            // 
            // txtUrunSatisFiyat
            // 
            this.txtUrunSatisFiyat.Location = new System.Drawing.Point(1275, 293);
            this.txtUrunSatisFiyat.Name = "txtUrunSatisFiyat";
            this.txtUrunSatisFiyat.Size = new System.Drawing.Size(158, 22);
            this.txtUrunSatisFiyat.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1180, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vergi Dairesi";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(1275, 330);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(158, 22);
            this.txtUrunStok.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1180, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Banka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1180, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "AD";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(1275, 90);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(158, 22);
            this.txtUrunAd.TabIndex = 20;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(1275, 214);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(158, 22);
            this.lookUpEdit1.TabIndex = 37;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(1275, 175);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.BeepOnError = false;
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.textEdit1.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.textEdit1.Size = new System.Drawing.Size(158, 22);
            this.textEdit1.TabIndex = 38;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(1275, 253);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(158, 22);
            this.lookUpEdit2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1180, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "İlçe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1180, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Vergi No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1275, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1180, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Statü";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1275, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1180, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Adres";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1275, 449);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(14, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 133);
            this.panel1.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Toplam Cari Sayısı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "label13";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(282, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 133);
            this.panel2.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Aktif Cari Sayısı";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(535, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 133);
            this.panel3.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Toplam İl Sayısı";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(787, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 133);
            this.panel4.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "En Fazla Cari İl";
            // 
            // CariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUrunMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunSatisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.gridControl1);
            this.Name = "CariListesi";
            this.Text = "CariListesi";
            this.Load += new System.EventHandler(this.CariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunSatisFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}