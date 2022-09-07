namespace LojaChocolateApp.Utils.Popups
{
    partial class PopupRemover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.panelRemoverFuncionario = new System.Windows.Forms.Panel();
            this.panelRemoverProduto = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxProdRemover = new System.Windows.Forms.TextBox();
            this.textBoxFunRemove = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panelRemoverFuncionario.SuspendLayout();
            this.panelRemoverProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluirFuncionario);
            this.panel2.Controls.Add(this.btnCANCELAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 81);
            this.panel2.TabIndex = 9;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.BackColor = System.Drawing.Color.Maroon;
            this.btnExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btnExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(58, 15);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(159, 42);
            this.btnExcluirFuncionario.TabIndex = 1;
            this.btnExcluirFuncionario.Text = "REMOVER";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.BackColor = System.Drawing.Color.White;
            this.btnCANCELAR.FlatAppearance.BorderSize = 0;
            this.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELAR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCELAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnCANCELAR.Location = new System.Drawing.Point(236, 15);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(159, 42);
            this.btnCANCELAR.TabIndex = 0;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = false;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // panelRemoverFuncionario
            // 
            this.panelRemoverFuncionario.Controls.Add(this.textBox4);
            this.panelRemoverFuncionario.Controls.Add(this.textBoxFunRemove);
            this.panelRemoverFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRemoverFuncionario.Location = new System.Drawing.Point(0, 0);
            this.panelRemoverFuncionario.Name = "panelRemoverFuncionario";
            this.panelRemoverFuncionario.Size = new System.Drawing.Size(450, 193);
            this.panelRemoverFuncionario.TabIndex = 10;
            // 
            // panelRemoverProduto
            // 
            this.panelRemoverProduto.Controls.Add(this.textBoxProdRemover);
            this.panelRemoverProduto.Controls.Add(this.textBox1);
            this.panelRemoverProduto.Location = new System.Drawing.Point(0, 0);
            this.panelRemoverProduto.Name = "panelRemoverProduto";
            this.panelRemoverProduto.Size = new System.Drawing.Size(450, 193);
            this.panelRemoverProduto.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 32);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Deseja Remover o Produto?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBoxProdRemover
            // 
            this.textBoxProdRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.textBoxProdRemover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProdRemover.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdRemover.ForeColor = System.Drawing.Color.White;
            this.textBoxProdRemover.Location = new System.Drawing.Point(0, 74);
            this.textBoxProdRemover.Multiline = true;
            this.textBoxProdRemover.Name = "textBoxProdRemover";
            this.textBoxProdRemover.Size = new System.Drawing.Size(450, 107);
            this.textBoxProdRemover.TabIndex = 18;
            this.textBoxProdRemover.Text = "Deseja realmente remover o produto do ID informado?\r\n\r\nNúmero de Código nº 00\r\n\r\n" +
    "A remoção vai tira-lo do cadastro \r\npodendo gerar falhas nas informações de vend" +
    "as!";
            this.textBoxProdRemover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProdRemover.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBoxFunRemove
            // 
            this.textBoxFunRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.textBoxFunRemove.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFunRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFunRemove.ForeColor = System.Drawing.Color.White;
            this.textBoxFunRemove.Location = new System.Drawing.Point(0, 74);
            this.textBoxFunRemove.Multiline = true;
            this.textBoxFunRemove.Name = "textBoxFunRemove";
            this.textBoxFunRemove.Size = new System.Drawing.Size(450, 107);
            this.textBoxFunRemove.TabIndex = 20;
            this.textBoxFunRemove.Text = "Deseja realmente remover o funcionário do ID informado? \r\n\r\nNúmero da Matrícula n" +
    "º 00\r\n\r\nA remoção vai tira-lo do cadastro \r\npodendo gerar falhas nas informações" +
    " de vendas!";
            this.textBoxFunRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFunRemove.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(0, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(450, 32);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "Deseja Remover o Funcionário?";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CopiarSelecionar);
            // 
            // PopupRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRemoverProduto);
            this.Controls.Add(this.panelRemoverFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 280);
            this.Name = "PopupRemover";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupRemover";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PopupRemoverFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panelRemoverFuncionario.ResumeLayout(false);
            this.panelRemoverFuncionario.PerformLayout();
            this.panelRemoverProduto.ResumeLayout(false);
            this.panelRemoverProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnCANCELAR;
        public System.Windows.Forms.Panel panelRemoverFuncionario;
        public System.Windows.Forms.Panel panelRemoverProduto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxFunRemove;
        private System.Windows.Forms.TextBox textBoxProdRemover;
        private System.Windows.Forms.TextBox textBox1;
    }
}