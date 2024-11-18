using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CPSHelpProfessores.Forms
{

    public partial class FormNome : Form
    {
        private Form1 _mainForm;
        public FormNome(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Armazena a referência do Form1
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSuccess_click(object sender, EventArgs e)
        {
            

            // Limpa o painel do Form1
            _mainForm.Principal.Controls.Clear();
            Form1 formInicial = new Form1(); // Supondo que você tenha um FormInicial
            formInicial.TopLevel = false;
            formInicial.FormBorderStyle = FormBorderStyle.None;
            formInicial.Dock = DockStyle.Fill;
            _mainForm.Principal.Controls.Add(formInicial);
            formInicial.Show();

            SucessForm success = new SucessForm();
            success.Show();

            MySqlConnection Conexao = null;

            try
            {
                string origem_data = "datasource=localhost;username=root;password=;database=projetods4";
                Conexao = new MySqlConnection(origem_data);

                string sql = "INSERT INTO chamados (nomeResponsavel, local, nivel, descricao) VALUES (@nomeResponsavel, @local, @nivel, @descricao)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                // Adicionando parâmetros à consulta
                comando.Parameters.AddWithValue("@nomeResponsavel", textBox1.Text);
                comando.Parameters.AddWithValue("@local", comboBox1.Text);
                comando.Parameters.AddWithValue("@nivel", comboBox2.Text);
                comando.Parameters.AddWithValue("@descricao", richTextBox1.Text);

                Conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }



            // Se você não tem um formulário específico para mostrar, você pode simplesmente deixar o painel vazio.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
