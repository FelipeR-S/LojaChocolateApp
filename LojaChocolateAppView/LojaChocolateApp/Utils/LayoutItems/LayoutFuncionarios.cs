using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils.LayoutItems
{
    public partial class LayoutFuncionarios : UserControl
    {
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
            ReadOnly();
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
        private void ReadOnly()
        {
            textNomeLayout.ReadOnly = true;
            textIdLayout.ReadOnly = true;
            textCargoLayout.ReadOnly = true;
            textCargoLayout.ReadOnly = true;
            textCpfLayout.ReadOnly = true;
            textContatoLayout.ReadOnly = true;
            textSalarioLayout.ReadOnly = true;
            textVendasLayout.ReadOnly = true;
            textDataCadastroLayout.ReadOnly = true;
        }
    }
}
