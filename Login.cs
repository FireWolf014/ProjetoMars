using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoMars
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';

            textBoxSenha.MaxLength = 14;

            textBoxSenha.TextAlign = HorizontalAlignment.Center;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
        }

        private void btnRedefinirsenha_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
