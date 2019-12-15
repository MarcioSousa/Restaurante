namespace Apresentacao
{
    partial class Frm_AbreFechaCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AbreFechaCaixa));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtValorAbertura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LblTotalVenda = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.LblTroco = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblTotalPagamento = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LblTotalDinheiro = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.LblTotalCartao = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.LblTotalCheque = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TxtTotalFechamento = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TxtTotalFaturado = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSalvar);
            this.groupBox3.Controls.Add(this.TxtValorAbertura);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abertura de Caixa";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.AutoSize = true;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(81, 74);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(72, 26);
            this.BtnSalvar.TabIndex = 22;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtValorAbertura
            // 
            this.TxtValorAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorAbertura.Location = new System.Drawing.Point(46, 39);
            this.TxtValorAbertura.Name = "TxtValorAbertura";
            this.TxtValorAbertura.Size = new System.Drawing.Size(94, 26);
            this.TxtValorAbertura.TabIndex = 21;
            this.TxtValorAbertura.Text = "0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "R$";
            // 
            // DtpData
            // 
            this.DtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(9, 43);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(107, 22);
            this.DtpData.TabIndex = 3;
            this.DtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = true;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(12, 268);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(160, 34);
            this.BtnFechar.TabIndex = 24;
            this.BtnFechar.Text = "Fechar/Cancelar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.AutoSize = true;
            this.BtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizar.Location = new System.Drawing.Point(556, 268);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(146, 34);
            this.BtnFinalizar.TabIndex = 23;
            this.BtnFinalizar.Text = "Finalizar/Salvar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 29);
            this.label17.TabIndex = 21;
            this.label17.Text = "Total:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LblTotalVenda);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.LblTroco);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.LblTotalPagamento);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.DtpData);
            this.groupBox5.Location = new System.Drawing.Point(178, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 121);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resumo";
            // 
            // LblTotalVenda
            // 
            this.LblTotalVenda.AutoSize = true;
            this.LblTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVenda.Location = new System.Drawing.Point(136, 95);
            this.LblTotalVenda.Name = "LblTotalVenda";
            this.LblTotalVenda.Size = new System.Drawing.Size(55, 16);
            this.LblTotalVenda.TabIndex = 28;
            this.LblTotalVenda.Text = "R$0,00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(136, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 16);
            this.label24.TabIndex = 27;
            this.label24.Text = "Total Venda";
            // 
            // LblTroco
            // 
            this.LblTroco.AutoSize = true;
            this.LblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTroco.Location = new System.Drawing.Point(9, 95);
            this.LblTroco.Name = "LblTroco";
            this.LblTroco.Size = new System.Drawing.Size(55, 16);
            this.LblTroco.TabIndex = 26;
            this.LblTroco.Text = "R$0,00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 16);
            this.label22.TabIndex = 25;
            this.label22.Text = "Troco";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Dia de Venda";
            // 
            // LblTotalPagamento
            // 
            this.LblTotalPagamento.AutoSize = true;
            this.LblTotalPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagamento.Location = new System.Drawing.Point(136, 45);
            this.LblTotalPagamento.Name = "LblTotalPagamento";
            this.LblTotalPagamento.Size = new System.Drawing.Size(55, 16);
            this.LblTotalPagamento.TabIndex = 23;
            this.LblTotalPagamento.Text = "R$0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Total Pagamentos";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.Location = new System.Drawing.Point(9, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(693, 13);
            this.label18.TabIndex = 5;
            // 
            // LblTotalDinheiro
            // 
            this.LblTotalDinheiro.AutoSize = true;
            this.LblTotalDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDinheiro.Location = new System.Drawing.Point(6, 40);
            this.LblTotalDinheiro.Name = "LblTotalDinheiro";
            this.LblTotalDinheiro.Size = new System.Drawing.Size(55, 16);
            this.LblTotalDinheiro.TabIndex = 30;
            this.LblTotalDinheiro.Text = "R$0,00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 16);
            this.label23.TabIndex = 29;
            this.label23.Text = "Total Dinheiro";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnExcluir);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.LblTotalCartao);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.LblTotalCheque);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.LblTotalDinheiro);
            this.groupBox6.Location = new System.Drawing.Point(456, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 120);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Formas de Pagamento";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(167, 87);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(72, 26);
            this.BtnExcluir.TabIndex = 35;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 16);
            this.label27.TabIndex = 33;
            this.label27.Text = "Total Cartão";
            // 
            // LblTotalCartao
            // 
            this.LblTotalCartao.AutoSize = true;
            this.LblTotalCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCartao.Location = new System.Drawing.Point(9, 92);
            this.LblTotalCartao.Name = "LblTotalCartao";
            this.LblTotalCartao.Size = new System.Drawing.Size(55, 16);
            this.LblTotalCartao.TabIndex = 34;
            this.LblTotalCartao.Text = "R$0,00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(150, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 16);
            this.label25.TabIndex = 31;
            this.label25.Text = "Total Cheque";
            // 
            // LblTotalCheque
            // 
            this.LblTotalCheque.AutoSize = true;
            this.LblTotalCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCheque.Location = new System.Drawing.Point(150, 40);
            this.LblTotalCheque.Name = "LblTotalCheque";
            this.LblTotalCheque.Size = new System.Drawing.Size(55, 16);
            this.LblTotalCheque.TabIndex = 32;
            this.LblTotalCheque.Text = "R$0,00";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.TxtTotalFechamento);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(12, 162);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(338, 100);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fechamento de Caixa";
            // 
            // TxtTotalFechamento
            // 
            this.TxtTotalFechamento.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.TxtTotalFechamento.Location = new System.Drawing.Point(121, 34);
            this.TxtTotalFechamento.Name = "TxtTotalFechamento";
            this.TxtTotalFechamento.Size = new System.Drawing.Size(192, 37);
            this.TxtTotalFechamento.TabIndex = 31;
            this.TxtTotalFechamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TxtTotalFaturado);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Location = new System.Drawing.Point(356, 162);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(346, 100);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Faturamento";
            // 
            // TxtTotalFaturado
            // 
            this.TxtTotalFaturado.Enabled = false;
            this.TxtTotalFaturado.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.TxtTotalFaturado.Location = new System.Drawing.Point(121, 34);
            this.TxtTotalFaturado.Name = "TxtTotalFaturado";
            this.TxtTotalFaturado.ReadOnly = true;
            this.TxtTotalFaturado.Size = new System.Drawing.Size(192, 37);
            this.TxtTotalFaturado.TabIndex = 31;
            this.TxtTotalFaturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 29);
            this.label21.TabIndex = 21;
            this.label21.Text = "Total:";
            // 
            // Frm_AbreFechaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 318);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AbreFechaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura e Fechamento de Caixa";
            this.Load += new System.EventHandler(this.Frm_AbreFechaCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_AbreFechaCaixa_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtValorAbertura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblTotalPagamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblTotalVenda;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label LblTroco;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LblTotalDinheiro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label LblTotalCartao;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label LblTotalCheque;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox TxtTotalFechamento;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TxtTotalFaturado;
        private System.Windows.Forms.Label label21;
    }
}