namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnMensagens = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.painel1 = new System.Windows.Forms.Panel();
            this.painel2 = new System.Windows.Forms.Panel();
            this.painel3 = new System.Windows.Forms.Panel();
            this.lblTituloChamados = new System.Windows.Forms.Label();
            this.lblTotalChamados = new System.Windows.Forms.Label();
            this.lblChamadosAtendidos = new System.Windows.Forms.Label();
            this.lblTituloChamadosAtendidos = new System.Windows.Forms.Label();
            this.lblUltimoChamado = new System.Windows.Forms.Label();
            this.lblTituloUltimosChamados = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.painel1.SuspendLayout();
            this.painel2.SuspendLayout();
            this.painel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnMensagens);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnChamados);
            this.panel1.Controls.Add(this.btninicio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(219, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 58);
            this.panel2.TabIndex = 0;
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.Black;
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(5, 63);
            this.btninicio.Name = "btninicio";
            this.btninicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btninicio.Size = new System.Drawing.Size(209, 55);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "Início";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninicio.UseVisualStyleBackColor = false;
            // 
            // btnChamados
            // 
            this.btnChamados.BackColor = System.Drawing.Color.Black;
            this.btnChamados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamados.ForeColor = System.Drawing.Color.White;
            this.btnChamados.Location = new System.Drawing.Point(5, 118);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChamados.Size = new System.Drawing.Size(209, 55);
            this.btnChamados.TabIndex = 2;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamados.UseVisualStyleBackColor = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Black;
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(5, 173);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHistorico.Size = new System.Drawing.Size(209, 55);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // btnMensagens
            // 
            this.btnMensagens.BackColor = System.Drawing.Color.Black;
            this.btnMensagens.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMensagens.ForeColor = System.Drawing.Color.White;
            this.btnMensagens.Location = new System.Drawing.Point(5, 228);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMensagens.Size = new System.Drawing.Size(209, 55);
            this.btnMensagens.TabIndex = 4;
            this.btnMensagens.Text = "Mensagens";
            this.btnMensagens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagens.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(5, 650);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(209, 48);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblInicio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1249, 63);
            this.panel3.TabIndex = 1;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(48, 17);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(81, 32);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Início";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1055, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(219, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1249, 640);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.painel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.painel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.painel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1249, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // painel1
            // 
            this.painel1.BackColor = System.Drawing.Color.Red;
            this.painel1.Controls.Add(this.lblTotalChamados);
            this.painel1.Controls.Add(this.lblTituloChamados);
            this.painel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel1.Location = new System.Drawing.Point(13, 13);
            this.painel1.Name = "painel1";
            this.painel1.Size = new System.Drawing.Size(403, 257);
            this.painel1.TabIndex = 0;
            // 
            // painel2
            // 
            this.painel2.BackColor = System.Drawing.Color.Red;
            this.painel2.Controls.Add(this.lblChamadosAtendidos);
            this.painel2.Controls.Add(this.lblTituloChamadosAtendidos);
            this.painel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel2.Location = new System.Drawing.Point(422, 13);
            this.painel2.Name = "painel2";
            this.painel2.Size = new System.Drawing.Size(403, 257);
            this.painel2.TabIndex = 1;
            // 
            // painel3
            // 
            this.painel3.BackColor = System.Drawing.Color.Red;
            this.painel3.Controls.Add(this.lblUltimoChamado);
            this.painel3.Controls.Add(this.lblTituloUltimosChamados);
            this.painel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel3.Location = new System.Drawing.Point(831, 13);
            this.painel3.Name = "painel3";
            this.painel3.Size = new System.Drawing.Size(405, 257);
            this.painel3.TabIndex = 2;
            // 
            // lblTituloChamados
            // 
            this.lblTituloChamados.AutoSize = true;
            this.lblTituloChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChamados.ForeColor = System.Drawing.Color.White;
            this.lblTituloChamados.Location = new System.Drawing.Point(18, 151);
            this.lblTituloChamados.Name = "lblTituloChamados";
            this.lblTituloChamados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTituloChamados.Size = new System.Drawing.Size(289, 36);
            this.lblTituloChamados.TabIndex = 0;
            this.lblTituloChamados.Text = "Total de Chamados";
            // 
            // lblTotalChamados
            // 
            this.lblTotalChamados.AutoSize = true;
            this.lblTotalChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChamados.ForeColor = System.Drawing.Color.White;
            this.lblTotalChamados.Location = new System.Drawing.Point(18, 199);
            this.lblTotalChamados.Name = "lblTotalChamados";
            this.lblTotalChamados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalChamados.Size = new System.Drawing.Size(49, 36);
            this.lblTotalChamados.TabIndex = 1;
            this.lblTotalChamados.Text = "22";
            // 
            // lblChamadosAtendidos
            // 
            this.lblChamadosAtendidos.AutoSize = true;
            this.lblChamadosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamadosAtendidos.ForeColor = System.Drawing.Color.White;
            this.lblChamadosAtendidos.Location = new System.Drawing.Point(23, 199);
            this.lblChamadosAtendidos.Name = "lblChamadosAtendidos";
            this.lblChamadosAtendidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChamadosAtendidos.Size = new System.Drawing.Size(49, 36);
            this.lblChamadosAtendidos.TabIndex = 3;
            this.lblChamadosAtendidos.Text = "22";
            // 
            // lblTituloChamadosAtendidos
            // 
            this.lblTituloChamadosAtendidos.AutoSize = true;
            this.lblTituloChamadosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChamadosAtendidos.ForeColor = System.Drawing.Color.White;
            this.lblTituloChamadosAtendidos.Location = new System.Drawing.Point(23, 151);
            this.lblTituloChamadosAtendidos.Name = "lblTituloChamadosAtendidos";
            this.lblTituloChamadosAtendidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTituloChamadosAtendidos.Size = new System.Drawing.Size(318, 36);
            this.lblTituloChamadosAtendidos.TabIndex = 2;
            this.lblTituloChamadosAtendidos.Text = "Chamados Atendidos";
            // 
            // lblUltimoChamado
            // 
            this.lblUltimoChamado.AutoSize = true;
            this.lblUltimoChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoChamado.ForeColor = System.Drawing.Color.White;
            this.lblUltimoChamado.Location = new System.Drawing.Point(28, 199);
            this.lblUltimoChamado.Name = "lblUltimoChamado";
            this.lblUltimoChamado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUltimoChamado.Size = new System.Drawing.Size(49, 36);
            this.lblUltimoChamado.TabIndex = 5;
            this.lblUltimoChamado.Text = "22";
            // 
            // lblTituloUltimosChamados
            // 
            this.lblTituloUltimosChamados.AutoSize = true;
            this.lblTituloUltimosChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUltimosChamados.ForeColor = System.Drawing.Color.White;
            this.lblTituloUltimosChamados.Location = new System.Drawing.Point(28, 151);
            this.lblTituloUltimosChamados.Name = "lblTituloUltimosChamados";
            this.lblTituloUltimosChamados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTituloUltimosChamados.Size = new System.Drawing.Size(248, 36);
            this.lblTituloUltimosChamados.TabIndex = 4;
            this.lblTituloUltimosChamados.Text = "Ultimo Chamado";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblHorario);
            this.panel5.Controls.Add(this.lblData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1249, 121);
            this.panel5.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(5, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(441, 46);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "09 de outubro de 2024";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(1044, 34);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(172, 46);
            this.lblHorario.TabIndex = 1;
            this.lblHorario.Text = "12:00 hs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 703);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.painel1.ResumeLayout(false);
            this.painel1.PerformLayout();
            this.painel2.ResumeLayout(false);
            this.painel2.PerformLayout();
            this.painel3.ResumeLayout(false);
            this.painel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMensagens;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel painel1;
        private System.Windows.Forms.Panel painel2;
        private System.Windows.Forms.Panel painel3;
        private System.Windows.Forms.Label lblTotalChamados;
        private System.Windows.Forms.Label lblTituloChamados;
        private System.Windows.Forms.Label lblChamadosAtendidos;
        private System.Windows.Forms.Label lblTituloChamadosAtendidos;
        private System.Windows.Forms.Label lblUltimoChamado;
        private System.Windows.Forms.Label lblTituloUltimosChamados;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHorario;
    }
}

