using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            btnColumn.DefaultCellStyle.ForeColor = Color.White;
            btnColumn.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(btnColumn);

            ConfigurarAparenciaDataGridView();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void ConfigurarAparenciaDataGridView()
        {
            dataGridView1.Columns["Descricao"].Width = 100;
            dataGridView1.Columns["nomeResponsavel"].Width = 50;
            dataGridView1.Columns["Local"].Width = 80;
            dataGridView1.Columns["Nivel"].Width = 50;
            dataGridView1.Columns["Acao"].Width = 60;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 15, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.MinimumHeight = 50;

            dataGridView1.Columns["Descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 50;
                }
            };
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Acao"].Index && e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string nomeResponsavel = row.Cells["nomeResponsavel"].Value.ToString();
                string local = row.Cells["Local"].Value.ToString();
                string nivel = row.Cells["Nivel"].Value.ToString();
                string descricao = row.Cells["Descricao"].Value.ToString();

                MySqlConnection Conexao = null;
                try
                {
                    // Primeiro, inserir na tabela chamadosfinalizados
                    Conexao = new MySqlConnection(connectionString);
                    string sqlInsert = "INSERT INTO chamadosfinalizados (nomeResponsavel, local, nivel, descricao) VALUES (@nomeResponsavel, @local, @nivel, @descricao)";
                    MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, Conexao);

                    cmdInsert.Parameters.AddWithValue("@nomeResponsavel", nomeResponsavel);
                    cmdInsert.Parameters.AddWithValue("@local", local);
                    cmdInsert.Parameters.AddWithValue("@nivel", nivel);
                    cmdInsert.Parameters.AddWithValue("@descricao", descricao);

                    Conexao.Open();
                    cmdInsert.ExecuteNonQuery();

                    // Depois, deletar da tabela chamados
                    string sqlDelete = "DELETE FROM chamados WHERE nomeResponsavel = @nomeResponsavel AND local = @local AND nivel = @nivel AND descricao = @descricao";
                    MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, Conexao);

                    cmdDelete.Parameters.AddWithValue("@nomeResponsavel", nomeResponsavel);
                    cmdDelete.Parameters.AddWithValue("@local", local);
                    cmdDelete.Parameters.AddWithValue("@nivel", nivel);
                    cmdDelete.Parameters.AddWithValue("@descricao", descricao);

                    cmdDelete.ExecuteNonQuery();

                    // Remover a linha do DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Chamado finalizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar o chamado: " + ex.Message);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                    {
                        Conexao.Close();
                    }
                }
            }
        }

        private void CarregarChamados()
        {
            MySqlConnection Conexao = null;
            try
            {
                dataGridView1.Rows.Clear();
                Conexao = new MySqlConnection(connectionString);
                string sql = "SELECT * FROM chamados";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
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

                }

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }
    }
}