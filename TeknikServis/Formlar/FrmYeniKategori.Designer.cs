
namespace TeknikServis.Formlar
{
    partial class FrmYeniKategori
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 4);
            this.panel1.TabIndex = 4;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.EditValue = "Urun Ad";
            this.txtUrunAd.Location = new System.Drawing.Point(14, 137);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(256, 22);
            this.txtUrunAd.TabIndex = 3;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(167, 222);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(138, 29);
            this.btnVazgec.TabIndex = 11;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(14, 222);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 29);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmYeniKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(323, 294);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUrunAd);
            this.Name = "FrmYeniKategori";
            this.Text = "FrmYeniKategori";
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
    }
}