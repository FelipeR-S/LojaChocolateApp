namespace LojaChocolateApp.Utils.Panels
{
    partial class ConsultaProdutos
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
            this.panelExibirProdutos = new System.Windows.Forms.Panel();
            this.flowLayoutLayoutExibeProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tituloExibeProdutos = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBoxOrdemProdutos = new System.Windows.Forms.ComboBox();
            this.btnExibeTodosProdutos = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.btnBuscaIdProduto = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textIdBuscaProdutos = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.panelExibirProdutos.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExibirProdutos
            // 
            this.panelExibirProdutos.AutoScroll = true;
            this.panelExibirProdutos.BackColor = System.Drawing.Color.Transparent;
            this.panelExibirProdutos.Controls.Add(this.flowLayoutLayoutExibeProdutos);
            this.panelExibirProdutos.Controls.Add(this.panel13);
            this.panelExibirProdutos.Controls.Add(this.panel14);
            this.panelExibirProdutos.Controls.Add(this.panel15);
            this.panelExibirProdutos.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExibirProdutos.Location = new System.Drawing.Point(0, 0);
            this.panelExibirProdutos.Name = "panelExibirProdutos";
            this.panelExibirProdutos.Size = new System.Drawing.Size(714, 561);
            this.panelExibirProdutos.TabIndex = 30;
            // 
            // flowLayoutLayoutExibeProdutos
            // 
            this.flowLayoutLayoutExibeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutLayoutExibeProdutos.AutoScroll = true;
            this.flowLayoutLayoutExibeProdutos.Location = new System.Drawing.Point(0, 185);
            this.flowLayoutLayoutExibeProdutos.Name = "flowLayoutLayoutExibeProdutos";
            this.flowLayoutLayoutExibeProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutLayoutExibeProdutos.Size = new System.Drawing.Size(714, 376);
            this.flowLayoutLayoutExibeProdutos.TabIndex = 4;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.tituloExibeProdutos);
            this.panel13.Location = new System.Drawing.Point(0, 150);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(672, 35);
            this.panel13.TabIndex = 30;
            // 
            // tituloExibeProdutos
            // 
            this.tituloExibeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloExibeProdutos.AutoSize = true;
            this.tituloExibeProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloExibeProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.tituloExibeProdutos.Location = new System.Drawing.Point(51, 6);
            this.tituloExibeProdutos.Name = "tituloExibeProdutos";
            this.tituloExibeProdutos.Size = new System.Drawing.Size(64, 25);
            this.tituloExibeProdutos.TabIndex = 15;
            this.tituloExibeProdutos.Text = "Título";
            this.tituloExibeProdutos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label30);
            this.panel14.Controls.Add(this.comboBoxOrdemProdutos);
            this.panel14.Controls.Add(this.btnExibeTodosProdutos);
            this.panel14.Controls.Add(this.label31);
            this.panel14.Controls.Add(this.btnBuscaIdProduto);
            this.panel14.Controls.Add(this.label33);
            this.panel14.Controls.Add(this.textIdBuscaProdutos);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 60);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(714, 90);
            this.panel14.TabIndex = 28;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(348, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 17);
            this.label30.TabIndex = 34;
            this.label30.Text = "Ordenar por:";
            // 
            // comboBoxOrdemProdutos
            // 
            this.comboBoxOrdemProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdemProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdemProdutos.FormattingEnabled = true;
            this.comboBoxOrdemProdutos.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Valor"});
            this.comboBoxOrdemProdutos.Location = new System.Drawing.Point(444, 46);
            this.comboBoxOrdemProdutos.Name = "comboBoxOrdemProdutos";
            this.comboBoxOrdemProdutos.Size = new System.Drawing.Size(110, 25);
            this.comboBoxOrdemProdutos.TabIndex = 3;
            // 
            // btnExibeTodosProdutos
            // 
            this.btnExibeTodosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnExibeTodosProdutos.FlatAppearance.BorderSize = 0;
            this.btnExibeTodosProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibeTodosProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibeTodosProdutos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExibeTodosProdutos.Location = new System.Drawing.Point(578, 45);
            this.btnExibeTodosProdutos.Name = "btnExibeTodosProdutos";
            this.btnExibeTodosProdutos.Size = new System.Drawing.Size(81, 27);
            this.btnExibeTodosProdutos.TabIndex = 2;
            this.btnExibeTodosProdutos.Text = "Todos";
            this.btnExibeTodosProdutos.UseVisualStyleBackColor = false;
            this.btnExibeTodosProdutos.Click += new System.EventHandler(this.btnExibeTodosProdutos_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(109, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(525, 17);
            this.label31.TabIndex = 31;
            this.label31.Text = "Informe o código para exibir detalhes do produto desejado ou clique no botão \"Tod" +
    "os\"";
            // 
            // btnBuscaIdProduto
            // 
            this.btnBuscaIdProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnBuscaIdProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscaIdProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaIdProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaIdProduto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscaIdProduto.Location = new System.Drawing.Point(253, 45);
            this.btnBuscaIdProduto.Name = "btnBuscaIdProduto";
            this.btnBuscaIdProduto.Size = new System.Drawing.Size(81, 27);
            this.btnBuscaIdProduto.TabIndex = 1;
            this.btnBuscaIdProduto.Text = "Buscar";
            this.btnBuscaIdProduto.UseVisualStyleBackColor = false;
            this.btnBuscaIdProduto.Click += new System.EventHandler(this.btnBuscaIdProduto_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(52, 50);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(52, 17);
            this.label33.TabIndex = 29;
            this.label33.Text = "Código";
            // 
            // textIdBuscaProdutos
            // 
            this.textIdBuscaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textIdBuscaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIdBuscaProdutos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdBuscaProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textIdBuscaProdutos.Location = new System.Drawing.Point(105, 47);
            this.textIdBuscaProdutos.MaxLength = 12;
            this.textIdBuscaProdutos.Name = "textIdBuscaProdutos";
            this.textIdBuscaProdutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textIdBuscaProdutos.Size = new System.Drawing.Size(138, 25);
            this.textIdBuscaProdutos.TabIndex = 0;
            this.textIdBuscaProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIdBuscaProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label34);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(714, 60);
            this.panel15.TabIndex = 16;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(132, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(433, 32);
            this.label34.TabIndex = 14;
            this.label34.Text = "Consultar informações dos Produtos\r\n";
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelExibirProdutos);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(715, 560);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ConsultaProdutos";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelExibirProdutos.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExibirProdutos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutLayoutExibeProdutos;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label tituloExibeProdutos;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.ComboBox comboBoxOrdemProdutos;
        private System.Windows.Forms.Button btnExibeTodosProdutos;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnBuscaIdProduto;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.TextBox textIdBuscaProdutos;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label34;
    }
}
