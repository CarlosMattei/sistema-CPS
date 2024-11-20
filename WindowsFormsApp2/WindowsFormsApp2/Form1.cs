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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        /*CONEXÂO COM BANCO SQL:
         * 
         * try{
        string origem_data = "datasouce=localhost;username=root;password=;database=projetods4"
        Conexao = new MySqlConnection(data_source);

        string sql = "insert into chamados (id, data,local_solicitacao, maquina_afetada,descricao,nivel_chamado, responsavel_solicitacao)" + 
        " values"+
        "()"

        MySqlCommand comando = newMySqlCommand(sql, Conexao)

        Conexao.Open();

        comando.ExecuteReader();

        MessageBox.Show("Beleza")
        } catch (Exception ex)
        {
        MessageBox.Show(ex.Message);
        }finally
        {
        Conexao.Close();
        }

        */

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


        private void panelDesktopView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConsulta(), sender);
        }
    }
}
