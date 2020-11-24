using Main.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SocialName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Identification_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndividualTaxpayerRegistration_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssuingBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShippingDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void FatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MotherName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Confirm_btn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            Admin Admin = new Admin(FirstName.Text, LastName.Text, SocialName.Text, Email.Text, Password.Text, BirthDay.Value.Date);
            var jsonAdmin = JsonConvert.SerializeObject(Admin);
            var stringContent = new StringContent(jsonAdmin, UnicodeEncoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44343/api/Users/Register", stringContent);
            RegisterWorkRecordBooklet(Email.Text);
        }

        private async void RegisterWorkRecordBooklet(string email)
        {
            var client = new HttpClient();
            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=PIM_DB;Trusted_Connection=True;");
            string SQLQuery = "SELECT Id FROM Users WHERE Email='{0}'";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(SQLQuery, email);
            
            string UserId = cmd.ExecuteScalar().ToString();
            WorkRecordBooklet WorkRecordBooklet = new WorkRecordBooklet(Number.Text,Serial.Text,BirthPlace.Text,BirthDay.Value.Date,FatherName.Text,MotherName.Text,ShippingDate.Value.Date,UserId);
            var jsonAdmin = JsonConvert.SerializeObject(WorkRecordBooklet);
            var stringContent = new StringContent(jsonAdmin, UnicodeEncoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44343/api/WorkRecordBooklets", stringContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
                this.Visible = false;
                new MainMenu().Visible = true;
            }
            conn.Close();
        }
    }
}
