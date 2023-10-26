using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoMars
{



    public partial class PainelPrincipal : Form
    {   
        private Boolean showpanelCallCenter = false;
        private Boolean showpanelEstoqueCustos = false;
        private Boolean showpanelFaturamento = false;
        private Boolean showpanelLivrosFiscais = false;
        private Boolean showpanelOrcamento = false;

        private void tooglePanels()
        {
            if (showpanelCallCenter)
            {
                panelCallCenter.Height = 170;

            }
            else
            {
                panelCallCenter.Height = 0;
            }

            if (showpanelEstoqueCustos)
            {
                panelEstoqueCustos.Height = 130;

            }
            else
            {
                panelEstoqueCustos.Height = 0;
            }

            if (showpanelFaturamento)
            {
                panelFaturamento.Height = 100;
            }
            else
            {
                panelFaturamento.Height = 0;
            }

            if (showpanelLivrosFiscais)
            {
                panelLivrosFiscais.Height = 30;
            }
            else
            {
                panelLivrosFiscais.Height = 0;
            }

        }

        public PainelPrincipal()
        {
            InitializeComponent();

            tooglePanels(); 
        }
        private void PainelPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNotificacoes_Click(object sender, EventArgs e)
        {

        }

        private void btnCallCenter_Click(object sender, EventArgs e)
        {
            showpanelEstoqueCustos = false;
            showpanelFaturamento = false;
            showpanelLivrosFiscais = false;

            showpanelCallCenter = !showpanelCallCenter;


            tooglePanels();
        }

        private void btnEstoqueCusto_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelFaturamento = false;
            showpanelLivrosFiscais = false;

            showpanelEstoqueCustos = !showpanelEstoqueCustos;
            tooglePanels();
        }

        private void btnFaturamento_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelEstoqueCustos = false;
            showpanelLivrosFiscais = false;

            showpanelFaturamento = !showpanelFaturamento;
            tooglePanels();

        }

        private void panelCallCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLivrosFiscal_Click(object sender, EventArgs e)
        {
            showpanelCallCenter = false;
            showpanelEstoqueCustos = false;
            showpanelFaturamento = false;

            showpanelLivrosFiscais = !showpanelLivrosFiscais;
            tooglePanels();

        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
                     
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAprocaoComercial_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
