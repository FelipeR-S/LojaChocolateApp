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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCadastros = new System.Windows.Forms.FlowLayoutPanel();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelCadastros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 560);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanelCadastros
            // 
            this.flowLayoutPanelCadastros.AutoScroll = true;
            this.flowLayoutPanelCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCadastros.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanelCadastros.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelCadastros.Name = "flowLayoutPanelCadastros";
            this.flowLayoutPanelCadastros.Padding = new System.Windows.Forms.Padding(5, 40, 5, 40);
            this.flowLayoutPanelCadastros.Size = new System.Drawing.Size(715, 490);
            this.flowLayoutPanelCadastros.TabIndex = 0;
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.White;
            this.textTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textTitulo.Location = new System.Drawing.Point(40, 30);
            this.textTitulo.Margin = new System.Windows.Forms.Padding(40, 30, 3, 0);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.ReadOnly = true;
            this.textTitulo.Size = new System.Drawing.Size(672, 40);
            this.textTitulo.TabIndex = 99;
            this.textTitulo.TabStop = false;
            this.textTitulo.Text = "Verifique a Permissão para um Novo Usuário!";
            // 
            // ControleDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ControleDeAcesso";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.ControleDeAcesso_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCadastros;
    }
}
