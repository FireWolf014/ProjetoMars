namespace ProjetoMars.FormControleUsuario.CallCenter
{
    partial class UserControlOrcamento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrcamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pinelBtn = new System.Windows.Forms.Panel();
            this.btnIncluirAtendimento = new System.Windows.Forms.Button();
            this.btnVisualizarAtendimento = new System.Windows.Forms.Button();
            this.btnCopiarAtendimento = new System.Windows.Forms.Button();
            this.panelNavbarOrcamento = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnNotificacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscarAtend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pinelBtn.SuspendLayout();
            this.panelNavbarOrcamento.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pinelBtn);
            this.panel1.Controls.Add(this.panelNavbarOrcamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 705);
            this.panel1.TabIndex = 1;
            // 
            // pinelBtn
            // 
            this.pinelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.pinelBtn.Controls.Add(this.btnIncluirAtendimento);
            this.pinelBtn.Controls.Add(this.btnVisualizarAtendimento);
            this.pinelBtn.Controls.Add(this.btnCopiarAtendimento);
            this.pinelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pinelBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinelBtn.ForeColor = System.Drawing.Color.White;
            this.pinelBtn.Location = new System.Drawing.Point(0, 49);
            this.pinelBtn.Name = "pinelBtn";
            this.pinelBtn.Size = new System.Drawing.Size(1074, 39);
            this.pinelBtn.TabIndex = 7;
            // 
            // btnIncluirAtendimento
            // 
            this.btnIncluirAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluirAtendimento.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIncluirAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirAtendimento.FlatAppearance.BorderSize = 0;
            this.btnIncluirAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirAtendimento.ForeColor = System.Drawing.Color.White;
            this.btnIncluirAtendimento.Location = new System.Drawing.Point(3, 6);
            this.btnIncluirAtendimento.Name = "btnIncluirAtendimento";
            this.btnIncluirAtendimento.Size = new System.Drawing.Size(82, 29);
            this.btnIncluirAtendimento.TabIndex = 2;
            this.btnIncluirAtendimento.Text = "+ Incluir";
            this.btnIncluirAtendimento.UseVisualStyleBackColor = false;
            // 
            // btnVisualizarAtendimento
            // 
            this.btnVisualizarAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisualizarAtendimento.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVisualizarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarAtendimento.FlatAppearance.BorderSize = 0;
            this.btnVisualizarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAtendimento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVisualizarAtendimento.Location = new System.Drawing.Point(228, 6);
            this.btnVisualizarAtendimento.Name = "btnVisualizarAtendimento";
            this.btnVisualizarAtendimento.Size = new System.Drawing.Size(82, 29);
            this.btnVisualizarAtendimento.TabIndex = 4;
            this.btnVisualizarAtendimento.Text = "Copiar";
            this.btnVisualizarAtendimento.UseVisualStyleBackColor = false;
            // 
            // btnCopiarAtendimento
            // 
            this.btnCopiarAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiarAtendimento.BackColor = System.Drawing.Color.Crimson;
            this.btnCopiarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiarAtendimento.FlatAppearance.BorderSize = 0;
            this.btnCopiarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarAtendimento.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCopiarAtendimento.Location = new System.Drawing.Point(115, 6);
            this.btnCopiarAtendimento.Name = "btnCopiarAtendimento";
            this.btnCopiarAtendimento.Size = new System.Drawing.Size(82, 29);
            this.btnCopiarAtendimento.TabIndex = 3;
            this.btnCopiarAtendimento.Text = "Visulizar";
            this.btnCopiarAtendimento.UseVisualStyleBackColor = false;
            // 
            // panelNavbarOrcamento
            // 
            this.panelNavbarOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.panelNavbarOrcamento.Controls.Add(this.panel11);
            this.panelNavbarOrcamento.Controls.Add(this.label1);
            this.panelNavbarOrcamento.Controls.Add(this.panel3);
            this.panelNavbarOrcamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbarOrcamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelNavbarOrcamento.Location = new System.Drawing.Point(0, 0);
            this.panelNavbarOrcamento.Name = "panelNavbarOrcamento";
            this.panelNavbarOrcamento.Size = new System.Drawing.Size(1074, 49);
            this.panelNavbarOrcamento.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblUsuario);
            this.panel11.Controls.Add(this.btnNotificacao);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(889, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(185, 49);
            this.panel11.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(45, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnNotificacao
            // 
            this.btnNotificacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificacao.FlatAppearance.BorderSize = 0;
            this.btnNotificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacao.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            this.btnNotificacao.ForeColor = System.Drawing.Color.White;
            this.btnNotificacao.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificacao.Image")));
            this.btnNotificacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificacao.Location = new System.Drawing.Point(3, 18);
            this.btnNotificacao.Name = "btnNotificacao";
            this.btnNotificacao.Size = new System.Drawing.Size(157, 31);
            this.btnNotificacao.TabIndex = 2;
            this.btnNotificacao.Text = "Notificação";
            this.btnNotificacao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orçamento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnBuscarAtend);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 46);
            this.panel3.TabIndex = 0;
            // 
            // btnBuscarAtend
            // 
            this.btnBuscarAtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAtend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.btnBuscarAtend.FlatAppearance.BorderSize = 0;
            this.btnBuscarAtend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.btnBuscarAtend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarAtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAtend.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAtend.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAtend.Image")));
            this.btnBuscarAtend.Location = new System.Drawing.Point(237, 3);
            this.btnBuscarAtend.Name = "btnBuscarAtend";
            this.btnBuscarAtend.Size = new System.Drawing.Size(46, 37);
            this.btnBuscarAtend.TabIndex = 0;
            this.btnBuscarAtend.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(19, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Buscar Orcamento";
            // 
            // UserControlOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlOrcamento";
            this.Size = new System.Drawing.Size(1074, 705);
            this.panel1.ResumeLayout(false);
            this.pinelBtn.ResumeLayout(false);
            this.panelNavbarOrcamento.ResumeLayout(false);
            this.panelNavbarOrcamento.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pinelBtn;
        private System.Windows.Forms.Button btnIncluirAtendimento;
        private System.Windows.Forms.Button btnVisualizarAtendimento;
        private System.Windows.Forms.Button btnCopiarAtendimento;
        private System.Windows.Forms.Panel panelNavbarOrcamento;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnNotificacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarAtend;
        private System.Windows.Forms.TextBox textBox1;
    }
}
