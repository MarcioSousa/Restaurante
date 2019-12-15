namespace Apresentacao
{
    partial class frm_recebimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_recebimento));
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.PAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.nudQtdePessoas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorIndividual = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPagam = new System.Windows.Forms.DateTimePicker();
            this.cbxForma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFalta = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblJapago = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdePessoas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AllowUserToResizeColumns = false;
            this.dgvPagamento.AllowUserToResizeRows = false;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PAG,
            this.VALOR,
            this.TIPO});
            this.dgvPagamento.Location = new System.Drawing.Point(6, 20);
            this.dgvPagamento.MultiSelect = false;
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.RowHeadersVisible = false;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(329, 286);
            this.dgvPagamento.TabIndex = 0;
            this.dgvPagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellContentClick);
            // 
            // PAG
            // 
            this.PAG.HeaderText = "Pag";
            this.PAG.Name = "PAG";
            this.PAG.ReadOnly = true;
            this.PAG.Width = 50;
            // 
            // VALOR
            // 
            dataGridViewCellStyle1.Format = "C";
            this.VALOR.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 125;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "Forma Pag.";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Width = 125;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(174, 178);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 30);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // nudQtdePessoas
            // 
            this.nudQtdePessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdePessoas.Location = new System.Drawing.Point(12, 46);
            this.nudQtdePessoas.Name = "nudQtdePessoas";
            this.nudQtdePessoas.Size = new System.Drawing.Size(48, 22);
            this.nudQtdePessoas.TabIndex = 0;
            this.nudQtdePessoas.ValueChanged += new System.EventHandler(this.nudQtdePessoas_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qtde Pessoas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(131, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Individual";
            // 
            // lblValorIndividual
            // 
            this.lblValorIndividual.AutoSize = true;
            this.lblValorIndividual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValorIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIndividual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblValorIndividual.Location = new System.Drawing.Point(131, 51);
            this.lblValorIndividual.Name = "lblValorIndividual";
            this.lblValorIndividual.Size = new System.Drawing.Size(59, 16);
            this.lblValorIndividual.TabIndex = 7;
            this.lblValorIndividual.Text = "R$ 0,00";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(30, 40);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(52, 16);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor:";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagamento.Location = new System.Drawing.Point(45, 105);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(92, 22);
            this.txtValorPagamento.TabIndex = 1;
            this.txtValorPagamento.TextChanged += new System.EventHandler(this.txtValorPagamento_TextChanged);
            this.txtValorPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagamento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "R$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Troco";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(82, 146);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(72, 20);
            this.lblTroco.TabIndex = 23;
            this.lblTroco.Text = "R$ 0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "DataAtual";
            // 
            // dtpPagam
            // 
            this.dtpPagam.Enabled = false;
            this.dtpPagam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagam.Location = new System.Drawing.Point(548, 20);
            this.dtpPagam.Name = "dtpPagam";
            this.dtpPagam.Size = new System.Drawing.Size(83, 20);
            this.dtpPagam.TabIndex = 20;
            // 
            // cbxForma
            // 
            this.cbxForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxForma.FormattingEnabled = true;
            this.cbxForma.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque",
            "Cartão"});
            this.cbxForma.Location = new System.Drawing.Point(143, 105);
            this.cbxForma.Name = "cbxForma";
            this.cbxForma.Size = new System.Drawing.Size(114, 21);
            this.cbxForma.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Forma:";
            // 
            // txtMesa
            // 
            this.txtMesa.Enabled = false;
            this.txtMesa.Location = new System.Drawing.Point(173, 42);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.ReadOnly = true;
            this.txtMesa.Size = new System.Drawing.Size(49, 20);
            this.txtMesa.TabIndex = 16;
            this.txtMesa.Text = "0";
            this.txtMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mesa";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Enabled = false;
            this.txtCodPedido.Location = new System.Drawing.Point(38, 42);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(75, 20);
            this.txtCodPedido.TabIndex = 14;
            this.txtCodPedido.Text = "0";
            this.txtCodPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pedido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(10, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFalta);
            this.groupBox2.Controls.Add(this.lblTotalPago);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnFinalizar);
            this.groupBox2.Controls.Add(this.dgvPagamento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(288, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 362);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Location = new System.Drawing.Point(67, 337);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(113, 15);
            this.lblFalta.TabIndex = 15;
            this.lblFalta.Text = "Falta:            R$0,00";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(67, 314);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(112, 15);
            this.lblTotalPago.TabIndex = 14;
            this.lblTotalPago.Text = "Total Pago: R$0,00";
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Location = new System.Drawing.Point(7, 322);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(54, 30);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.Location = new System.Drawing.Point(252, 322);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(84, 30);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblJapago);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblValorTotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 75);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Já Pago";
            // 
            // lblJapago
            // 
            this.lblJapago.AutoSize = true;
            this.lblJapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJapago.Location = new System.Drawing.Point(151, 40);
            this.lblJapago.Name = "lblJapago";
            this.lblJapago.Size = new System.Drawing.Size(52, 16);
            this.lblJapago.TabIndex = 10;
            this.lblJapago.Text = "R$ 0,00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtCodPedido);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMesa);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 79);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblValorIndividual);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.nudQtdePessoas);
            this.groupBox5.Controls.Add(this.lblTroco);
            this.groupBox5.Controls.Add(this.cbxForma);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtValorPagamento);
            this.groupBox5.Controls.Add(this.btnRegistrar);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 222);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pagamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(125, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 59);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frm_recebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 415);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpPagam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_recebimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Pagamento";
            this.Load += new System.EventHandler(this.frm_recebimento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_recebimento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdePessoas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.NumericUpDown nudQtdePessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorIndividual;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxForma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPagam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblJapago;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}