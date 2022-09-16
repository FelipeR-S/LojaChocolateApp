namespace LojaChocolateApp.Utils.LayoutItems
{
    partial class LayoutProdutos
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
            this.panelTodos = new System.Windows.Forms.Panel();
            this.textValorLayout = new System.Windows.Forms.TextBox();
            this.textVendasLayout = new System.Windows.Forms.TextBox();
            this.textEstoqueLayout = new System.Windows.Forms.TextBox();
            this.textTipoLayout = new System.Windows.Forms.TextBox();
            this.textPesoLayout = new System.Windows.Forms.TextBox();
            this.textIdLayout = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNomeLayout = new System.Windows.Forms.TextBox();
            this.BackColorLayout = new System.Windows.Forms.Panel();
            this.btnAddImagem = new FontAwesome.Sharp.IconButton();
            this.pictureLayout = new System.Windows.Forms.PictureBox();
            this.panelTodos.SuspendLayout();
            this.BackColorLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTodos
            // 
            this.panelTodos.BackColor = System.Drawing.Color.Transparent;
            this.panelTodos.Controls.Add(this.textValorLayout);
            this.panelTodos.Controls.Add(this.textVendasLayout);
            this.panelTodos.Controls.Add(this.textEstoqueLayout);
            this.panelTodos.Controls.Add(this.textTipoLayout);
            this.panelTodos.Controls.Add(this.textPesoLayout);
            this.panelTodos.Controls.Add(this.textIdLayout);
            this.panelTodos.Controls.Add(this.textBox5);
            this.panelTodos.Controls.Add(this.textBox6);
            this.panelTodos.Controls.Add(this.textBox3);
            this.panelTodos.Controls.Add(this.textBox4);
            this.panelTodos.Controls.Add(this.textBox2);
            this.panelTodos.Controls.Add(this.textBox1);
            this.panelTodos.Controls.Add(this.textNomeLayout);
            this.panelTodos.Controls.Add(this.BackColorLayout);
            this.panelTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTodos.Location = new System.Drawing.Point(0, 0);
            this.panelTodos.Name = "panelTodos";
            this.panelTodos.Size = new System.Drawing.Size(500, 100);
            this.panelTodos.TabIndex = 0;
            // 
            // textValorLayout
            // 
            this.textValorLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textValorLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textValorLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorLayout.ForeColor = System.Drawing.Color.White;
            this.textValorLayout.Location = new System.Drawing.Point(419, 70);
            this.textValorLayout.Name = "textValorLayout";
            this.textValorLayout.ReadOnly = true;
            this.textValorLayout.Size = new System.Drawing.Size(71, 20);
            this.textValorLayout.TabIndex = 6;
            this.textValorLayout.Text = "000,00";
            this.textValorLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textValorLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textVendasLayout
            // 
            this.textVendasLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textVendasLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVendasLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVendasLayout.ForeColor = System.Drawing.Color.White;
            this.textVendasLayout.Location = new System.Drawing.Point(342, 70);
            this.textVendasLayout.Name = "textVendasLayout";
            this.textVendasLayout.ReadOnly = true;
            this.textVendasLayout.Size = new System.Drawing.Size(28, 20);
            this.textVendasLayout.TabIndex = 5;
            this.textVendasLayout.Text = "000";
            this.textVendasLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textVendasLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textEstoqueLayout
            // 
            this.textEstoqueLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEstoqueLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEstoqueLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstoqueLayout.ForeColor = System.Drawing.Color.White;
            this.textEstoqueLayout.Location = new System.Drawing.Point(178, 70);
            this.textEstoqueLayout.Name = "textEstoqueLayout";
            this.textEstoqueLayout.ReadOnly = true;
            this.textEstoqueLayout.Size = new System.Drawing.Size(93, 20);
            this.textEstoqueLayout.TabIndex = 4;
            this.textEstoqueLayout.Text = "000";
            this.textEstoqueLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textEstoqueLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textTipoLayout
            // 
            this.textTipoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textTipoLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTipoLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipoLayout.ForeColor = System.Drawing.Color.White;
            this.textTipoLayout.Location = new System.Drawing.Point(419, 40);
            this.textTipoLayout.Name = "textTipoLayout";
            this.textTipoLayout.ReadOnly = true;
            this.textTipoLayout.Size = new System.Drawing.Size(71, 20);
            this.textTipoLayout.TabIndex = 3;
            this.textTipoLayout.Text = "Chocolate";
            this.textTipoLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textTipoLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textPesoLayout
            // 
            this.textPesoLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPesoLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPesoLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesoLayout.ForeColor = System.Drawing.Color.White;
            this.textPesoLayout.Location = new System.Drawing.Point(330, 40);
            this.textPesoLayout.Name = "textPesoLayout";
            this.textPesoLayout.ReadOnly = true;
            this.textPesoLayout.Size = new System.Drawing.Size(40, 20);
            this.textPesoLayout.TabIndex = 2;
            this.textPesoLayout.Text = "0000";
            this.textPesoLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPesoLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textIdLayout
            // 
            this.textIdLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textIdLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdLayout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdLayout.ForeColor = System.Drawing.Color.White;
            this.textIdLayout.Location = new System.Drawing.Point(166, 40);
            this.textIdLayout.Name = "textIdLayout";
            this.textIdLayout.ReadOnly = true;
            this.textIdLayout.Size = new System.Drawing.Size(105, 20);
            this.textIdLayout.TabIndex = 1;
            this.textIdLayout.Text = "000000000000";
            this.textIdLayout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textIdLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox5.Location = new System.Drawing.Point(383, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 39;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Valor:";
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox6.Location = new System.Drawing.Point(383, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(35, 20);
            this.textBox6.TabIndex = 38;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Tipo:";
            this.textBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(286, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Vendas:";
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox4.Location = new System.Drawing.Point(286, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(36, 20);
            this.textBox4.TabIndex = 36;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Peso:";
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(114, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Estoque:";
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(114, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Código:";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textNomeLayout
            // 
            this.textNomeLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNomeLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeLayout.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeLayout.ForeColor = System.Drawing.Color.White;
            this.textNomeLayout.Location = new System.Drawing.Point(114, 7);
            this.textNomeLayout.Name = "textNomeLayout";
            this.textNomeLayout.ReadOnly = true;
            this.textNomeLayout.Size = new System.Drawing.Size(376, 23);
            this.textNomeLayout.TabIndex = 0;
            this.textNomeLayout.Text = "Nome";
            this.textNomeLayout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // BackColorLayout
            // 
            this.BackColorLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.BackColorLayout.Controls.Add(this.btnAddImagem);
            this.BackColorLayout.Controls.Add(this.pictureLayout);
            this.BackColorLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackColorLayout.Location = new System.Drawing.Point(0, 0);
            this.BackColorLayout.Name = "BackColorLayout";
            this.BackColorLayout.Size = new System.Drawing.Size(100, 100);
            this.BackColorLayout.TabIndex = 16;
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.BackColor = System.Drawing.Color.White;
            this.btnAddImagem.FlatAppearance.BorderSize = 0;
            this.btnAddImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnAddImagem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddImagem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnAddImagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddImagem.IconSize = 20;
            this.btnAddImagem.Location = new System.Drawing.Point(76, 76);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(24, 24);
            this.btnAddImagem.TabIndex = 0;
            this.btnAddImagem.UseVisualStyleBackColor = false;
            this.btnAddImagem.Click += new System.EventHandler(this.btnAddImagem_Click);
            // 
            // pictureLayout
            // 
            this.pictureLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLayout.BackColor = System.Drawing.Color.Transparent;
            this.pictureLayout.ErrorImage = null;
            this.pictureLayout.ImageLocation = "";
            this.pictureLayout.InitialImage = null;
            this.pictureLayout.Location = new System.Drawing.Point(3, 3);
            this.pictureLayout.Name = "pictureLayout";
            this.pictureLayout.Size = new System.Drawing.Size(95, 95);
            this.pictureLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLayout.TabIndex = 8;
            this.pictureLayout.TabStop = false;
            // 
            // LayoutProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelTodos);
            this.Name = "LayoutProdutos";
            this.Size = new System.Drawing.Size(500, 100);
            this.panelTodos.ResumeLayout(false);
            this.panelTodos.PerformLayout();
            this.BackColorLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTodos;
        private System.Windows.Forms.TextBox textNomeLayout;
        private System.Windows.Forms.TextBox textValorLayout;
        private System.Windows.Forms.TextBox textVendasLayout;
        private System.Windows.Forms.TextBox textEstoqueLayout;
        private System.Windows.Forms.TextBox textTipoLayout;
        private System.Windows.Forms.TextBox textPesoLayout;
        private System.Windows.Forms.TextBox textIdLayout;
        private System.Windows.Forms.Panel BackColorLayout;
        private System.Windows.Forms.PictureBox pictureLayout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton btnAddImagem;
    }
}
