using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class FormSair : Form
    {
        public FormSair()
        {
            InitializeComponent();
        }

        private void btn_Cancelar(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_SairApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
