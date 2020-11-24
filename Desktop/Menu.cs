using Main.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Desktop
{
    public partial class MainMenu : Form
    {
        private SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=PIM_DB;Trusted_Connection=True;");

        public MainMenu()
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
            this.ListBestCustomers.Visible = false;
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
            this.ListBestCustomers.Visible = false;
            this.chartActives.Series.Clear();

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(AccountStatus) FROM Customers WHERE AccountStatus = 1;";
            int[] pointsArray = { int.Parse(cmd.ExecuteScalar().ToString()) };
            conn.Close();
            this.chartActives.Palette = ChartColorPalette.SeaGreen;

            Series series = this.chartActives.Series.Add("Ativas");
            series.Points.Add(pointsArray[0]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chartActives.Visible = false;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            this.ListBestCustomers.Items.Clear();
            this.chartActives.Visible = false;
            this.ListBestCustomers.Visible = true;
            List<int> _items = new SQLServices().GetBestClientsNumbers();

            List<string> _items2 = new SQLServices().GetBestClientsEmail();


            this.ListBestCustomers.Items.AddRange(new object[] {"Quatidade de compras || Email" });

            foreach (int item in _items)
            {
                this.ListBestCustomers.Items.AddRange(new object[] { _items[i]+"                                   || "+_items2[i] });
                i++;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
