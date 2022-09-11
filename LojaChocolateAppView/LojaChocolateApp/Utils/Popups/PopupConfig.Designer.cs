namespace LojaChocolateApp.Utils.Popups
{
    partial class PopupConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupConfig));
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelQuantidade = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAvisoEstoque = new System.Windows.Forms.ComboBox();
            this.checkBoxEstoque = new System.Windows.Forms.CheckBox();
            this.checkBoxDarkMode = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panelQuantidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.White;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnAplicar.Location = new System.Drawing.Point(18, 120);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(244, 36);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelQuantidade);
            this.panel1.Controls.Add(this.checkBoxEstoque);
            this.panel1.Controls.Add(this.checkBoxDarkMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 120);
            this.panel1.TabIndex = 7;
            // 
            // panelQuantidade
            // 
            this.panelQuantidade.Controls.Add(this.label1);
            this.panelQuantidade.Controls.Add(this.comboBoxAvisoEstoque);
            this.panelQuantidade.Location = new System.Drawing.Point(18, 69);
            this.panelQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuantidade.Name = "panelQuantidade";
            this.panelQuantidade.Size = new System.Drawing.Size(244, 43);
            this.panelQuantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione a quantidade:";
            // 
            // comboBoxAvisoEstoque
            // 
            this.comboBoxAvisoEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvisoEstoque.FormattingEnabled = true;
            this.comboBoxAvisoEstoque.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBoxAvisoEstoque.Location = new System.Drawing.Point(162, 7);
            this.comboBoxAvisoEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAvisoEstoque.Name = "comboBoxAvisoEstoque";
            this.comboBoxAvisoEstoque.Size = new System.Drawing.Size(77, 25);
            this.comboBoxAvisoEstoque.TabIndex = 2;
            // 
            // checkBoxEstoque
            // 
            this.checkBoxEstoque.AutoSize = true;
            this.checkBoxEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstoque.Location = new System.Drawing.Point(18, 41);
            this.checkBoxEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEstoque.Name = "checkBoxEstoque";
            this.checkBoxEstoque.Size = new System.Drawing.Size(226, 21);
            this.checkBoxEstoque.TabIndex = 1;
            this.checkBoxEstoque.Text = "Ativar Aviso de Estoque Mínimo";
            this.checkBoxEstoque.UseVisualStyleBackColor = true;
            this.checkBoxEstoque.CheckedChanged += new System.EventHandler(this.checkBoxEstoque_CheckedChanged);
            // 
            // checkBoxDarkMode
            // 
            this.checkBoxDarkMode.AutoSize = true;
            this.checkBoxDarkMode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDarkMode.Location = new System.Drawing.Point(18, 13);
            this.checkBoxDarkMode.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDarkMode.Name = "checkBoxDarkMode";
            this.checkBoxDarkMode.Size = new System.Drawing.Size(136, 21);
            this.checkBoxDarkMode.TabIndex = 0;
            this.checkBoxDarkMode.Text = "Ativar Dark Mode";
            this.checkBoxDarkMode.UseVisualStyleBackColor = true;
            // 
            // PopupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAplicar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopupConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PopupConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelQuantidade.ResumeLayout(false);
            this.panelQuantidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAvisoEstoque;
        private System.Windows.Forms.CheckBox checkBoxEstoque;
        private System.Windows.Forms.CheckBox checkBoxDarkMode;
    }
}