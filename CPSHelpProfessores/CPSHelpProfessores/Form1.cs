using CPSHelpProfessores.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSHelpProfessores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void problemaNotebook_Click(object sender, EventArgs e)
        {
            
            Principal.Controls.Clear();

            FormNome nomeForm = new FormNome(this);
            nomeForm.TopLevel = false;
            nomeForm.FormBorderStyle = FormBorderStyle.None;
            nomeForm.Dock = DockStyle.Fill;

            Principal.Controls.Add(nomeForm);
            nomeForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void problemaEquipamento_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();

            FormNome nomeForm = new FormNome(this);
            nomeForm.TopLevel = false;
            nomeForm.FormBorderStyle = FormBorderStyle.None;
            nomeForm.Dock = DockStyle.Fill;

            Principal.Controls.Add(nomeForm);
            nomeForm.Show();
        }

        private void problemaEletrodomestico_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();

            FormNome nomeForm = new FormNome(this);
            nomeForm.TopLevel = false;
            nomeForm.FormBorderStyle = FormBorderStyle.None;
            nomeForm.Dock = DockStyle.Fill;

            Principal.Controls.Add(nomeForm);
            nomeForm.Show();
        }

        private void problemaOutro_Click(object sender, EventArgs e)
        {
            Principal.Controls.Clear();

            FormNome nomeForm = new FormNome(this);
            nomeForm.TopLevel = false;
            nomeForm.FormBorderStyle = FormBorderStyle.None;
            nomeForm.Dock = DockStyle.Fill;

            Principal.Controls.Add(nomeForm);
            nomeForm.Show();
        }
    }
}
