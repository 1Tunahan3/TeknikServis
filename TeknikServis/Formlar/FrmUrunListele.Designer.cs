
namespace TeknikServis.Formlar
{
    partial class FrmUrunListele
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
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunAlisFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1076, 974);
            this.gridControl1.TabIndex = 0;
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
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(1214, 68);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(158, 22);
            this.txtUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1119, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1119, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1119, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok";
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.Location = new System.Drawing.Point(1214, 231);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(158, 22);
            this.txtUrunStok.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1119, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satış Fiyatı";
            // 
            // txtUrunSatisFiyat
            // 
            this.txtUrunSatisFiyat.Location = new System.Drawing.Point(1214, 190);
            this.txtUrunSatisFiyat.Name = "txtUrunSatisFiyat";
            this.txtUrunSatisFiyat.Size = new System.Drawing.Size(158, 22);
            this.txtUrunSatisFiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1119, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alış Fiyatı";
            // 
            // txtUrunAlisFiyat
            // 
            this.txtUrunAlisFiyat.Location = new System.Drawing.Point(1214, 151);
            this.txtUrunAlisFiyat.Name = "txtUrunAlisFiyat";
            this.txtUrunAlisFiyat.Size = new System.Drawing.Size(158, 22);
            this.txtUrunAlisFiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1119, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marka";
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Location = new System.Drawing.Point(1214, 108);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(158, 22);
            this.txtUrunMarka.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1086, 332);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 36);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1258, 389);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(149, 36);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelleme";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(1258, 332);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(149, 36);
            this.btnSilme.TabIndex = 16;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(1086, 389);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(149, 36);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1119, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ürün ID";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Enabled = false;
            this.txtUrunId.Location = new System.Drawing.Point(1214, 30);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(158, 22);
            this.txtUrunId.TabIndex = 18;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(1518, 341);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(248, 22);
            this.lookUpEdit1.TabIndex = 20;
            // 
            // FrmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1594, 624);
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
            this.Controls.Add(this.txtUrunAlisFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunSatisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunListele";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunSatisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunAlisFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunId;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}