namespace Apresentacao
{
    partial class frm_estoque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estoque));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTENTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataRecebFiltro = new System.Windows.Forms.DateTimePicker();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.dtpDataVenc = new System.Windows.Forms.DateTimePicker();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataReceb = new System.Windows.Forms.DateTimePicker();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.eP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(370, 86);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(383, 22);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeColumns = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.DTENTR,
            this.QTDE,
            this.DTVANC,
            this.CODESTOQUE,
            this.TIPOA,
            this.VALORTOTAL});
            this.dgvEstoque.Location = new System.Drawing.Point(7, 75);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(548, 443);
            this.dgvEstoque.TabIndex = 3;
            this.dgvEstoque.SelectionChanged += new System.EventHandler(this.dgvEstoque_SelectionChanged);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Cod_Produto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle1;
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 60;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "Nome";
            this.NOME.HeaderText = "Produto";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 220;
            // 
            // DTENTR
            // 
            this.DTENTR.DataPropertyName = "DataEntrada";
            this.DTENTR.HeaderText = "Dt.Entrada";
            this.DTENTR.Name = "DTENTR";
            this.DTENTR.ReadOnly = true;
            this.DTENTR.Width = 90;
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "Qtde";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QTDE.DefaultCellStyle = dataGridViewCellStyle2;
            this.QTDE.HeaderText = "Qtde";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 60;
            // 
            // DTVANC
            // 
            this.DTVANC.DataPropertyName = "DataVencimento";
            this.DTVANC.HeaderText = "Dt.Vencim.";
            this.DTVANC.Name = "DTVANC";
            this.DTVANC.ReadOnly = true;
            this.DTVANC.Width = 90;
            // 
            // CODESTOQUE
            // 
            this.CODESTOQUE.DataPropertyName = "Codigo";
            this.CODESTOQUE.HeaderText = "CodEntrada";
            this.CODESTOQUE.Name = "CODESTOQUE";
            this.CODESTOQUE.ReadOnly = true;
            this.CODESTOQUE.Visible = false;
            // 
            // TIPOA
            // 
            this.TIPOA.DataPropertyName = "Tipo";
            this.TIPOA.HeaderText = "Tipo";
            this.TIPOA.Name = "TIPOA";
            this.TIPOA.ReadOnly = true;
            this.TIPOA.Visible = false;
            // 
            // VALORTOTAL
            // 
            this.VALORTOTAL.DataPropertyName = "ValorTotal";
            this.VALORTOTAL.HeaderText = "ValorTotal";
            this.VALORTOTAL.Name = "VALORTOTAL";
            this.VALORTOTAL.ReadOnly = true;
            this.VALORTOTAL.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(115, 31);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 22);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(7, 31);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dgvEstoque);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo do Estoque";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dtpDataRecebFiltro);
            this.groupBox4.Location = new System.Drawing.Point(334, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 46);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dt. Entrada";
            // 
            // dtpDataRecebFiltro
            // 
            this.dtpDataRecebFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRecebFiltro.Location = new System.Drawing.Point(116, 15);
            this.dtpDataRecebFiltro.Name = "dtpDataRecebFiltro";
            this.dtpDataRecebFiltro.Size = new System.Drawing.Size(94, 22);
            this.dtpDataRecebFiltro.TabIndex = 0;
            this.dtpDataRecebFiltro.ValueChanged += new System.EventHandler(this.dtpDataRecebFiltro_ValueChanged);
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToAddRows = false;
            this.dgvEntrada.AllowUserToDeleteRows = false;
            this.dgvEntrada.AllowUserToResizeColumns = false;
            this.dgvEntrada.AllowUserToResizeRows = false;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.VENC,
            this.QTDE2,
            this.TOTAL,
            this.TIPO,
            this.DATA});
            this.dgvEntrada.Location = new System.Drawing.Point(6, 194);
            this.dgvEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntrada.MultiSelect = false;
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.ReadOnly = true;
            this.dgvEntrada.RowHeadersVisible = false;
            this.dgvEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrada.Size = new System.Drawing.Size(478, 288);
            this.dgvEntrada.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // VENC
            // 
            this.VENC.HeaderText = "Dt.Venc.";
            this.VENC.Name = "VENC";
            this.VENC.ReadOnly = true;
            // 
            // QTDE2
            // 
            this.QTDE2.HeaderText = "Qtde";
            this.QTDE2.Name = "QTDE2";
            this.QTDE2.ReadOnly = true;
            this.QTDE2.Width = 60;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle4.Format = "C";
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "Tipo";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 60;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "Dt.Entrada";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFinaliza);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvEntrada);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(580, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 525);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada no Estoque";
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Enabled = false;
            this.btnFinaliza.Location = new System.Drawing.Point(383, 490);
            this.btnFinaliza.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(100, 28);
            this.btnFinaliza.TabIndex = 4;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtValorTotal);
            this.groupBox3.Controls.Add(this.txtTipo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtQtde);
            this.groupBox3.Controls.Add(this.btnAdicionar);
            this.groupBox3.Controls.Add(this.dtpDataVenc);
            this.groupBox3.Controls.Add(this.txtCodProduto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpDataReceb);
            this.groupBox3.Controls.Add(this.txtProduto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(290, 89);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(73, 22);
            this.txtValorTotal.TabIndex = 6;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(7, 89);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(49, 22);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Qtde";
            // 
            // txtQtde
            // 
            this.txtQtde.Enabled = false;
            this.txtQtde.Location = new System.Drawing.Point(399, 37);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(71, 22);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // dtpDataVenc
            // 
            this.dtpDataVenc.Enabled = false;
            this.dtpDataVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenc.Location = new System.Drawing.Point(162, 89);
            this.dtpDataVenc.Name = "dtpDataVenc";
            this.dtpDataVenc.Size = new System.Drawing.Size(94, 22);
            this.dtpDataVenc.TabIndex = 5;
            this.dtpDataVenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataVenc_KeyPress);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(7, 37);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(78, 22);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dt. Vencim.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Produto";
            // 
            // dtpDataReceb
            // 
            this.dtpDataReceb.Enabled = false;
            this.dtpDataReceb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReceb.Location = new System.Drawing.Point(62, 89);
            this.dtpDataReceb.Name = "dtpDataReceb";
            this.dtpDataReceb.Size = new System.Drawing.Size(94, 22);
            this.dtpDataReceb.TabIndex = 4;
            this.dtpDataReceb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataReceb_KeyPress);
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(91, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(302, 22);
            this.txtProduto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dt. Receb.";
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            // 
            // eP
            // 
            this.eP.ContainerControl = this;
            // 
            // frm_estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque - Entrada";
            this.Load += new System.EventHandler(this.frm_estoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_estoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.DateTimePicker dtpDataVenc;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataReceb;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataRecebFiltro;
        private System.Windows.Forms.Label label9;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTENTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORTOTAL;
        private System.Windows.Forms.ErrorProvider eP;
    }
}