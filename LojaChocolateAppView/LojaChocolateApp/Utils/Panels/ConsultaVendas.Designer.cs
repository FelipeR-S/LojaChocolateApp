namespace LojaChocolateApp.Utils.Panels
{
    partial class ConsultaVendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelConsultaVendas = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarregaListaVendas = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.panelDataGridVendas = new System.Windows.Forms.Panel();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelConsultaVendas.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDataGridVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaVendas
            // 
            this.panelConsultaVendas.AutoSize = true;
            this.panelConsultaVendas.BackColor = System.Drawing.Color.Transparent;
            this.panelConsultaVendas.Controls.Add(this.panel21);
            this.panelConsultaVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConsultaVendas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConsultaVendas.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaVendas.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultaVendas.Name = "panelConsultaVendas";
            this.panelConsultaVendas.Size = new System.Drawing.Size(715, 70);
            this.panelConsultaVendas.TabIndex = 32;
            // 
            // panel21
            // 
            this.panel21.AutoSize = true;
            this.panel21.Controls.Add(this.tableLayoutPanel1);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(715, 70);
            this.panel21.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.83217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.16783F));
            this.tableLayoutPanel1.Controls.Add(this.btnCarregaListaVendas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label52, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCarregaListaVendas
            // 
            this.btnCarregaListaVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnCarregaListaVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaListaVendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaVendas.ForeColor = System.Drawing.Color.White;
            this.btnCarregaListaVendas.Location = new System.Drawing.Point(505, 20);
            this.btnCarregaListaVendas.Margin = new System.Windows.Forms.Padding(20);
            this.btnCarregaListaVendas.Name = "btnCarregaListaVendas";
            this.btnCarregaListaVendas.Size = new System.Drawing.Size(166, 30);
            this.btnCarregaListaVendas.TabIndex = 0;
            this.btnCarregaListaVendas.Text = "Carregar Lista";
            this.btnCarregaListaVendas.UseVisualStyleBackColor = false;
            this.btnCarregaListaVendas.Click += new System.EventHandler(this.btnCarregaListaVendas_Click);
            // 
            // label52
            // 
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.label52.Location = new System.Drawing.Point(20, 20);
            this.label52.Margin = new System.Windows.Forms.Padding(20);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(445, 30);
            this.label52.TabIndex = 99;
            this.label52.Text = "Consultar Vendas Realizadas";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataGridVendas
            // 
            this.panelDataGridVendas.AutoScroll = true;
            this.panelDataGridVendas.AutoSize = true;
            this.panelDataGridVendas.BackColor = System.Drawing.Color.Transparent;
            this.panelDataGridVendas.Controls.Add(this.dataGridViewVendas);
            this.panelDataGridVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridVendas.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGridVendas.Location = new System.Drawing.Point(0, 70);
            this.panelDataGridVendas.Margin = new System.Windows.Forms.Padding(0);
            this.panelDataGridVendas.Name = "panelDataGridVendas";
            this.panelDataGridVendas.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.panelDataGridVendas.Size = new System.Drawing.Size(715, 490);
            this.panelDataGridVendas.TabIndex = 1;
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AllowUserToAddRows = false;
            this.dataGridViewVendas.AllowUserToDeleteRows = false;
            this.dataGridViewVendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVendas.AutoGenerateColumns = false;
            this.dataGridViewVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendas.ColumnHeadersHeight = 35;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.maisDataGridViewTextBoxColumn});
            this.dataGridViewVendas.DataSource = this.dataGridVendasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVendas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVendas.EnableHeadersVisualStyles = false;
            this.dataGridViewVendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewVendas.Location = new System.Drawing.Point(5, 20);
            this.dataGridViewVendas.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.ReadOnly = true;
            this.dataGridViewVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVendas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVendas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewVendas.RowTemplate.ReadOnly = true;
            this.dataGridViewVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewVendas.Size = new System.Drawing.Size(705, 450);
            this.dataGridViewVendas.TabIndex = 1;
            this.dataGridViewVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendas_CellContentClick);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.FillWeight = 203.0457F;
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numeroDataGridViewTextBoxColumn.Width = 60;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.FillWeight = 14.3824F;
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.FillWeight = 253.8071F;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valorDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.FillWeight = 14.3824F;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDataGridViewTextBoxColumn.Width = 90;
            // 
            // maisDataGridViewTextBoxColumn
            // 
            this.maisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maisDataGridViewTextBoxColumn.DataPropertyName = "Mais";
            this.maisDataGridViewTextBoxColumn.FillWeight = 14.3824F;
            this.maisDataGridViewTextBoxColumn.HeaderText = "+";
            this.maisDataGridViewTextBoxColumn.Name = "maisDataGridViewTextBoxColumn";
            this.maisDataGridViewTextBoxColumn.ReadOnly = true;
            this.maisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maisDataGridViewTextBoxColumn.Width = 30;
            // 
            // dataGridVendasBindingSource
            // 
            this.dataGridVendasBindingSource.DataSource = typeof(LojaChocolateApp.Utils.DataGridVendas);
            // 
            // ConsultaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelDataGridVendas);
            this.Controls.Add(this.panelConsultaVendas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ConsultaVendas";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelConsultaVendas.ResumeLayout(false);
            this.panelConsultaVendas.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDataGridVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaVendas;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.BindingSource dataGridVendasBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCarregaListaVendas;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panelDataGridVendas;
        public System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maisDataGridViewTextBoxColumn;
    }
}
