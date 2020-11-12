using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Main
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string[] seriesArray = { "Ativas", "Inativas" };
            int[] pointsArray = { 10, 2 };

            this.chartActives.Palette = ChartColorPalette.SeaGreen;

            this.chartActives.Titles.Add("Contas ativas");

            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chartActives.Series.Add(seriesArray[i]);

                series.Points.Add(pointsArray[i]);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chartActives.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chartActives.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
