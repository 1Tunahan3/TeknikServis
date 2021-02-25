
namespace TeknikServis.Formlar
{
    partial class FrmArızaListesi
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            simpleDiagram3D2.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D2;
            this.chartControl1.Location = new System.Drawing.Point(22, 18);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "Series 1";
            series2.View = pie3DSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(699, 290);
            this.chartControl1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chartControl1);
            this.panel5.Location = new System.Drawing.Point(799, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(724, 323);
            this.panel5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mevuct Arızalı Ürün Sayısı";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(872, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 96);
            this.panel4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parça Bekleyen Ürün Sayisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tadilati Btimiş Ürün Sayisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1328, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 96);
            this.panel1.TabIndex = 13;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(8, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(634, 596);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1070, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 96);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 96);
            this.panel2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Toplam Marka Sayısı";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(223, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 96);
            this.panel6.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "En Yüksek Fiyatlı Marka";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(872, 145);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 96);
            this.panel8.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Arızalı Ürünler Kasa";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Location = new System.Drawing.Point(1328, 145);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 96);
            this.panel9.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "En Fazla Arızalı Marka";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Location = new System.Drawing.Point(1070, 145);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(220, 96);
            this.panel10.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "Toplam Ürün Sayisi";
            // 
            // FrmArızaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 621);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmArızaListesi";
            this.Text = "FrmArızaListesi";
            this.Load += new System.EventHandler(this.FrmArızaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}