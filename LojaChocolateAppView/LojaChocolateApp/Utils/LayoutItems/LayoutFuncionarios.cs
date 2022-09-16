using LojaChocolateApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.LayoutItems
{
    public partial class LayoutFuncionarios : UserControl
    {
        private TextBoxControls _controle = new TextBoxControls();
        #region Propriedades
        private string _nome;
        private string _id;
        private string _cargo;
        private string _cpf;
        private string _contato;
        private string _salario;
        private string _vendas;
        private string _dataCadastro;
        private Image _imagem;
        private Color _backGroundColor;

        [Category("Custom Props")]
        public string Nome { get { return _nome; } set { _nome = value; textNomeLayout.Text = value; } }
        [Category("Custom Props")]
        public string Id { get { return _id; } set { _id = value; textIdLayout.Text = value; } }
        [Category("Custom Props")]
        public string Cargo { get { return _cargo; } set { _cargo = value; textCargoLayout.Text = value; } }
        [Category("Custom Props")]
        public string Cpf { get { return _cpf; } set { _cpf = value; textCpfLayout.Text = value; } }
        [Category("Custom Props")]
        public string Contato { get { return _contato; } set { _contato = value; textContatoLayout.Text = value; } }
        [Category("Custom Props")]
        public string Salario { get { return _salario; } set { _salario = value; textSalarioLayout.Text = value; } }
        [Category("Custom Props")]
        public string Vendas { get { return _vendas; } set { _vendas = value; textVendasLayout.Text = value; } }
        [Category("Custom Props")]
        public string DataCadastro { get { return _dataCadastro; } set { _dataCadastro = value; textDataCadastroLayout.Text = value; } }
        [Category("Custom Props")]
        public Image Imagem { get { return _imagem; } set { _imagem = value; pictureLayout.Image = value; } }
        [Category("Custom Props")]
        public Color BackGroundColor { get { return _backGroundColor; } set { _backGroundColor = value; BackColorLayout.BackColor = value; } }
        #endregion
        public LayoutFuncionarios()
        {
            InitializeComponent();
        }
        private void btnMaisDetalhes_Click(object sender, EventArgs e)
        {
            this.Height = 180;
            panelExibeDetalhes.Visible = true;
            btnMenosDetalhes.Visible = true;
        }
        private void btnMenosDetalhes_Click(object sender, EventArgs e)
        {
            this.Height = 80;
            panelExibeDetalhes.Visible = false;
            btnMenosDetalhes.Visible = false;
        }
        public void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            _controle.CopiarSelecionar(sender, e);
        }
        /// <summary>
        /// Abre dialogo para inserir imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddImagem_Click(object sender, EventArgs e)
        {
            var imagem = _controle.OpenFileImage(sender, e);
            if (imagem != null)
            {
                SQLServerConn server = new SQLServerConn();
                var imgByte = server.ConvertImageToByte(imagem);
                server.InsereImagemSql(imgByte, "Funcionario", this.Id);
                this.Imagem = imagem;
                MessageBox.Show("Imagem Cadastrada!");
            }
        }
    }
}
