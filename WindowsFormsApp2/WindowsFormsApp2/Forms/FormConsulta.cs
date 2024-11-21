using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2.Forms
{
    public partial class FormConsulta : Form
    {
        MySqlConnection Conexao;
        string origem_data = "datasource=localhost;username=root;password=;database=projetods4";
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string buscaProfessor = "'%" + textBox1.Text + "%'";
                string buscaLocal = "'%" + comboBox1.Text + "%'";
                string buscaGravidade = "'%" + comboBox2.Text + "%'";

                
                MySqlConnection conexao = new MySqlConnection(origem_data);

                
                string sql = "SELECT * " +
                             "FROM chamados " +
                             "WHERE nomeResponsavel LIKE " + buscaProfessor +
                             " OR local LIKE " + buscaLocal +
                             " OR nivel LIKE " + buscaGravidade;

               
                conexao.Open();

                
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                MessageBox.Show("Dados carregados com sucesso!");
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
