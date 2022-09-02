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
            this.flowLayoutPanelCadastros = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCadastros
            // 
            this.flowLayoutPanelCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCadastros.Location = new System.Drawing.Point(0, 67);
            this.flowLayoutPanelCadastros.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelCadastros.Name = "flowLayoutPanelCadastros";
            this.flowLayoutPanelCadastros.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.flowLayoutPanelCadastros.Size = new System.Drawing.Size(715, 493);
            this.flowLayoutPanelCadastros.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 18, 0, 0);
            this.panel1.Size = new System.Drawing.Size(715, 67);
            this.panel1.TabIndex = 0;
            // 
            // textTitulo
            // 
            this.textTitulo.BackColor = System.Drawing.Color.White;
            this.textTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.textTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textTitulo.Location = new System.Drawing.Point(30, 18);
            this.textTitulo.Multiline = true;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.ReadOnly = true;
            this.textTitulo.Size = new System.Drawing.Size(685, 33);
            this.textTitulo.TabIndex = 21;
            this.textTitulo.Text = "Verifique a Permissão para um Novo Usuário!";
            // 
            // ControleDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanelCadastros);
            this.Controls.Add(this.panel1);
            this.Name = "ControleDeAcesso";
            this.Size = new System.Drawing.Size(715, 560);
            this.Load += new System.EventHandler(this.ControleDeAcesso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCadastros;
        private System.Windows.Forms.TextBox textTitulo;
    }
}
