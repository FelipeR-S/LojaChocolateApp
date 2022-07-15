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
    public partial class LayoutProdutos : UserControl
    {
        #region Propriedades
        private string _nome;
        private string _id;
        private string _peso;
        private string _valor;
        private string _tipo;
        private string _estoque;
        private string _vendas;
        private Image _imagem;
        private Color _backGroundColor;

        [Category("Custom Props")]
        public string Nome { get { return _nome; } set { _nome = value; textNomeLayout.Text = value; } }
        [Category("Custom Props")]
        public string Id { get { return _id; } set { _id = value; textIdLayout.Text = value; } }
        [Category("Custom Props")]
        public string Peso { get { return _peso; } set { _peso = value; textPesoLayout.Text = value; } }
        [Category("Custom Props")]
        public string Valor { get { return _valor; } set { _valor = value; textValorLayout.Text = value; } }
        [Category("Custom Props")]
        public string Tipo { get { return _tipo; } set { _tipo = value; textTipoLayout.Text = value; } }
        [Category("Custom Props")]
        public string Estoque { get { return _estoque; } set { _estoque = value; textEstoqueLayout.Text = value; } }
        [Category("Custom Props")]
        public string Vendas { get { return _vendas; } set { _vendas = value; textVendasLayout.Text = value; } }
        [Category("Custom Props")]
        public Image Imagem { get { return _imagem; } set { _imagem = value; pictureLayout.Image = value; } }
        [Category("Custom Props")]
        public Color BackGroundColor { get { return _backGroundColor; } set { _backGroundColor = value; BackColorLayout.BackColor = value; } }
        #endregion
        public LayoutProdutos()
        {
            InitializeComponent();
            ReadOnly();
        }
        private void ReadOnly()
        {
            textNomeLayout.ReadOnly = true;
            textIdLayout.ReadOnly = true;
            textPesoLayout.ReadOnly = true;
            textValorLayout.ReadOnly = true;
            textTipoLayout.ReadOnly = true;
            textEstoqueLayout.ReadOnly = true;
            textVendasLayout.ReadOnly = true;
        }
    }
}
