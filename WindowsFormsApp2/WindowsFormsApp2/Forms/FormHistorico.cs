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

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();

            // Configurar colunas
            dataGridView1.Columns.Add("nomeResponsavel", "Responsável");
            dataGridView1.Columns.Add("Local", "Local");
            dataGridView1.Columns.Add("Nivel", "Nível");
            dataGridView1.Columns.Add("Descricao", "Descrição");

            // Configurar larguras das colunas
            dataGridView1.Columns["Descricao"].Width = 400;
            dataGridView1.Columns["nomeResponsavel"].Width = 100;
            dataGridView1.Columns["Local"].Width = 100;
            dataGridView1.Columns["Nivel"].Width = 80;

            // Configurar estilos
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.MinimumHeight = 50;

            // Configurar células
            dataGridView1.Columns["Descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurações gerais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
                            row["descricao"].ToString()
                        );

                        // Aplicar cores baseadas no nível
                        if (row["nivel"].ToString() == "Médio")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Orange;
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.ForeColor = Color.White;
                        }
                        else if (row["nivel"].ToString() == "Alto")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Red;
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.ForeColor = Color.White;
                        }
                        else if (row["nivel"].ToString() == "Baixo")
                        {
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.BackColor = Color.Green;
                            dataGridView1.Rows[rowIndex].Cells["Nivel"].Style.ForeColor = Color.White;
                        }

                        // Aplicar estilo alternado nas linhas para melhor visualização
                        if (rowIndex % 2 == 0)
                        {
                            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                        }
                    }

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum chamado finalizado encontrado.", "Histórico",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico de chamados: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Opcional: Adicionar método para atualizar a lista
        public void AtualizarHistorico()
        {
            CarregarChamadosFinalizados();
        }

    }
}