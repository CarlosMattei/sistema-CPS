﻿using System;
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
        string connectionString = "datasource=localhost;username=root;password=;database=projetods4";

        public Home()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarChamados();
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

            dataGridView1.Columns["Descricao"].Width = 100;
            dataGridView1.Columns["nomeResponsavel"].Width = 50;
            dataGridView1.Columns["Local"].Width = 80;
            dataGridView1.Columns["Nivel"].Width = 50;
            dataGridView1.Columns["Acao"].Width = 60;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 15, FontStyle.Bold);

            // Modificações para altura das linhas
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.MinimumHeight = 50;

            // Aplicar altura em todas as linhas existentes
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 50;
            }

            // Adicionar evento para manter altura em novas linhas
            dataGridView1.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 50;
                }
            };

            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}

