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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2.Forms
{
    public partial class FormChamados : Form
    {
        string connectionString = "datasource=localhost;username=root;password=;database=projetods4";
        public FormChamados()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarChamados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormChamados_Load(object sender, EventArgs e)
        {

        }

        private void CarregarChamados()
        {
            try
            {
                dataGridView1.Rows.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM chamados";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int rowIndex = dataGridView1.Rows.Add(
                            row["nomeResponsavel"].ToString(),
                            row["local"].ToString(),
                            row["nivel"].ToString(),
                            row["descricao"].ToString(),
                            "Finalizar"
                        );

                        // Verifica o valor da coluna "Nivel" e define a cor
                        if (row["nivel"].ToString() == "Médio")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Orange;
                        }
                        // Você pode adicionar mais condições para outros níveis
                        else if (row["nivel"].ToString() == "Alto")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Red;
                        }
                        else if (row["nivel"].ToString() == "Baixo")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Green;
                        }
                    }

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }


        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("nomeResponsavel", "Responsável");
            dataGridView1.Columns.Add("Local", "Local");
            dataGridView1.Columns.Add("Nivel", "Nível");
            dataGridView1.Columns.Add("Descricao", "Descrição");

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Acao";
            btnColumn.HeaderText = "Ação";
            btnColumn.Text = "Finalizar";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.DefaultCellStyle.BackColor = Color.Green; 
            btnColumn.DefaultCellStyle.ForeColor = Color.WhiteSmoke; 
            btnColumn.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(btnColumn);

            dataGridView1.Columns["Descricao"].Width = 500;
            dataGridView1.Columns["nomeResponsavel"].Width = 50;
            dataGridView1.Columns["Local"].Width = 80;
            dataGridView1.Columns["Nivel"].Width = 50;
            dataGridView1.Columns["Acao"].Width = 50;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a coluna clicada é a do botão "Finalizar"
            if (e.ColumnIndex == dataGridView1.Columns["Acao"].Index && e.RowIndex >= 0)
            {
                // Recupera o ID do chamado armazenado na propriedade Tag da linha
                string idEscolhido = dataGridView1.Rows[e.RowIndex].Tag?.ToString();

                if (string.IsNullOrEmpty(idEscolhido))
                {
                    MessageBox.Show("ID do chamado não encontrado.");
                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Cria as consultas SQL
                        string query1 = "INSERT INTO chamadosfinalizados (nomeResponsavel, local, nivel, descricao) SELECT nomeResponsavel, local, nivel, descricao FROM chamados WHERE id = @Id";
                        string query2 = "DELETE FROM chamados WHERE id = @Id";

                        // Executa a primeira consulta
                        using (MySqlCommand command1 = new MySqlCommand(query1, connection))
                        {
                            command1.Parameters.AddWithValue("@Id", idEscolhido);
                            command1.ExecuteNonQuery();
                        }

                        // Executa a segunda consulta
                        using (MySqlCommand command2 = new MySqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@Id", idEscolhido);
                            command2.ExecuteNonQuery();
                        }
                    }

                    // Remove a linha do DataGridView e exibe uma mensagem de sucesso
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Chamado finalizado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar o chamado: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
