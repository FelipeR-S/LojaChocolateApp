namespace LojaChocolateApp.Utils.Panels
{
    partial class ConsultaFuncionarios
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
            this.panelConsultarFuncionario = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFuncionario = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TituloExibeFuncionario = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.btnExibeTodosFuncionarios = new System.Windows.Forms.Button();
            this.btnBuscaIdFuncionario = new System.Windows.Forms.Button();
            this.textBoxIDDetalhesFuncionario = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelConsultarFuncionario.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsultarFuncionario
            // 
            this.panelConsultarFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.panelConsultarFuncionario.Controls.Add(this.flowLayoutPanelFuncionario);
            this.panelConsultarFuncionario.Controls.Add(this.panel7);
            this.panelConsultarFuncionario.Controls.Add(this.panel3);
            this.panelConsultarFuncionario.Controls.Add(this.panel4);
            this.panelConsultarFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultarFuncionario.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConsultarFuncionario.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarFuncionario.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultarFuncionario.Name = "panelConsultarFuncionario";
            this.panelConsultarFuncionario.Size = new System.Drawing.Size(715, 560);
            this.panelConsultarFuncionario.TabIndex = 8;
            // 
            // flowLayoutPanelFuncionario
            // 
            this.flowLayoutPanelFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelFuncionario.AutoScroll = true;
            this.flowLayoutPanelFuncionario.Location = new System.Drawing.Point(0, 185);
            this.flowLayoutPanelFuncionario.Name = "flowLayoutPanelFuncionario";
            this.flowLayoutPanelFuncionario.Padding = new System.Windows.Forms.Padding(22, 0, 22, 20);
            this.flowLayoutPanelFuncionario.Size = new System.Drawing.Size(715, 376);
            this.flowLayoutPanelFuncionario.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.TituloExibeFuncionario);
            this.panel7.Location = new System.Drawing.Point(0, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(672, 35);
            this.panel7.TabIndex = 30;
            // 
            // TituloExibeFuncionario
            // 
            this.TituloExibeFuncionario.BackColor = System.Drawing.Color.White;
            this.TituloExibeFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TituloExibeFuncionario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloExibeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.TituloExibeFuncionario.Location = new System.Drawing.Point(47, 6);
            this.TituloExibeFuncionario.Name = "TituloExibeFuncionario";
            this.TituloExibeFuncionario.Size = new System.Drawing.Size(622, 26);
            this.TituloExibeFuncionario.TabIndex = 16;
            this.TituloExibeFuncionario.Text = "Título";
            this.TituloExibeFuncionario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBoxOrdenar);
            this.panel3.Controls.Add(this.btnExibeTodosFuncionarios);
            this.panel3.Controls.Add(this.btnBuscaIdFuncionario);
            this.panel3.Controls.Add(this.textBoxIDDetalhesFuncionario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 90);
            this.panel3.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(0, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(715, 18);
            this.textBox3.TabIndex = 36;
            this.textBox3.Text = "Informe a Matrícula para exibir detalhes do funcionário desejado ou clique no bot" +
    "ão \"Todos\"";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(333, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 18);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Ordenar por:";
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(76, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 18);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Matrícula";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Cargo"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(424, 46);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(110, 25);
            this.comboBoxOrdenar.TabIndex = 3;
            // 
            // btnExibeTodosFuncionarios
            // 
            this.btnExibeTodosFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnExibeTodosFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnExibeTodosFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibeTodosFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibeTodosFuncionarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExibeTodosFuncionarios.Location = new System.Drawing.Point(558, 45);
            this.btnExibeTodosFuncionarios.Name = "btnExibeTodosFuncionarios";
            this.btnExibeTodosFuncionarios.Size = new System.Drawing.Size(81, 27);
            this.btnExibeTodosFuncionarios.TabIndex = 2;
            this.btnExibeTodosFuncionarios.Text = "Todos";
            this.btnExibeTodosFuncionarios.UseVisualStyleBackColor = false;
            this.btnExibeTodosFuncionarios.Click += new System.EventHandler(this.btnExibeTodosFuncionarios_Click);
            // 
            // btnBuscaIdFuncionario
            // 
            this.btnBuscaIdFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnBuscaIdFuncionario.FlatAppearance.BorderSize = 0;
            this.btnBuscaIdFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaIdFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaIdFuncionario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscaIdFuncionario.Location = new System.Drawing.Point(230, 45);
            this.btnBuscaIdFuncionario.Name = "btnBuscaIdFuncionario";
            this.btnBuscaIdFuncionario.Size = new System.Drawing.Size(81, 27);
            this.btnBuscaIdFuncionario.TabIndex = 1;
            this.btnBuscaIdFuncionario.Text = "Buscar";
            this.btnBuscaIdFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscaIdFuncionario.Click += new System.EventHandler(this.btnExibeDetalhesFuncionario_Click);
            // 
            // textBoxIDDetalhesFuncionario
            // 
            this.textBoxIDDetalhesFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(167)))), ((int)(((byte)(101)))));
            this.textBoxIDDetalhesFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIDDetalhesFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDDetalhesFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIDDetalhesFuncionario.Location = new System.Drawing.Point(152, 47);
            this.textBoxIDDetalhesFuncionario.MaxLength = 3;
            this.textBoxIDDetalhesFuncionario.Name = "textBoxIDDetalhesFuncionario";
            this.textBoxIDDetalhesFuncionario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIDDetalhesFuncionario.Size = new System.Drawing.Size(64, 25);
            this.textBoxIDDetalhesFuncionario.TabIndex = 0;
            this.textBoxIDDetalhesFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDDetalhesFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 60);
            this.panel4.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox4.Location = new System.Drawing.Point(0, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(715, 32);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Consultar informações de Funcionários";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // ConsultaFuncionarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelConsultarFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(715, 560);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ConsultaFuncionarios";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelConsultarFuncionario.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarFuncionario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.Button btnExibeTodosFuncionarios;
        private System.Windows.Forms.Button btnBuscaIdFuncionario;
        public System.Windows.Forms.TextBox textBoxIDDetalhesFuncionario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TituloExibeFuncionario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFuncionario;
    }
}
