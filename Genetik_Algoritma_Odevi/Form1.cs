using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Genetik_Algoritma_Odevi
{
    public partial class Form1 : Form
    {
        private GenetikAlgoritma genetikAlgoritma;

        public Form1()
        {
            InitializeComponent();
            genetikAlgoritma = new GenetikAlgoritma();
            this.Load += Form1_Load;
        }
      
        private void CizYakinsamaGrafik(List<double> yakinsamaGrafik)
        {
            chart1_yakinasama.Series.Clear();
            chart1_yakinasama.ChartAreas.Clear();
            chart1_yakinasama.ChartAreas.Add("Yakınsama");

            // Yakınsama mevzusu
            chart1_yakinasama.Series.Add("Yakınsama");
            chart1_yakinasama.Series["Yakınsama"].ChartType = SeriesChartType.Line;

            // Verileri ekle
            for (int i = 0; i < yakinsamaGrafik.Count; i++)
            {
                chart1_yakinasama.Series["Yakınsama"].Points.AddXY(i, yakinsamaGrafik[i]);
            }

            // X ekseni etiketi olarak iterasyon sayısını ekle
            chart1_yakinasama.ChartAreas[0].AxisX.Title = "İterasyon";
            
            chart1_yakinasama.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1_pop.Text = "50";
            textBox2_Capraz.Text = "0.7";
            textBox3_Mut.Text = "0.01";
            textBox4_Seckinlik.Text = "0.05";
            textBox5_Jenerasyon.Text = "1000";
            textBox1_Iterayon.Text = "100";

        }

        private void button1_basla_Click_1(object sender, EventArgs e)
        {
            // Genetik algoritma parametrelerini formdan al
            int popSize = int.Parse(textBox1_pop.Text);
            double crossRate = double.Parse(textBox2_Capraz.Text);
            double mutRate = double.Parse(textBox3_Mut.Text);
            double eliteRate = double.Parse(textBox4_Seckinlik.Text);
            int generationCount = int.Parse(textBox5_Jenerasyon.Text);
            int iterationCount = Convert.ToInt32(textBox1_Iterayon.Text);

            genetikAlgoritma.Baslat(popSize, crossRate, mutRate, eliteRate, generationCount, iterationCount);
            
            richTextBox1_sonuc.Text = "En iyi çözümler: \n\n" + string.Join(",            ", genetikAlgoritma.EnIyiCozum) + Environment.NewLine;
            richTextBox1_sonuc.Text += "\nFitness değeri: \n\n" + genetikAlgoritma.EnIyiSonuc;

            // Yakınsama grafiğini çizdirme
            CizYakinsamaGrafik(genetikAlgoritma.YakinsamaGrafik);
        }
    }
}
