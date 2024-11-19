namespace WindowsFormsApp2.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pendentes = new System.Windows.Forms.Label();
            this.lbl_totalPendentes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chamadosAtendidos = new System.Windows.Forms.Label();
            this.lbl_chamadosAtendidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalChamados = new System.Windows.Forms.Label();
            this.lbl_totalChamados = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 290);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.pendentes);
            this.panel3.Controls.Add(this.lbl_totalPendentes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(770, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 260);
            this.panel3.TabIndex = 2;
            // 
            // pendentes
            // 
            this.pendentes.AutoSize = true;
            this.pendentes.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendentes.ForeColor = System.Drawing.Color.White;
            this.pendentes.Location = new System.Drawing.Point(19, 196);
            this.pendentes.Name = "pendentes";
            this.pendentes.Size = new System.Drawing.Size(40, 36);
            this.pendentes.TabIndex = 1;
            this.pendentes.Text = "12";
            // 
            // lbl_totalPendentes
            // 
            this.lbl_totalPendentes.AutoSize = true;
            this.lbl_totalPendentes.BackColor = System.Drawing.Color.Red;
            this.lbl_totalPendentes.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPendentes.ForeColor = System.Drawing.Color.White;
            this.lbl_totalPendentes.Location = new System.Drawing.Point(19, 145);
            this.lbl_totalPendentes.Name = "lbl_totalPendentes";
            this.lbl_totalPendentes.Size = new System.Drawing.Size(157, 36);
            this.lbl_totalPendentes.TabIndex = 0;
            this.lbl_totalPendentes.Text = "Pendentes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.chamadosAtendidos);
            this.panel2.Controls.Add(this.lbl_chamadosAtendidos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(392, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 260);
            this.panel2.TabIndex = 1;
            // 
            // chamadosAtendidos
            // 
            this.chamadosAtendidos.AutoSize = true;
            this.chamadosAtendidos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chamadosAtendidos.ForeColor = System.Drawing.Color.White;
            this.chamadosAtendidos.Location = new System.Drawing.Point(19, 196);
            this.chamadosAtendidos.Name = "chamadosAtendidos";
            this.chamadosAtendidos.Size = new System.Drawing.Size(40, 36);
            this.chamadosAtendidos.TabIndex = 1;
            this.chamadosAtendidos.Text = "12";
            // 
            // lbl_chamadosAtendidos
            // 
            this.lbl_chamadosAtendidos.AutoSize = true;
            this.lbl_chamadosAtendidos.BackColor = System.Drawing.Color.Red;
            this.lbl_chamadosAtendidos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chamadosAtendidos.ForeColor = System.Drawing.Color.White;
            this.lbl_chamadosAtendidos.Location = new System.Drawing.Point(19, 145);
            this.lbl_chamadosAtendidos.Name = "lbl_chamadosAtendidos";
            this.lbl_chamadosAtendidos.Size = new System.Drawing.Size(296, 36);
            this.lbl_chamadosAtendidos.TabIndex = 0;
            this.lbl_chamadosAtendidos.Text = "Chamados atendidos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.totalChamados);
            this.panel1.Controls.Add(this.lbl_totalChamados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 260);
            this.panel1.TabIndex = 0;
            // 
            // totalChamados
            // 
            this.totalChamados.AutoSize = true;
            this.totalChamados.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChamados.ForeColor = System.Drawing.Color.White;
            this.totalChamados.Location = new System.Drawing.Point(19, 196);
            this.totalChamados.Name = "totalChamados";
            this.totalChamados.Size = new System.Drawing.Size(40, 36);
            this.totalChamados.TabIndex = 1;
            this.totalChamados.Text = "12";
            // 
            // lbl_totalChamados
            // 
            this.lbl_totalChamados.AutoSize = true;
            this.lbl_totalChamados.BackColor = System.Drawing.Color.Red;
            this.lbl_totalChamados.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalChamados.ForeColor = System.Drawing.Color.White;
            this.lbl_totalChamados.Location = new System.Drawing.Point(19, 145);
            this.lbl_totalChamados.Name = "lbl_totalChamados";
            this.lbl_totalChamados.Size = new System.Drawing.Size(264, 36);
            this.lbl_totalChamados.TabIndex = 0;
            this.lbl_totalChamados.Text = "Total de chamados";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pendentes;
        private System.Windows.Forms.Label lbl_totalPendentes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label chamadosAtendidos;
        private System.Windows.Forms.Label lbl_chamadosAtendidos;
        private System.Windows.Forms.Label totalChamados;
        private System.Windows.Forms.Label lbl_totalChamados;
    }
}