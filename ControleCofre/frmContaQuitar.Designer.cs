namespace ControleCofre
{
    partial class frmContaQuitar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaQuitar));
            this.tbgCadCli = new System.Windows.Forms.TabControl();
            this.tabQuitarConta = new System.Windows.Forms.TabPage();
            this.gbxEndCli = new System.Windows.Forms.GroupBox();
            this.txtNumeroCheque = new System.Windows.Forms.TextBox();
            this.lblNumeroCheque = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPgto = new System.Windows.Forms.ComboBox();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.gbxDadosCli = new System.Windows.Forms.GroupBox();
            this.dtpDatVenc = new System.Windows.Forms.DateTimePicker();
            this.lblDatVencimento = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCentroCusto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.lblValorTitulo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.txtCodContaPagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDatPagamento = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbgCadCli.SuspendLayout();
            this.tabQuitarConta.SuspendLayout();
            this.gbxEndCli.SuspendLayout();
            this.gbxDadosCli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbgCadCli
            // 
            this.tbgCadCli.Controls.Add(this.tabQuitarConta);
            this.tbgCadCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbgCadCli.Location = new System.Drawing.Point(0, 0);
            this.tbgCadCli.Name = "tbgCadCli";
            this.tbgCadCli.SelectedIndex = 0;
            this.tbgCadCli.Size = new System.Drawing.Size(535, 464);
            this.tbgCadCli.TabIndex = 11;
            this.tbgCadCli.Tag = "";
            // 
            // tabQuitarConta
            // 
            this.tabQuitarConta.BackColor = System.Drawing.Color.LightGray;
            this.tabQuitarConta.Controls.Add(this.gbxEndCli);
            this.tabQuitarConta.Controls.Add(this.gbxDadosCli);
            this.tabQuitarConta.Controls.Add(this.panel1);
            this.tabQuitarConta.Location = new System.Drawing.Point(4, 22);
            this.tabQuitarConta.Name = "tabQuitarConta";
            this.tabQuitarConta.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuitarConta.Size = new System.Drawing.Size(527, 438);
            this.tabQuitarConta.TabIndex = 0;
            this.tabQuitarConta.Text = "Quitando Conta";
            // 
            // gbxEndCli
            // 
            this.gbxEndCli.BackColor = System.Drawing.Color.LightGray;
            this.gbxEndCli.Controls.Add(this.txtNumeroCheque);
            this.gbxEndCli.Controls.Add(this.lblNumeroCheque);
            this.gbxEndCli.Controls.Add(this.textBox4);
            this.gbxEndCli.Controls.Add(this.label8);
            this.gbxEndCli.Controls.Add(this.txtDesconto);
            this.gbxEndCli.Controls.Add(this.label7);
            this.gbxEndCli.Controls.Add(this.txtValorPago);
            this.gbxEndCli.Controls.Add(this.label6);
            this.gbxEndCli.Controls.Add(this.txtJuros);
            this.gbxEndCli.Controls.Add(this.label1);
            this.gbxEndCli.Controls.Add(this.cmbFormaPgto);
            this.gbxEndCli.Controls.Add(this.lblFormaPgto);
            this.gbxEndCli.Controls.Add(this.txtObservacao);
            this.gbxEndCli.Controls.Add(this.lblObservacao);
            this.gbxEndCli.Location = new System.Drawing.Point(6, 198);
            this.gbxEndCli.Name = "gbxEndCli";
            this.gbxEndCli.Size = new System.Drawing.Size(515, 236);
            this.gbxEndCli.TabIndex = 0;
            this.gbxEndCli.TabStop = false;
            this.gbxEndCli.Text = "Pagando Contas";
            // 
            // txtNumeroCheque
            // 
            this.txtNumeroCheque.Location = new System.Drawing.Point(402, 17);
            this.txtNumeroCheque.Name = "txtNumeroCheque";
            this.txtNumeroCheque.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCheque.TabIndex = 2;
            // 
            // lblNumeroCheque
            // 
            this.lblNumeroCheque.AutoSize = true;
            this.lblNumeroCheque.Location = new System.Drawing.Point(339, 21);
            this.lblNumeroCheque.Name = "lblNumeroCheque";
            this.lblNumeroCheque.Size = new System.Drawing.Size(65, 13);
            this.lblNumeroCheque.TabIndex = 48;
            this.lblNumeroCheque.Text = "Nº Cheque: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Valor Restante: ";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(108, 73);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Descontos: ";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorPago.Location = new System.Drawing.Point(108, 99);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Valor Pago: ";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(108, 47);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(100, 20);
            this.txtJuros.TabIndex = 3;
            this.txtJuros.Text = "0";
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Acresc. / Juros: ";
            // 
            // cmbFormaPgto
            // 
            this.cmbFormaPgto.FormattingEnabled = true;
            this.cmbFormaPgto.Items.AddRange(new object[] {
            "Caixa",
            "Internet",
            "Cheque"});
            this.cmbFormaPgto.Location = new System.Drawing.Point(108, 17);
            this.cmbFormaPgto.Name = "cmbFormaPgto";
            this.cmbFormaPgto.Size = new System.Drawing.Size(170, 21);
            this.cmbFormaPgto.TabIndex = 1;
            this.cmbFormaPgto.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPgto_SelectedIndexChanged);
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(10, 21);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(96, 13);
            this.lblFormaPgto.TabIndex = 33;
            this.lblFormaPgto.Text = "Forma Pagamento:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(41, 171);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ReadOnly = true;
            this.txtObservacao.Size = new System.Drawing.Size(459, 57);
            this.txtObservacao.TabIndex = 7;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(11, 170);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(29, 13);
            this.lblObservacao.TabIndex = 28;
            this.lblObservacao.Text = "Obs:";
            // 
            // gbxDadosCli
            // 
            this.gbxDadosCli.BackColor = System.Drawing.Color.Silver;
            this.gbxDadosCli.Controls.Add(this.dtpDatVenc);
            this.gbxDadosCli.Controls.Add(this.lblDatVencimento);
            this.gbxDadosCli.Controls.Add(this.txtNF);
            this.gbxDadosCli.Controls.Add(this.label5);
            this.gbxDadosCli.Controls.Add(this.cbxCentroCusto);
            this.gbxDadosCli.Controls.Add(this.label4);
            this.gbxDadosCli.Controls.Add(this.label2);
            this.gbxDadosCli.Controls.Add(this.txtValorTitulo);
            this.gbxDadosCli.Controls.Add(this.lblValorTitulo);
            this.gbxDadosCli.Controls.Add(this.txtDescricao);
            this.gbxDadosCli.Controls.Add(this.lblNome);
            this.gbxDadosCli.Controls.Add(this.txtNomeCli);
            this.gbxDadosCli.Location = new System.Drawing.Point(6, 42);
            this.gbxDadosCli.Name = "gbxDadosCli";
            this.gbxDadosCli.Size = new System.Drawing.Size(515, 150);
            this.gbxDadosCli.TabIndex = 5;
            this.gbxDadosCli.TabStop = false;
            this.gbxDadosCli.Text = "Dados  do Fornecedor";
            // 
            // dtpDatVenc
            // 
            this.dtpDatVenc.Enabled = false;
            this.dtpDatVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatVenc.Location = new System.Drawing.Point(289, 109);
            this.dtpDatVenc.Name = "dtpDatVenc";
            this.dtpDatVenc.Size = new System.Drawing.Size(84, 20);
            this.dtpDatVenc.TabIndex = 17;
            this.dtpDatVenc.Value = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            // 
            // lblDatVencimento
            // 
            this.lblDatVencimento.AutoSize = true;
            this.lblDatVencimento.Location = new System.Drawing.Point(194, 112);
            this.lblDatVencimento.Name = "lblDatVencimento";
            this.lblDatVencimento.Size = new System.Drawing.Size(95, 13);
            this.lblDatVencimento.TabIndex = 43;
            this.lblDatVencimento.Text = "Data Vencimento :";
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(70, 78);
            this.txtNF.Name = "txtNF";
            this.txtNF.ReadOnly = true;
            this.txtNF.Size = new System.Drawing.Size(112, 20);
            this.txtNF.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nº NFe:";
            // 
            // cbxCentroCusto
            // 
            this.cbxCentroCusto.Enabled = false;
            this.cbxCentroCusto.FormattingEnabled = true;
            this.cbxCentroCusto.Location = new System.Drawing.Point(289, 77);
            this.cbxCentroCusto.Name = "cbxCentroCusto";
            this.cbxCentroCusto.Size = new System.Drawing.Size(210, 21);
            this.cbxCentroCusto.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Centro de Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descrição:";
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.Location = new System.Drawing.Point(69, 109);
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.ReadOnly = true;
            this.txtValorTitulo.Size = new System.Drawing.Size(112, 20);
            this.txtValorTitulo.TabIndex = 16;
            // 
            // lblValorTitulo
            // 
            this.lblValorTitulo.AutoSize = true;
            this.lblValorTitulo.Location = new System.Drawing.Point(5, 113);
            this.lblValorTitulo.Name = "lblValorTitulo";
            this.lblValorTitulo.Size = new System.Drawing.Size(63, 13);
            this.lblValorTitulo.TabIndex = 35;
            this.lblValorTitulo.Text = "Valor Titulo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(70, 48);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(430, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCli.Location = new System.Drawing.Point(69, 19);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(432, 20);
            this.txtNomeCli.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblDataPagamento);
            this.panel1.Controls.Add(this.txtCodContaPagar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpDatPagamento);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 33);
            this.panel1.TabIndex = 4;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDataPagamento.Location = new System.Drawing.Point(330, 9);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(105, 13);
            this.lblDataPagamento.TabIndex = 12;
            this.lblDataPagamento.Text = "Data do Pagamento:";
            // 
            // txtCodContaPagar
            // 
            this.txtCodContaPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodContaPagar.Location = new System.Drawing.Point(42, 6);
            this.txtCodContaPagar.Name = "txtCodContaPagar";
            this.txtCodContaPagar.ReadOnly = true;
            this.txtCodContaPagar.Size = new System.Drawing.Size(72, 20);
            this.txtCodContaPagar.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(10, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cód.:";
            // 
            // dtpDatPagamento
            // 
            this.dtpDatPagamento.Enabled = false;
            this.dtpDatPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatPagamento.Location = new System.Drawing.Point(438, 6);
            this.dtpDatPagamento.Name = "dtpDatPagamento";
            this.dtpDatPagamento.Size = new System.Drawing.Size(84, 20);
            this.dtpDatPagamento.TabIndex = 11;
            this.dtpDatPagamento.Value = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(-2, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 39);
            this.panel2.TabIndex = 12;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(373, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(452, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmContaQuitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbgCadCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContaQuitar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagando Contas";
            this.Load += new System.EventHandler(this.frmContaQuitar_Load);
            this.tbgCadCli.ResumeLayout(false);
            this.tabQuitarConta.ResumeLayout(false);
            this.gbxEndCli.ResumeLayout(false);
            this.gbxEndCli.PerformLayout();
            this.gbxDadosCli.ResumeLayout(false);
            this.gbxDadosCli.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbgCadCli;
        private System.Windows.Forms.TabPage tabQuitarConta;
        private System.Windows.Forms.GroupBox gbxEndCli;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.GroupBox gbxDadosCli;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.TextBox txtCodContaPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDatPagamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpDatVenc;
        private System.Windows.Forms.Label lblDatVencimento;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCentroCusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.Label lblValorTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNumeroCheque;
        private System.Windows.Forms.Label lblNumeroCheque;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormaPgto;
        private System.Windows.Forms.Label lblFormaPgto;
    }
}