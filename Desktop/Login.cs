using Main.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            SQLServices sQLServices = new SQLServices();
            if (sQLServices.login(Email, Password)) { 
                this.Visible = false;
                new MainMenu().Visible = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Register().Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
