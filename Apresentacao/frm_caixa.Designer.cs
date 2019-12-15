namespace Apresentacao
{
    partial class frm_caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_caixa));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPagam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.dtpPagam = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEDIDOPRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.printDocB = new System.Drawing.Printing.PrintDocument();
            this.printDocC = new System.Drawing.Printing.PrintDocument();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total";
            // 
            // txtPagam
            // 
            this.txtPagam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagam.Location = new System.Drawing.Point(334, 457);
            this.txtPagam.Name = "txtPagam";
            this.txtPagam.Size = new System.Drawing.Size(114, 29);
            this.txtPagam.TabIndex = 2;
            this.txtPagam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPagam.TextChanged += new System.EventHandler(this.txtPagam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(300, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(80, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Troco";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(499, 430);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(110, 81);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "Confirmar Pagamento";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // dtpPagam
            // 
            this.dtpPagam.Enabled = false;
            this.dtpPagam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagam.Location = new System.Drawing.Point(499, 101);
            this.dtpPagam.Name = "dtpPagam";
            this.dtpPagam.Size = new System.Drawing.Size(110, 22);
            this.dtpPagam.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPreco);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtQtde);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.txtCodProduto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Location = new System.Drawing.Point(466, 39);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(123, 22);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Preço(unid)";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(422, 39);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(5);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(34, 22);
            this.txtQtde.TabIndex = 1;
            this.txtQtde.Text = "1";
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Qtde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtProduto
            // 
            this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(84, 39);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(328, 22);
            this.txtProduto.TabIndex = 1;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 39);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(62, 22);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Produto";
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AllowUserToResizeColumns = false;
            this.dgvCaixa.AllowUserToResizeRows = false;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.VALOR,
            this.QTDE,
            this.PEDIDOPRODUTO,
            this.TIPO});
            this.dgvCaixa.Location = new System.Drawing.Point(12, 101);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCaixa.MultiSelect = false;
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowHeadersVisible = false;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(479, 324);
            this.dgvCaixa.TabIndex = 10;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Cod_Produto";
            this.CODIGO.HeaderText = "Produto";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 70;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "Nome";
            this.PRODUTO.HeaderText = "Nome";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 240;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "ValorUnitario";
            dataGridViewCellStyle1.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALOR.HeaderText = "Valor Un.";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 90;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "Qtde";
            this.QTDE.HeaderText = "Qtde";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 50;
            // 
            // PEDIDOPRODUTO
            // 
            this.PEDIDOPRODUTO.DataPropertyName = "Cod_PedidoProduto";
            this.PEDIDOPRODUTO.HeaderText = "Codigo";
            this.PEDIDOPRODUTO.Name = "PEDIDOPRODUTO";
            this.PEDIDOPRODUTO.ReadOnly = true;
            this.PEDIDOPRODUTO.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "Tipo";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(6, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(12, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 81);
            this.label8.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(6, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(499, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFechar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Location = new System.Drawing.Point(499, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 84);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(6, 50);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorTotal.Location = new System.Drawing.Point(146, 440);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(73, 24);
            this.lblValorTotal.TabIndex = 11;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTroco.Location = new System.Drawing.Point(146, 475);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(73, 24);
            this.lblTroco.TabIndex = 12;
            this.lblTroco.Text = "R$ 0,00";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(8, 21);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnImprimir);
            this.groupBox4.Location = new System.Drawing.Point(499, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // printDocB
            // 
            this.printDocB.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocB_PrintPage);
            // 
            // printDocC
            // 
            this.printDocC.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocC_PrintPage);
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(516, 353);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(75, 16);
            this.lblCodigoPedido.TabIndex = 13;
            this.lblCodigoPedido.Text = "codPedido";
            // 
            // frm_caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpPagam);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPagam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCodigoPedido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frm_caixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_caixa_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.DateTimePicker dtpPagam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Drawing.Printing.PrintDocument printDocB;
        private System.Drawing.Printing.PrintDocument printDocC;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDIDOPRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
    }
}