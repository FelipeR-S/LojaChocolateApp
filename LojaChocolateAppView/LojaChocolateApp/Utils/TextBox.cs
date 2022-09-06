using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaChocolateApp.Utils
{
    public class TextBoxControls : Form
    {
        /// <summary>
        /// Apaga conteudo de todas as textbox e combobox inseridas quando invocado
        /// </summary>
        public void ApagaBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox && c.BackColor == Color.FromArgb(235, 167, 101))
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ApagaBox(c);
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }
        /// <summary>
        /// Permite apenas numeros na textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            TextBox t = (TextBox)sender;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^[0-9]*$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (!Char.IsDigit(c) && c != 8)
                e.Handled = true;
        }
        /// <summary>
        /// Permite apenas Alfanuméricos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnlyNumbersAndChars(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsLetterOrDigit(c) && c != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Permite apenas letras e "-" no textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnlyChars(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            TextBox t = (TextBox)sender;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^[A-Za-zÀ-ú\s?]*$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (!Char.IsLetter(c) && c != 8 && c != 32)
                e.Handled = true;
        }
        /// <summary>
        /// Alterar formato de caracteres do CPF para inserção correta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BoxCPF(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            var posicao = t.SelectionStart;
            char c = e.KeyChar;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^[0-9]{3}(\.?)[0-9]{3}(\.?)[0-9]{3}(\-?)[0-9]{2}$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (!Char.IsDigit(c) && c != 8)
                e.Handled = true;
            else if (c == 8) posicao--;
            else if (posicao == 3 && c != 8 || posicao == 7 && c != 8)
            {
                t.Text = t.Text.Insert(posicao, ".");
                t.SelectionStart = posicao + 1;
            }
            else if (posicao == 11 && c != 8)
            {
                t.Text = t.Text.Insert(posicao, "-");
                t.SelectionStart = posicao + 1;
            }
        }
        /// <summary>
        /// Formata o box para o celular contato padrao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BoxContato(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            var posicao = t.SelectionStart;
            char c = e.KeyChar;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^((\(?[0-9]{2}\)?\s?)?)+([0-9]{4,5})+(\-?\s?)+([0-9]{4})$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (!Char.IsDigit(c) && c != 8 || ModifierKeys.HasFlag(Keys.Control))
                e.Handled = true;
            else if (c == 8) posicao--;
            else if (posicao == 0 && c != 8)
            {
                t.Text = t.Text.Insert(posicao, "(");
                t.SelectionStart = posicao + 1;
            }
            else if (posicao == 3 && c != 8)
            {
                t.Text = t.Text.Insert(posicao, ")");
                t.SelectionStart = posicao + 1;
            }
            else if (posicao == 9 && c != 8)
            {
                t.Text = t.Text.Insert(posicao, "-");
                t.SelectionStart = posicao + 1;
            }
        }
        /// <summary>
        /// Formata o box para o valor em dinheiro padrão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BoxValor(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (e.KeyChar == 3)
                t.Copy();
            if (e.KeyChar == 22)
            {
                t.Paste();
                if (!Regex.IsMatch(t.Text, @"^([0-9]{1,2}\.?)?([0-9]{1,3}\,?)?[0-9]{1,2}$"))
                {
                    MessageBox.Show("Formato incorreto.");
                    t.Text = string.Empty;
                }
            }
            if (e.KeyChar == 24)
                t.Cut();
            if (e.KeyChar == 26)
                t.Undo();
            if (e.KeyChar == 1)
                t.SelectAll();
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                if (t.Text.Length < 9 || e.KeyChar.Equals((char)Keys.Back))
                {
                    string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                    if (w == string.Empty) w = "00";

                    if (e.KeyChar.Equals((char)Keys.Back))
                        w = w.Substring(0, w.Length - 1);
                    else
                        w += e.KeyChar;
                    t.Text = string.Format("{0:#,##0.00}", double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                }
                else e.Handled = true;
            }
            e.Handled = true;
        }
        /// <summary>
        /// Dialogo para selecionar arquivo para cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenFile(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            tb.Text = file.FileName;
            tb.Text = file.FileName;
        }
        /// <summary>
        /// Recebe arquivo CSV e verifica se está no padrão correto
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="caso"></param>
        /// <returns>Retorna bool para correto ou incorreto</returns>
        public bool CSVIsMatch(string linha, string caso)
        {
            var patternID = @"^\s*[0-9]{1,3}\s*$";
            var patternData = @"^\s*[0-9]{1,2}[/][0-9]{1,2}[/][0-9]{4}\s*$";
            var patternValor = @"^\s*[0-9]{1,5}[,][0-9]{2}\s*$";
            var patternTxt = @"^[A-Za-zÀ-ú\s]{1,150}$";
            switch (caso)
            {
                case "funcionario":
                    var splitFuncionario = linha.Split(';');
                    var patternCPF = @"^[\s]?[0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[\-]?[0-9]{2}[\s]?$";
                    var patternContato = @"^[\s]?[\(]?[0-9]{2}[\)]?[0-9]{4,5}[\-]?[0-9]{4}[\s]?$";
                    if (!Regex.IsMatch(splitFuncionario[0], patternID) ||
                        !Regex.IsMatch(splitFuncionario[1], patternTxt) ||
                        !Regex.IsMatch(splitFuncionario[2], patternCPF) ||
                        !Regex.IsMatch(splitFuncionario[3], patternContato) ||
                        !Regex.IsMatch(splitFuncionario[4], patternValor) ||
                        !Regex.IsMatch(splitFuncionario[5], patternTxt) ||
                        !Regex.IsMatch(splitFuncionario[6], patternData))
                    {
                        return false;
                    }
                    else
                        return true;
                case "produto":
                    var splitProduto = linha.Split(';');
                    var patternCodProd = @"^[\s]?[0-9]{12}[\s]?$";
                    var patternEstoque = @"^[\s]?[0-9]{1,4}[\s]?$";
                    var patternTxtProd = @"^.{1,150}$";

                    if (!Regex.IsMatch(splitProduto[0], patternCodProd) ||
                        !Regex.IsMatch(splitProduto[1], patternTxtProd) ||
                        !Regex.IsMatch(splitProduto[2], patternID) ||
                        !Regex.IsMatch(splitProduto[3], patternValor) ||
                        !Regex.IsMatch(splitProduto[4], patternTxt) ||
                        !Regex.IsMatch(splitProduto[5], patternEstoque))
                    {
                        return false;
                    }
                    return true;
                case "vendas":
                    var splitVenda = linha.Split(';');
                    var patternProduto = @"^[\s]?[0-9]{1,3}[|][0-9]{12}[\s]?$";
                    var contador = 1;
                    var listaIdProduto = new List<string>();
                    var correto = false;
                    if (!Regex.IsMatch(splitVenda[0], patternID))
                    {
                        return correto;
                    }
                    else
                    {
                        while (contador < splitVenda.Length - 1)
                        {
                            var vendaProduto = splitVenda[contador].Split('|');
                            if (!Regex.IsMatch(splitVenda[contador], patternProduto))
                            {
                                correto = false;
                                break;
                            }
                            var idProduto = vendaProduto[1];
                            if (listaIdProduto.Contains(idProduto))
                            {
                                correto = false;
                                break;
                            }
                            else
                            {
                                correto = true;
                                listaIdProduto.Add(idProduto);
                                contador++;
                            }
                        }
                        if (correto)
                        {
                            if (!Regex.IsMatch(splitVenda[splitVenda.Length - 1], patternData))
                            {
                                correto = false;
                                return correto;
                            }
                            else
                                return correto;
                        }
                        return correto;
                    }
                default:
                    return false;
            }
        }
        public void CopiarSelecionar(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (e.KeyData == Keys.V && e.Modifiers == Keys.Control)
            {
                if (sender is TextBox)
                    t.Paste();
            }
            if (e.KeyData == Keys.C && e.Modifiers == Keys.Control)
            {
                if (sender is TextBox)
                    t.Copy();
            }
            if (e.KeyData == Keys.A && e.Modifiers == Keys.Control)
            {
                if (sender is TextBox)
                   t.SelectAll();
            }
            if (e.KeyData == Keys.X && e.Modifiers == Keys.Control)
            {
                if (sender is TextBox)
                    t.Cut();
            }
            if (e.KeyData == Keys.Z && e.Modifiers == Keys.Control)
            {
                if (sender is TextBox)
                    t.Undo();
            }
        }
        public Image OpenFileImage(object sender, EventArgs e)
        {
            Image imagem = null;
            OpenFileDialog arquivo = new OpenFileDialog();
            //Filtro
            arquivo.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(arquivo.FileName);
                var fileSize = file.Length;
                if (fileSize > 800000)
                    MessageBox.Show("O arquivo deve ter tamanho máximo de 800kb.");
                else
                {
                    imagem = Image.FromFile(arquivo.FileName);
                    return imagem;
                }
            }
            return imagem;
        }
    }
}
