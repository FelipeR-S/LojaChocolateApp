namespace LojaChocolateApp.Utils.LayoutItems
{
    partial class LayoutFuncionarios
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
            this.panelDetalhes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNomeLayout = new System.Windows.Forms.TextBox();
            this.textIdLayout = new System.Windows.Forms.TextBox();
            this.textCpfLayout = new System.Windows.Forms.TextBox();
            this.btnMenosDetalhes = new System.Windows.Forms.Button();
            this.btnMaisDetalhes = new System.Windows.Forms.Button();
            this.BackColorLayout = new System.Windows.Forms.Panel();
            this.pictureLayout = new System.Windows.Forms.PictureBox();
            this.panelExibeDetalhes = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textVendasLayout = new System.Windows.Forms.TextBox();
            this.textDataCadastroLayout = new System.Windows.Forms.TextBox();
            this.textCargoLayout = new System.Windows.Forms.TextBox();
            this.textSalarioLayout = new System.Windows.Forms.TextBox();
            this.textContatoLayout = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDetalhes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BackColorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLayout)).BeginInit();
            this.panelExibeDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetalhes
            // 
            this.panelDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.panelDetalhes.Controls.Add(this.panel1);
            this.panelDetalhes.Controls.Add(this.BackColorLayout);
            this.panelDetalhes.Controls.Add(this.panelExibeDetalhes);
            this.panelDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalhes.Location = new System.Drawing.Point(0, 0);
            this.panelDetalhes.Name = "panelDetalhes";
            this.panelDetalhes.Size = new System.Drawing.Size(650, 180);
            this.panelDetalhes.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textNomeLayout);
            this.panel1.Controls.Add(this.textIdLayout);
            this.panel1.Controls.Add(this.textCpfLayout);
            this.panel1.Controls.Add(this.btnMenosDetalhes);
            this.panel1.Controls.Add(this.btnMaisDetalhes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 64);
            this.panel1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(297, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(37, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "CPF:";
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(29, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Matrícula:";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textNomeLayout
            // 
            this.textNomeLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNomeLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeLayout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeLayout.ForeColor = System.Drawing.Color.White;
            this.textNomeLayout.Location = new System.Drawing.Point(29, 13);
            this.textNomeLayout.Name = "textNomeLayout";
            this.textNomeLayout.ReadOnly = true;
            this.textNomeLayout.Size = new System.Drawing.Size(432, 26);
            this.textNomeLayout.TabIndex = 0;
            this.textNomeLayout.Text = "Nome";
            this.textNomeLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textIdLayout
            // 
            this.textIdLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textIdLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdLayout.ForeColor = System.Drawing.Color.White;
            this.textIdLayout.Location = new System.Drawing.Point(114, 45);
            this.textIdLayout.Name = "textIdLayout";
            this.textIdLayout.ReadOnly = true;
            this.textIdLayout.Size = new System.Drawing.Size(40, 22);
            this.textIdLayout.TabIndex = 1;
            this.textIdLayout.Text = "000";
            this.textIdLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textIdLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textCpfLayout
            // 
            this.textCpfLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCpfLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCpfLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpfLayout.ForeColor = System.Drawing.Color.White;
            this.textCpfLayout.Location = new System.Drawing.Point(337, 44);
            this.textCpfLayout.Name = "textCpfLayout";
            this.textCpfLayout.ReadOnly = true;
            this.textCpfLayout.Size = new System.Drawing.Size(124, 22);
            this.textCpfLayout.TabIndex = 2;
            this.textCpfLayout.Text = "000.000.000-00";
            this.textCpfLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCpfLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // btnMenosDetalhes
            // 
            this.btnMenosDetalhes.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenosDetalhes.FlatAppearance.BorderSize = 0;
            this.btnMenosDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosDetalhes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosDetalhes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMenosDetalhes.Location = new System.Drawing.Point(467, 13);
            this.btnMenosDetalhes.Name = "btnMenosDetalhes";
            this.btnMenosDetalhes.Size = new System.Drawing.Size(25, 25);
            this.btnMenosDetalhes.TabIndex = 0;
            this.btnMenosDetalhes.Text = "X";
            this.btnMenosDetalhes.UseVisualStyleBackColor = false;
            this.btnMenosDetalhes.Click += new System.EventHandler(this.btnMenosDetalhes_Click);
            // 
            // btnMaisDetalhes
            // 
            this.btnMaisDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnMaisDetalhes.FlatAppearance.BorderSize = 0;
            this.btnMaisDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisDetalhes.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisDetalhes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMaisDetalhes.Location = new System.Drawing.Point(467, 13);
            this.btnMaisDetalhes.Name = "btnMaisDetalhes";
            this.btnMaisDetalhes.Size = new System.Drawing.Size(25, 25);
            this.btnMaisDetalhes.TabIndex = 0;
            this.btnMaisDetalhes.Text = "+";
            this.btnMaisDetalhes.UseVisualStyleBackColor = false;
            this.btnMaisDetalhes.Click += new System.EventHandler(this.btnMaisDetalhes_Click);
            // 
            // BackColorLayout
            // 
            this.BackColorLayout.BackColor = System.Drawing.Color.Transparent;
            this.BackColorLayout.Controls.Add(this.pictureLayout);
            this.BackColorLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackColorLayout.Location = new System.Drawing.Point(0, 0);
            this.BackColorLayout.Name = "BackColorLayout";
            this.BackColorLayout.Size = new System.Drawing.Size(132, 80);
            this.BackColorLayout.TabIndex = 16;
            // 
            // pictureLayout
            // 
            this.pictureLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLayout.BackColor = System.Drawing.Color.Transparent;
            this.pictureLayout.ErrorImage = null;
            this.pictureLayout.Image = global::LojaChocolateApp.Properties.Resources.userWhite;
            this.pictureLayout.ImageLocation = "";
            this.pictureLayout.InitialImage = null;
            this.pictureLayout.Location = new System.Drawing.Point(28, 5);
            this.pictureLayout.Name = "pictureLayout";
            this.pictureLayout.Size = new System.Drawing.Size(71, 71);
            this.pictureLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLayout.TabIndex = 8;
            this.pictureLayout.TabStop = false;
            // 
            // panelExibeDetalhes
            // 
            this.panelExibeDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.panelExibeDetalhes.Controls.Add(this.textBox7);
            this.panelExibeDetalhes.Controls.Add(this.textBox6);
            this.panelExibeDetalhes.Controls.Add(this.textBox5);
            this.panelExibeDetalhes.Controls.Add(this.textBox4);
            this.panelExibeDetalhes.Controls.Add(this.textBox3);
            this.panelExibeDetalhes.Controls.Add(this.textVendasLayout);
            this.panelExibeDetalhes.Controls.Add(this.textDataCadastroLayout);
            this.panelExibeDetalhes.Controls.Add(this.textCargoLayout);
            this.panelExibeDetalhes.Controls.Add(this.textSalarioLayout);
            this.panelExibeDetalhes.Controls.Add(this.textContatoLayout);
            this.panelExibeDetalhes.Controls.Add(this.panel3);
            this.panelExibeDetalhes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExibeDetalhes.Location = new System.Drawing.Point(0, 80);
            this.panelExibeDetalhes.Name = "panelExibeDetalhes";
            this.panelExibeDetalhes.Size = new System.Drawing.Size(650, 100);
            this.panelExibeDetalhes.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox7.Location = new System.Drawing.Point(371, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(180, 22);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Quantidade de Vendas:";
            this.textBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox6.Location = new System.Drawing.Point(28, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(141, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Data do Cadastro:";
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox5.Location = new System.Drawing.Point(443, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(68, 22);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Salário:";
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox4.Location = new System.Drawing.Point(190, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(68, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Contato:";
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(28, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(55, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Cargo:";
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textVendasLayout
            // 
            this.textVendasLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textVendasLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVendasLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVendasLayout.ForeColor = System.Drawing.Color.White;
            this.textVendasLayout.Location = new System.Drawing.Point(543, 55);
            this.textVendasLayout.Name = "textVendasLayout";
            this.textVendasLayout.ReadOnly = true;
            this.textVendasLayout.Size = new System.Drawing.Size(51, 22);
            this.textVendasLayout.TabIndex = 7;
            this.textVendasLayout.Text = "000";
            this.textVendasLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textVendasLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textDataCadastroLayout
            // 
            this.textDataCadastroLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDataCadastroLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDataCadastroLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataCadastroLayout.ForeColor = System.Drawing.Color.White;
            this.textDataCadastroLayout.Location = new System.Drawing.Point(175, 55);
            this.textDataCadastroLayout.Name = "textDataCadastroLayout";
            this.textDataCadastroLayout.ReadOnly = true;
            this.textDataCadastroLayout.Size = new System.Drawing.Size(98, 22);
            this.textDataCadastroLayout.TabIndex = 6;
            this.textDataCadastroLayout.Text = "00/00/0000";
            this.textDataCadastroLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDataCadastroLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textCargoLayout
            // 
            this.textCargoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCargoLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCargoLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCargoLayout.ForeColor = System.Drawing.Color.White;
            this.textCargoLayout.Location = new System.Drawing.Point(89, 22);
            this.textCargoLayout.Name = "textCargoLayout";
            this.textCargoLayout.ReadOnly = true;
            this.textCargoLayout.Size = new System.Drawing.Size(80, 22);
            this.textCargoLayout.TabIndex = 3;
            this.textCargoLayout.Text = "vendedor";
            this.textCargoLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textCargoLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textSalarioLayout
            // 
            this.textSalarioLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textSalarioLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSalarioLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalarioLayout.ForeColor = System.Drawing.Color.White;
            this.textSalarioLayout.Location = new System.Drawing.Point(502, 22);
            this.textSalarioLayout.Name = "textSalarioLayout";
            this.textSalarioLayout.ReadOnly = true;
            this.textSalarioLayout.Size = new System.Drawing.Size(92, 22);
            this.textSalarioLayout.TabIndex = 5;
            this.textSalarioLayout.Text = "00000,00";
            this.textSalarioLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textSalarioLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textContatoLayout
            // 
            this.textContatoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textContatoLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContatoLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContatoLayout.ForeColor = System.Drawing.Color.White;
            this.textContatoLayout.Location = new System.Drawing.Point(259, 22);
            this.textContatoLayout.Name = "textContatoLayout";
            this.textContatoLayout.ReadOnly = true;
            this.textContatoLayout.Size = new System.Drawing.Size(131, 22);
            this.textContatoLayout.TabIndex = 4;
            this.textContatoLayout.Text = "(00)00000-0000";
            this.textContatoLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textContatoLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 1);
            this.panel3.TabIndex = 19;
            // 
            // LayoutFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelDetalhes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "LayoutFuncionarios";
            this.Size = new System.Drawing.Size(650, 180);
            this.panelDetalhes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BackColorLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLayout)).EndInit();
            this.panelExibeDetalhes.ResumeLayout(false);
            this.panelExibeDetalhes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNomeLayout;
        private System.Windows.Forms.TextBox textIdLayout;
        private System.Windows.Forms.TextBox textCpfLayout;
        public System.Windows.Forms.Button btnMenosDetalhes;
        public System.Windows.Forms.Button btnMaisDetalhes;
        private System.Windows.Forms.Panel BackColorLayout;
        private System.Windows.Forms.PictureBox pictureLayout;
        public System.Windows.Forms.Panel panelExibeDetalhes;
        private System.Windows.Forms.TextBox textVendasLayout;
        private System.Windows.Forms.TextBox textDataCadastroLayout;
        private System.Windows.Forms.TextBox textCargoLayout;
        private System.Windows.Forms.TextBox textSalarioLayout;
        private System.Windows.Forms.TextBox textContatoLayout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelDetalhes;
    }
}
