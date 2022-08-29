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
            this.panelConsultaVendas = new System.Windows.Forms.Panel();
            this.panelDataGridVendas = new System.Windows.Forms.Panel();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnCarregaListaVendas = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.dataGridVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultaVendas.SuspendLayout();
            this.panelDataGridVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaVendas
            // 
            this.panelConsultaVendas.AutoScroll = true;
            this.panelConsultaVendas.BackColor = System.Drawing.Color.Transparent;
            this.panelConsultaVendas.Controls.Add(this.panelDataGridVendas);
            this.panelConsultaVendas.Controls.Add(this.panel19);
            this.panelConsultaVendas.Controls.Add(this.panel21);
            this.panelConsultaVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsultaVendas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConsultaVendas.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaVendas.Margin = new System.Windows.Forms.Padding(0);
            this.panelConsultaVendas.Name = "panelConsultaVendas";
            this.panelConsultaVendas.Size = new System.Drawing.Size(715, 560);
            this.panelConsultaVendas.TabIndex = 32;
            // 
            // panelDataGridVendas
            // 
            this.panelDataGridVendas.BackColor = System.Drawing.Color.Transparent;
            this.panelDataGridVendas.Controls.Add(this.dataGridViewVendas);
            this.panelDataGridVendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGridVendas.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGridVendas.Location = new System.Drawing.Point(0, 71);
            this.panelDataGridVendas.Name = "panelDataGridVendas";
            this.panelDataGridVendas.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.panelDataGridVendas.Size = new System.Drawing.Size(715, 489);
            this.panelDataGridVendas.TabIndex = 31;
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
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(139)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(99)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.maisDataGridViewTextBoxColumn});
            this.dataGridViewVendas.DataSource = this.dataGridVendasBindingSource;
            this.dataGridViewVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVendas.EnableHeadersVisualStyles = false;
            this.dataGridViewVendas.Location = new System.Drawing.Point(20, 5);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.ReadOnly = true;
            this.dataGridViewVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewVendas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewVendas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVendas.RowTemplate.ReadOnly = true;
            this.dataGridViewVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewVendas.Size = new System.Drawing.Size(675, 464);
            this.dataGridViewVendas.TabIndex = 1;
            this.dataGridViewVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendas_CellContentClick);
            // 
            // panel19
            // 
            this.panel19.Location = new System.Drawing.Point(0, 60);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(672, 10);
            this.panel19.TabIndex = 30;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnCarregaListaVendas);
            this.panel21.Controls.Add(this.label52);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(715, 60);
            this.panel21.TabIndex = 16;
            // 
            // btnCarregaListaVendas
            // 
            this.btnCarregaListaVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.btnCarregaListaVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaListaVendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaVendas.ForeColor = System.Drawing.Color.White;
            this.btnCarregaListaVendas.Location = new System.Drawing.Point(539, 16);
            this.btnCarregaListaVendas.Name = "btnCarregaListaVendas";
            this.btnCarregaListaVendas.Size = new System.Drawing.Size(154, 30);
            this.btnCarregaListaVendas.TabIndex = 15;
            this.btnCarregaListaVendas.Text = "Carregar Lista";
            this.btnCarregaListaVendas.UseVisualStyleBackColor = false;
            this.btnCarregaListaVendas.Click += new System.EventHandler(this.btnCarregaListaVendas_Click);
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(0)))));
            this.label52.Location = new System.Drawing.Point(0, 16);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(371, 29);
            this.label52.TabIndex = 14;
            this.label52.Text = "Consultar Vendas Realizadas";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridVendasBindingSource
            // 
            this.dataGridVendasBindingSource.DataSource = typeof(LojaChocolateApp.Utils.DataGridVendas);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maisDataGridViewTextBoxColumn
            // 
            this.maisDataGridViewTextBoxColumn.DataPropertyName = "Mais";
            this.maisDataGridViewTextBoxColumn.HeaderText = "+";
            this.maisDataGridViewTextBoxColumn.Name = "maisDataGridViewTextBoxColumn";
            this.maisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaVendas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelConsultaVendas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(715, 560);
            this.MinimumSize = new System.Drawing.Size(715, 560);
            this.Name = "ConsultaVendas";
            this.Size = new System.Drawing.Size(715, 560);
            this.panelConsultaVendas.ResumeLayout(false);
            this.panelDataGridVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaVendas;
        private System.Windows.Forms.Panel panelDataGridVendas;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnCarregaListaVendas;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.BindingSource dataGridVendasBindingSource;
        public System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maisDataGridViewTextBoxColumn;
    }
}
