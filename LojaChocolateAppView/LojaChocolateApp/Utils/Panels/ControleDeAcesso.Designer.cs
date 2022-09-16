namespace LojaChocolateApp.Utils.Panels
{
    partial class ControleDeAcesso
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCadastros = new System.Windows.Forms.FlowLayoutPanel();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.panel1.Size = new System.Drawing.Size(715, 560);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelCadastros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.423077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.57692F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 520);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanelCadastros
            // 
            this.flowLayoutPanelCadastros.AutoScroll = true;
            this.flowLayoutPanelCadastros.AutoSize = true;
            this.flowLayoutPanelCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCadastros.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanelCadastros.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelCadastros.Name = "flowLayoutPanelCadastros";
            this.flowLayoutPanelCadastros.Padding = new System.Windows.Forms.Padding(5, 40, 5, 40);
            this.flowLayoutPanelCadastros.Size = new System.Drawing.Size(655, 471);
            this.flowLayoutPanelCadastros.TabIndex = 0;
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.White;
            this.textTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textTitulo.Location = new System.Drawing.Point(0, 0);
            this.textTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.ReadOnly = true;
            this.textTitulo.Size = new System.Drawing.Size(655, 49);
            this.textTitulo.TabIndex = 99;
            this.textTitulo.TabStop = false;
            this.textTitulo.Text = "Verifique a Permissão para um Novo Usuário!";
            this.textTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControleDeAcesso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ControleDeAcesso";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.ControleDeAcesso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCadastros;
        private System.Windows.Forms.TextBox textTitulo;
    }
}
