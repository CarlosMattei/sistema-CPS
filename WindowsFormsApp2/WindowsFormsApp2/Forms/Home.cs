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
    public partial class Home : Form
    {
        /*
         * CONEXAO FORMS DETALHADO. O MENOR EU ME VIRO DPS
         * MySqlConnection Conexao = null;

            try
            {
                string origem_data = "datasource=localhost;username=root;password=;database=projetods4";
                Conexao = new MySqlConnection(origem_data);

                string sql = "SELECT * FROM chamados";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                      string[] row=
                      {
                         reader.GetString(0)
                         reader.GetString(1)
                         reader.GetString(2)
                         reader.GetString(3)
                      };
                }

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
   
         */
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

