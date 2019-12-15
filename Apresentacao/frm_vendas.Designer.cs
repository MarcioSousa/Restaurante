namespace Apresentacao
{
    partial class frm_vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vendas));
            this.dgvResumoCaixa = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quebra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbsFiltro = new System.Windows.Forms.CheckBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumoCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResumoCaixa
            // 
            this.dgvResumoCaixa.AllowUserToAddRows = false;
            this.dgvResumoCaixa.AllowUserToDeleteRows = false;
            this.dgvResumoCaixa.AllowUserToResizeColumns = false;
            this.dgvResumoCaixa.AllowUserToResizeRows = false;
            this.dgvResumoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.QTDE,
            this.VALOR,
            this.Quebra});
            this.dgvResumoCaixa.Location = new System.Drawing.Point(16, 72);
            this.dgvResumoCaixa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvResumoCaixa.MultiSelect = false;
            this.dgvResumoCaixa.Name = "dgvResumoCaixa";
            this.dgvResumoCaixa.ReadOnly = true;
            this.dgvResumoCaixa.RowHeadersVisible = false;
            this.dgvResumoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumoCaixa.Size = new System.Drawing.Size(323, 293);
            this.dgvResumoCaixa.TabIndex = 3;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Codigo";
            this.CODIGO.HeaderText = "CodCaixa";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 80;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "Cod_Pedido";
            this.PRODUTO.HeaderText = "CodPedido";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Visible = false;
            this.PRODUTO.Width = 240;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "DataPagamento";
            this.QTDE.HeaderText = "DataPagam";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle1.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALOR.HeaderText = "ValorTotal";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 90;
            // 
            // Quebra
            // 
            this.Quebra.DataPropertyName = "Troco";
            dataGridViewCellStyle2.Format = "C";
            this.Quebra.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quebra.HeaderText = "Quebra";
            this.Quebra.Name = "Quebra";
            this.Quebra.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 21);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Venda";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 173);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // cbsFiltro
            // 
            this.cbsFiltro.AutoSize = true;
            this.cbsFiltro.Location = new System.Drawing.Point(84, 19);
            this.cbsFiltro.Name = "cbsFiltro";
            this.cbsFiltro.Size = new System.Drawing.Size(122, 20);
            this.cbsFiltro.TabIndex = 5;
            this.cbsFiltro.Text = "Filtrar pela Data";
            this.cbsFiltro.UseVisualStyleBackColor = true;
            this.cbsFiltro.CheckedChanged += new System.EventHandler(this.cbsFiltro_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(212, 17);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(105, 22);
            this.dtpData.TabIndex = 6;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbsFiltro);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 200);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Quebra";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(500, 173);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 381);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análise Mensal (Venda e Quebra de Valores)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(61, 374);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(278, 19);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0,00";
            // 
            // frm_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 403);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResumoCaixa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumo do Caixa";
            this.Load += new System.EventHandler(this.frm_caixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_vendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumoCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResumoCaixa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox cbsFiltro;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quebra;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
    }
}