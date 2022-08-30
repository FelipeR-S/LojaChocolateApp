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
            this.tituloExibeProdutos = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxOrdemProdutos = new System.Windows.Forms.ComboBox();
            this.btnExibeTodosProdutos = new System.Windows.Forms.Button();
            this.btnBuscaIdProduto = new System.Windows.Forms.Button();
            this.textIdBuscaProdutos = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.flowLayoutLayoutExibeProdutos.Padding = new System.Windows.Forms.Padding(22, 0, 22, 20);
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
            this.tituloExibeProdutos.BackColor = System.Drawing.Color.White;
            this.tituloExibeProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloExibeProdutos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloExibeProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.tituloExibeProdutos.Location = new System.Drawing.Point(40, 3);
            this.tituloExibeProdutos.Name = "tituloExibeProdutos";
            this.tituloExibeProdutos.Size = new System.Drawing.Size(629, 26);
            this.tituloExibeProdutos.TabIndex = 1;
            this.tituloExibeProdutos.Text = "Título";
            this.tituloExibeProdutos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.textBox4);
            this.panel14.Controls.Add(this.textBox3);
            this.panel14.Controls.Add(this.textBox2);
            this.panel14.Controls.Add(this.comboBoxOrdemProdutos);
            this.panel14.Controls.Add(this.btnExibeTodosProdutos);
            this.panel14.Controls.Add(this.btnBuscaIdProduto);
            this.panel14.Controls.Add(this.textIdBuscaProdutos);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 60);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(714, 90);
            this.panel14.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(351, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(87, 18);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Ordenar por:";
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(50, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 18);
            this.textBox3.TabIndex = 35;
            this.textBox3.Text = "Código";
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(0, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(715, 18);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Informe o código para exibir detalhes do produto desejado ou clique no botão \"Tod" +
    "os\"";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
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
            this.panel15.Controls.Add(this.textBox1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(714, 60);
            this.panel15.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(0, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(714, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Consultar informações dos Produtos";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
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
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.ComboBox comboBoxOrdemProdutos;
        private System.Windows.Forms.Button btnExibeTodosProdutos;
        private System.Windows.Forms.Button btnBuscaIdProduto;
        public System.Windows.Forms.TextBox textIdBuscaProdutos;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox tituloExibeProdutos;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
