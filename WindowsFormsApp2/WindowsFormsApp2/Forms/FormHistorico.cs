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
    public partial class FormHistorico : Form
    {
        string connectionString = "datasource=localhost;username=root;password=;database=projetods4";
        public FormHistorico()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarChamadosFinalizados();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarChamadosFinalizados()
        {
            try
            {
                dataGridView1.Rows.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM chamadosfinalizados";
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
    }
}
