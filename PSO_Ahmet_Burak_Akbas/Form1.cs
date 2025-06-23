using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PSO_Ahmet_Burak_Akbas;
using System.Collections.Generic;
using System.Linq;

namespace PSO_Ahmet_Burak_Akbas
{
    public partial class Form1 : Form
    {
        private PSOAlgorithm pso;
        private Chart convergenceChart;

        public Form1()
        { 
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            convergenceChart = new Chart();
            convergenceChart.Dock = DockStyle.Fill;
            convergenceChart.ChartAreas.Add(new ChartArea("Convergence"));
            convergenceChart.Series.Add(new Series("Fitness"));
            convergenceChart.Series["Fitness"].ChartType = SeriesChartType.Line;
            convergenceChart.Series["Fitness"].Color = Color.Red;
            convergenceChart.Series["Fitness"].BorderWidth = 3;
            convergenceChart.Series["Fitness"].MarkerStyle = MarkerStyle.Circle;
            convergenceChart.Series["Fitness"].MarkerSize = 5;
            convergenceChart.Series["Fitness"].MarkerColor = Color.Red;
            convergenceChart.Titles.Add("Yakınsama Grafiği");
            convergenceChart.ChartAreas[0].AxisX.Title = "Jenerasyon";
            convergenceChart.ChartAreas[0].AxisY.Title = "Amaç Fonksiyonu";
            convergenceChart.ChartAreas[0].AxisY.LabelStyle.Format = "N8";
            panel1.Controls.Add(convergenceChart);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                int particleCount = int.Parse(txtParticleCount.Text);
                double c1 = double.Parse(txtC1.Text);
                double c2 = double.Parse(txtC2.Text);
                double w = double.Parse(txtW.Text);
                int maxIterations = int.Parse(txtMaxIterations.Text);

                pso = new PSOAlgorithm(particleCount, -5, 5, c1, c2, w, maxIterations);
                pso.Run(ObjectiveFunction);

                DisplayResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ObjectiveFunction(double[] x)
        {
            // Six-hump Camel-back function
            double x1 = x[0];
            double x2 = x[1];
            return 4 * x1 * x1
                 - 2.1 * Math.Pow(x1, 4)
                 + (1.0 / 3.0) * Math.Pow(x1, 6)
                 + x1 * x2
                 - 4 * x2 * x2
                 + 4 * Math.Pow(x2, 4);
        }

        private void DisplayResults()
        { 
            convergenceChart.Series["Fitness"].Points.Clear();
    
            for (int i = 0; i < pso.ConvergenceHistory.Count; i++)
            {
                convergenceChart.Series["Fitness"].Points.AddXY(i, pso.ConvergenceHistory[i]);
            }

            txtBestFitness.Text = pso.GlobalBestFitness.ToString("F6");
            txtBestPosition.Text = string.Join(", ", pso.GlobalBestPosition);
        }
    }
}
