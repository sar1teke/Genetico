namespace Genetik_Algoritma_Odevi
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_Soru = new System.Windows.Forms.Label();
            this.label2_Pop = new System.Windows.Forms.Label();
            this.label1_Capraz = new System.Windows.Forms.Label();
            this.label2_Mut = new System.Windows.Forms.Label();
            this.label1_Seckinlik = new System.Windows.Forms.Label();
            this.label1_Jeneresyon = new System.Windows.Forms.Label();
            this.textBox1_pop = new System.Windows.Forms.TextBox();
            this.textBox2_Capraz = new System.Windows.Forms.TextBox();
            this.textBox3_Mut = new System.Windows.Forms.TextBox();
            this.textBox4_Seckinlik = new System.Windows.Forms.TextBox();
            this.textBox5_Jenerasyon = new System.Windows.Forms.TextBox();
            this.richTextBox1_sonuc = new System.Windows.Forms.RichTextBox();
            this.chart1_yakinasama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1_sonuc = new System.Windows.Forms.Label();
            this.label2_grafik = new System.Windows.Forms.Label();
            this.button1_basla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1_iterasyon = new System.Windows.Forms.Label();
            this.textBox1_Iterayon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_yakinasama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Soru
            // 
            this.label1_Soru.Location = new System.Drawing.Point(15, 9);
            this.label1_Soru.Name = "label1_Soru";
            this.label1_Soru.Size = new System.Drawing.Size(508, 53);
            this.label1_Soru.TabIndex = 0;
            this.label1_Soru.Text = "Problem";
            this.label1_Soru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_Pop
            // 
            this.label2_Pop.Location = new System.Drawing.Point(3, 167);
            this.label2_Pop.Name = "label2_Pop";
            this.label2_Pop.Size = new System.Drawing.Size(229, 49);
            this.label2_Pop.TabIndex = 1;
            this.label2_Pop.Text = "Popülasyon Büyüklüğü";
            this.label2_Pop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Capraz
            // 
            this.label1_Capraz.Location = new System.Drawing.Point(48, 311);
            this.label1_Capraz.Name = "label1_Capraz";
            this.label1_Capraz.Size = new System.Drawing.Size(129, 49);
            this.label1_Capraz.TabIndex = 1;
            this.label1_Capraz.Text = "Çaprazlama Oranı";
            this.label1_Capraz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_Mut
            // 
            this.label2_Mut.Location = new System.Drawing.Point(300, 167);
            this.label2_Mut.Name = "label2_Mut";
            this.label2_Mut.Size = new System.Drawing.Size(232, 49);
            this.label2_Mut.TabIndex = 1;
            this.label2_Mut.Text = "Mutasyon Oranı";
            this.label2_Mut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Seckinlik
            // 
            this.label1_Seckinlik.Location = new System.Drawing.Point(356, 311);
            this.label1_Seckinlik.Name = "label1_Seckinlik";
            this.label1_Seckinlik.Size = new System.Drawing.Size(129, 49);
            this.label1_Seckinlik.TabIndex = 1;
            this.label1_Seckinlik.Text = "Seçkinlik";
            this.label1_Seckinlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_Jeneresyon
            // 
            this.label1_Jeneresyon.Location = new System.Drawing.Point(48, 449);
            this.label1_Jeneresyon.Name = "label1_Jeneresyon";
            this.label1_Jeneresyon.Size = new System.Drawing.Size(129, 49);
            this.label1_Jeneresyon.TabIndex = 1;
            this.label1_Jeneresyon.Text = "Jenerasyon Sayısı";
            this.label1_Jeneresyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_pop
            // 
            this.textBox1_pop.Location = new System.Drawing.Point(15, 219);
            this.textBox1_pop.Name = "textBox1_pop";
            this.textBox1_pop.Size = new System.Drawing.Size(200, 22);
            this.textBox1_pop.TabIndex = 2;
            // 
            // textBox2_Capraz
            // 
            this.textBox2_Capraz.Location = new System.Drawing.Point(15, 363);
            this.textBox2_Capraz.Name = "textBox2_Capraz";
            this.textBox2_Capraz.Size = new System.Drawing.Size(200, 22);
            this.textBox2_Capraz.TabIndex = 2;
            // 
            // textBox3_Mut
            // 
            this.textBox3_Mut.Location = new System.Drawing.Point(318, 219);
            this.textBox3_Mut.Name = "textBox3_Mut";
            this.textBox3_Mut.Size = new System.Drawing.Size(205, 22);
            this.textBox3_Mut.TabIndex = 2;
            // 
            // textBox4_Seckinlik
            // 
            this.textBox4_Seckinlik.Location = new System.Drawing.Point(318, 363);
            this.textBox4_Seckinlik.Name = "textBox4_Seckinlik";
            this.textBox4_Seckinlik.Size = new System.Drawing.Size(211, 22);
            this.textBox4_Seckinlik.TabIndex = 2;
            // 
            // textBox5_Jenerasyon
            // 
            this.textBox5_Jenerasyon.Location = new System.Drawing.Point(6, 501);
            this.textBox5_Jenerasyon.Name = "textBox5_Jenerasyon";
            this.textBox5_Jenerasyon.Size = new System.Drawing.Size(209, 22);
            this.textBox5_Jenerasyon.TabIndex = 2;
            // 
            // richTextBox1_sonuc
            // 
            this.richTextBox1_sonuc.Location = new System.Drawing.Point(565, 100);
            this.richTextBox1_sonuc.Name = "richTextBox1_sonuc";
            this.richTextBox1_sonuc.Size = new System.Drawing.Size(292, 423);
            this.richTextBox1_sonuc.TabIndex = 3;
            this.richTextBox1_sonuc.Text = "";
            // 
            // chart1_yakinasama
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1_yakinasama.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1_yakinasama.Legends.Add(legend1);
            this.chart1_yakinasama.Location = new System.Drawing.Point(878, 100);
            this.chart1_yakinasama.Name = "chart1_yakinasama";
            this.chart1_yakinasama.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1_yakinasama.Series.Add(series1);
            this.chart1_yakinasama.Size = new System.Drawing.Size(431, 429);
            this.chart1_yakinasama.TabIndex = 4;
            this.chart1_yakinasama.Text = "chart1";
            // 
            // label1_sonuc
            // 
            this.label1_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_sonuc.Location = new System.Drawing.Point(562, 27);
            this.label1_sonuc.Name = "label1_sonuc";
            this.label1_sonuc.Size = new System.Drawing.Size(295, 58);
            this.label1_sonuc.TabIndex = 5;
            this.label1_sonuc.Text = "Çözümler";
            this.label1_sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_grafik
            // 
            this.label2_grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_grafik.Location = new System.Drawing.Point(873, 27);
            this.label2_grafik.Name = "label2_grafik";
            this.label2_grafik.Size = new System.Drawing.Size(436, 58);
            this.label2_grafik.TabIndex = 5;
            this.label2_grafik.Text = "Yakınsama Grafiği";
            this.label2_grafik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_basla
            // 
            this.button1_basla.Location = new System.Drawing.Point(466, 471);
            this.button1_basla.Name = "button1_basla";
            this.button1_basla.Size = new System.Drawing.Size(66, 52);
            this.button1_basla.TabIndex = 6;
            this.button1_basla.Text = "Başla";
            this.button1_basla.UseVisualStyleBackColor = true;
            this.button1_basla.Click += new System.EventHandler(this.button1_basla_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 78);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1_iterasyon
            // 
            this.label1_iterasyon.Location = new System.Drawing.Point(315, 449);
            this.label1_iterasyon.Name = "label1_iterasyon";
            this.label1_iterasyon.Size = new System.Drawing.Size(129, 49);
            this.label1_iterasyon.TabIndex = 1;
            this.label1_iterasyon.Text = "İterasyon Sayısı";
            this.label1_iterasyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_Iterayon
            // 
            this.textBox1_Iterayon.Location = new System.Drawing.Point(318, 501);
            this.textBox1_Iterayon.Name = "textBox1_Iterayon";
            this.textBox1_Iterayon.Size = new System.Drawing.Size(126, 22);
            this.textBox1_Iterayon.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1_basla);
            this.Controls.Add(this.label2_grafik);
            this.Controls.Add(this.label1_sonuc);
            this.Controls.Add(this.chart1_yakinasama);
            this.Controls.Add(this.richTextBox1_sonuc);
            this.Controls.Add(this.textBox1_Iterayon);
            this.Controls.Add(this.textBox5_Jenerasyon);
            this.Controls.Add(this.textBox4_Seckinlik);
            this.Controls.Add(this.textBox3_Mut);
            this.Controls.Add(this.textBox2_Capraz);
            this.Controls.Add(this.textBox1_pop);
            this.Controls.Add(this.label1_iterasyon);
            this.Controls.Add(this.label1_Jeneresyon);
            this.Controls.Add(this.label1_Seckinlik);
            this.Controls.Add(this.label2_Mut);
            this.Controls.Add(this.label1_Capraz);
            this.Controls.Add(this.label2_Pop);
            this.Controls.Add(this.label1_Soru);
            this.Name = "Form1";
            this.Text = "Genetik Algortima";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1_yakinasama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Soru;
        private System.Windows.Forms.Label label2_Pop;
        private System.Windows.Forms.Label label1_Capraz;
        private System.Windows.Forms.Label label2_Mut;
        private System.Windows.Forms.Label label1_Seckinlik;
        private System.Windows.Forms.Label label1_Jeneresyon;
        private System.Windows.Forms.TextBox textBox1_pop;
        private System.Windows.Forms.TextBox textBox2_Capraz;
        private System.Windows.Forms.TextBox textBox3_Mut;
        private System.Windows.Forms.TextBox textBox4_Seckinlik;
        private System.Windows.Forms.TextBox textBox5_Jenerasyon;
        private System.Windows.Forms.RichTextBox richTextBox1_sonuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_yakinasama;
        private System.Windows.Forms.Label label1_sonuc;
        private System.Windows.Forms.Label label2_grafik;
        private System.Windows.Forms.Button button1_basla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1_iterasyon;
        private System.Windows.Forms.TextBox textBox1_Iterayon;
    }
}

