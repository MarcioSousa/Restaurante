namespace Apresentacao
{
    partial class frm_saida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saida));
            this.dgvSaida = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATASAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxPorData = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSaida
            // 
            this.dgvSaida.AllowUserToAddRows = false;
            this.dgvSaida.AllowUserToDeleteRows = false;
            this.dgvSaida.AllowUserToResizeColumns = false;
            this.dgvSaida.AllowUserToResizeRows = false;
            this.dgvSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.QTDE,
            this.DATASAIDA});
            this.dgvSaida.Location = new System.Drawing.Point(6, 76);
            this.dgvSaida.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvSaida.MultiSelect = false;
            this.dgvSaida.Name = "dgvSaida";
            this.dgvSaida.ReadOnly = true;
            this.dgvSaida.RowHeadersVisible = false;
            this.dgvSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaida.Size = new System.Drawing.Size(499, 337);
            this.dgvSaida.TabIndex = 11;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Codigo";
            this.CODIGO.HeaderText = "CodSaida";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 80;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "Nome";
            this.PRODUTO.HeaderText = "Nome";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 240;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "Qtde";
            this.QTDE.HeaderText = "Qtde";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 50;
            // 
            // DATASAIDA
            // 
            this.DATASAIDA.DataPropertyName = "DataSaida";
            this.DATASAIDA.HeaderText = "DataSaída";
            this.DATASAIDA.Name = "DATASAIDA";
            this.DATASAIDA.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxPorData);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dtpDataSaida);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 46);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtro";
            // 
            // cbxPorData
            // 
            this.cbxPorData.AutoSize = true;
            this.cbxPorData.Location = new System.Drawing.Point(10, 19);
            this.cbxPorData.Name = "cbxPorData";
            this.cbxPorData.Size = new System.Drawing.Size(77, 20);
            this.cbxPorData.TabIndex = 30;
            this.cbxPorData.Text = "PorData";
            this.cbxPorData.UseVisualStyleBackColor = true;
            this.cbxPorData.CheckedChanged += new System.EventHandler(this.cbxPorData_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dt. Saida";
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(189, 17);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(94, 22);
            this.dtpDataSaida.TabIndex = 0;
            this.dtpDataSaida.ValueChanged += new System.EventHandler(this.dtpDataSaida_ValueChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(430, 44);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.dgvSaida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 451);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(430, 422);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frm_saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 475);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Produtos no Estoque";
            this.Load += new System.EventHandler(this.frm_saida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_saida_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaida)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATASAIDA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxPorData;
        private System.Windows.Forms.Button btnExcluir;
    }
}