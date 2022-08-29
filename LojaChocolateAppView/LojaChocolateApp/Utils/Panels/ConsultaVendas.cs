using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.Panels
{
    public partial class ConsultaVendas : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        public ConsultaVendas()
        {
            InitializeComponent();
            dataGridViewVendas.Visible = false;
        }
        /// <summary>
        /// Insere dados na lista de vendas em um DataGrid
        /// </summary>
        private void PopulaListaVendas()
        {
            using (SqlConnection connection = new SqlConnection(SQLServerConn.StrCon))
            {
                var vendaRepo = new VendaRepository();
                var vendas = vendaRepo.GetLista();
                foreach (var venda in vendas)
                {
                    connection.Open();

                    var sqlQuery = $"select [numero], sum([Quantidade]) from Vendas_Itens where numero = '{venda.VendaId}' group by[numero]";
                    var qtd = "";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataReader sr = cmd.ExecuteReader();
                    while (sr.Read())
                    {
                        qtd = sr.GetValue(1).ToString();
                    }
                    dataGridVendasBindingSource
                        .Add(new DataGridVendas() { Numero = venda.VendaId, Descricao = $"Vendido por: {venda.VendedorId} | {venda.VendedorNome} | Qtd de Produtos: {qtd}", Valor = venda.Valor.ToString("F2"), Data = venda.DataVenda.ToShortDateString(), Mais = "+" });
                    connection.Close();
                }
            }
            DesignDataGrid();
            dataGridViewVendas.Visible = true;
        }
        /// <summary>
        /// Exibe ou apaga detalhes do DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dataGridViewVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    var index = -1;
                    //Remove detalhes
                    if (dataGridViewVendas.Rows[e.RowIndex].Cells[4].Value.ToString() == "-" && dataGridViewVendas.Columns[e.ColumnIndex].HeaderText == "+")
                    {
                        index = dataGridViewVendas.Rows[e.RowIndex].Index;
                        var contador = index;
                        while (contador + 1 < dataGridViewVendas.Rows.Count)
                        {
                            if (dataGridViewVendas.Rows[index + 1].Index == dataGridViewVendas.Rows.Count)
                            {
                                break;
                            }
                            else
                            {
                                if (dataGridViewVendas.Rows[index + 1].Cells[0].Value.ToString() == "")
                                {
                                    dataGridViewVendas.Rows.RemoveAt(index + 1);
                                }
                                else
                                    break;
                            }
                        }
                        dataGridViewVendas.Rows[index].Cells[4].Value = "+";
                        goto SkipToEnd;
                    }
                    //Exibe detalhes
                    if (dataGridViewVendas.Rows[e.RowIndex].Cells[4].Value.ToString() == "+" && dataGridViewVendas.Columns[e.ColumnIndex].HeaderText == "+")
                    {
                        var id = dataGridViewVendas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        index = dataGridViewVendas.Rows[e.RowIndex].Index + 1;
                        dataGridViewVendas.Rows[e.RowIndex].Selected = true;

                        // Replace na venda clicada "-"
                        dataGridViewVendas.Rows[index - 1].Cells[4].Value = "-";
                        PopulaDetalhesBtn(id, index);
                        goto SkipToEnd;
                    }
                    else
                    {
                        goto SkipToEnd;
                    }
                }
            SkipToEnd:;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Carrega a lista para exibição do datagrid em tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarregaListaVendas_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewVendas.Rows.Clear();
                PopulaListaVendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Define parametros de colunas e outras informações de design para o DataGridVendas
        /// </summary>
        private void DesignDataGrid()
        {
            dataGridViewVendas.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 10, FontStyle.Bold);
            dataGridViewVendas.ColumnHeadersHeight = 30;
            dataGridViewVendas.Columns[0].Width = 60;
            dataGridViewVendas.Columns[0].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[1].Width = 380;
            dataGridViewVendas.Columns[2].Width = 70;
            dataGridViewVendas.Columns[2].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[3].Width = 100;
            dataGridViewVendas.Columns[3].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVendas.Columns[4].Width = 30;
            dataGridViewVendas.Columns[4].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        /// <summary>
        /// Popula as linhas de detalhes de cada venda
        /// </summary>
        /// <param name="idVenda"> ID da venda</param>
        /// <param name="index">Posição na tabela</param>
        /// <param name="descricao"></param>
        public void PopulaDetalhesBtn(string idVenda, int index)
        {
            var repovendas = new VendaRepository();

            var listaDetalhes = repovendas.GetDetalhesVenda(idVenda);
            foreach (var detalhe in listaDetalhes)
            {
                var detalheProduto = detalhe.Split(';');
                dataGridVendasBindingSource
                    .Insert(index, new DataGridVendas() { Numero = "", Descricao = detalheProduto[0], Valor = detalheProduto[1], Data = "", Mais = "" });
                dataGridViewVendas.Rows[index].DefaultCellStyle.BackColor = Color.FromArgb(235, 167, 101);
            }
        }
    }
}
