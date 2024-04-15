﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UI
{
    public partial class formRelatorios : Form
    {
        string connectionString = DadosDaConexao.StringDeConexao;
        private DALConexao conexao;

        DALRelatorios dalRelatorios;
        public formRelatorios()
        {
            InitializeComponent();
        }

        private void formRelatorios_Load(object sender, EventArgs e)
        {
            this.menuBotoes(1);
        }

        public void menuBotoes(int op)
        {
            panelDados.Enabled = false;
            btnInserir.Enabled = false;
            btnGerarRelatorio.Enabled = false;
            btnLimparTela.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
            }

            if (op == 2)
            {
                panelDados.Enabled = true;
                btnGerarRelatorio.Enabled = true;
                btnLimparTela.Enabled = true;
            }

            if (op == 3)
            {
                btnLimparTela.Enabled = true;
            }
        }

        public void LimpaTela()
        {
            cmbTipoRelatorio.SelectedIndex = -1;
            dtgvRelatorios.DataSource = null;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.menuBotoes(2);
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            this.menuBotoes(1);
            this.LimpaTela();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string nomeTabela = "ControleDeEstoque";
            this.conexao = new DALConexao(connectionString);
            this.dalRelatorios = new DALRelatorios(conexao);
            string tipoRelatorio = cmbTipoRelatorio.Text.Normalize().ToUpper();

            DateTime dataInicial = dtpDataInicial.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;

            switch (tipoRelatorio)
            {
                case "RELATÓRIO DE CLIENTES":
                    RelatorioCliente(nomeTabela);
                    break;
                case "RELATÓRIO DE COMPRA":
                    RelatorioCompra(nomeTabela, dataInicial, dataFinal);
                    break;
                case "RELATÓRIO DE VENDA":
                    RelatorioVenda(nomeTabela, dataInicial, dataFinal);
                    break;
                case "RELATÓRIO DE PRODUTO":
                    RelatorioProduto(nomeTabela);
                    break;
                default:
                    MessageBox.Show("Tipo de relatório inválido.");
                    break;
            }
        }

        private void RelatorioCliente(string cliente)
        {
            List<ClienteRelatorio> dadosRelatorio = dalRelatorios.ObterLinhasCliente(cliente);

            if (dadosRelatorio != null)
            {
                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }

        private void RelatorioCompra(string compra, DateTime dataInicial, DateTime dataFinal)
        {
            List<CompraRelatorio> dadosRelatorio = dalRelatorios.ObterLinhasCompra(compra, dataInicial, dataFinal);

            if (dadosRelatorio != null)
            {
                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }
        private void RelatorioVenda(string venda, DateTime dataInicial, DateTime dataFinal)
        {
            List<VendaRelatorio> dadosRelatorio = dalRelatorios.ObterLinhasVenda(venda, dataInicial, dataFinal);

            if (dadosRelatorio != null)
            {
                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }
        private void RelatorioProduto(string produto)
        {
            List<ProdutoRelatorio> dadosRelatorio = dalRelatorios.ObterLinhasProduto(produto);

            if (dadosRelatorio != null)
            {
                dtgvRelatorios.DataSource = dadosRelatorio;
                dtgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Erro ao obter nomes das colunas.");
            }
        }

        private void dtgvRelatorios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<string> colunasParaFormatar = new List<string> { "ValorPago", "ValorVenda", "NumeroDeCompras", "TotalDeCompras", "NumeroDeVendas",
            "TotalDeVendas"};

            if (colunasParaFormatar.Contains(dtgvRelatorios.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double valor))
                {
                    e.Value = valor.ToString("C2");
                }
            }


        }
    }
}