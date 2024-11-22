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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnChamados = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panelDesktopView = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnHistorico);
            this.panel1.Controls.Add(this.btnChamados);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btninicio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(289, 562);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(4, 489);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(281, 69);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Black;
            this.btnHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(4, 224);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnHistorico.Size = new System.Drawing.Size(281, 58);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnChamados
            // 
            this.btnChamados.BackColor = System.Drawing.Color.Black;
            this.btnChamados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamados.ForeColor = System.Drawing.Color.White;
            this.btnChamados.Location = new System.Drawing.Point(4, 166);
            this.btnChamados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnChamados.Size = new System.Drawing.Size(281, 58);
            this.btnChamados.TabIndex = 2;
            this.btnChamados.Text = "Chamados";
            this.btnChamados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamados.UseVisualStyleBackColor = false;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Black;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(4, 108);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnConsulta.Size = new System.Drawing.Size(281, 58);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Pesquisar";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.Black;
            this.btninicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(4, 50);
            this.btninicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninicio.Name = "btninicio";
            this.btninicio.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btninicio.Size = new System.Drawing.Size(281, 58);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "Início";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 46);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblInicio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(289, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(1016, 50);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(43, 14);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(70, 29);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Início";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDesktopView
            // 
            this.panelDesktopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopView.Location = new System.Drawing.Point(289, 50);
            this.panelDesktopView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopView.Name = "panelDesktopView";
            this.panelDesktopView.Size = new System.Drawing.Size(1016, 512);
            this.panelDesktopView.TabIndex = 2;
            this.panelDesktopView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopView_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 562);
            this.Controls.Add(this.panelDesktopView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopView;
        private System.Windows.Forms.Button btnConsulta;
    }
}

