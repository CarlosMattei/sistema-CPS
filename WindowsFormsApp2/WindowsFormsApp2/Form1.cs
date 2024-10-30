using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopView.Controls.Add(childForm);
            this.panelDesktopView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChamados(), sender);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHistorico(), sender);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormSair formSair = new FormSair();

            formSair.ShowDialog();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }
    }
}
