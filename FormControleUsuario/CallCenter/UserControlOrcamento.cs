using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMars.FormControleUsuario.CallCenter
{
    public partial class UserControlOrcamento : UserControl
    {
        public UserControlOrcamento()
        {
            InitializeComponent();

            lblUsuario.Text = Program.UsuarioLogado;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Application.Exit(); // Fecha o aplicativo
            }
            // Se o usuário clicar em "Cancelar", nada acontece.
        }
    }
}
