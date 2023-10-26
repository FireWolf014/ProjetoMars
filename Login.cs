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
using MySql.Data.MySqlClient;


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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxUsername.Text;

            string cmdSql = $"CALL ConsultarSysUsrPorUsuario('{login}');";

            var dados = Program.conn.SELECT(cmdSql);

            if (dados != null)
            {
                DataRow dadosLogin = dados.Rows[0];
                string senhaUSR = dadosLogin["USR_PWD"].ToString();
                if (senhaUSR == textBoxSenha.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Senha inválida");
                }
            }
            else
            {
                MessageBox.Show("Usuario nao encontrado");
            }
        }
    }
}
