namespace ControleCofre
{
    partial class frmContaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaPagar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabContaPagar = new System.Windows.Forms.TabPage();
            this.gbxEndCli = new System.Windows.Forms.GroupBox();
            this.dtpDatVenc = new System.Windows.Forms.DateTimePicker();
            this.lblDatVencimento = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCentroCusto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTitulo = new System.Windows.Forms.TextBox();
            this.lblValorTitulo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbxDadosCli = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCNPJ_CPF = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClassificar = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodContaPagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDatContaPagar = new System.Windows.Forms.DateTimePicker();
            this.tbgCadCli = new System.Windows.Forms.TabControl();
            this.panel2.SuspendLayout();
            this.tabContaPagar.SuspendLayout();
            this.gbxEndCli.SuspendLayout();
            this.gbxDadosCli.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbgCadCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnRecibo);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(-2, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 33);
            this.panel2.TabIndex = 9;
            // 
            // btnRecibo
            // 
            this.btnRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibo.Location = new System.Drawing.Point(12, 6);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnRecibo.TabIndex = 19;
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(371, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(450, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabContaPagar
            // 
            this.tabContaPagar.BackColor = System.Drawing.Color.LightGray;
            this.tabContaPagar.Controls.Add(this.gbxEndCli);
            this.tabContaPagar.Controls.Add(this.gbxDadosCli);
            this.tabContaPagar.Controls.Add(this.panel1);
            this.tabContaPagar.Location = new System.Drawing.Point(4, 22);
            this.tabContaPagar.Name = "tabContaPagar";
            this.tabContaPagar.Padding = new System.Windows.Forms.Padding(3);
            this.tabContaPagar.Size = new System.Drawing.Size(529, 362);
            this.tabContaPagar.TabIndex = 0;
            this.tabContaPagar.Text = "Contas a Pagar";
            // 
            // gbxEndCli
            // 
            this.gbxEndCli.BackColor = System.Drawing.Color.LightGray;
            this.gbxEndCli.Controls.Add(this.dtpDatVenc);
            this.gbxEndCli.Controls.Add(this.lblDatVencimento);
            this.gbxEndCli.Controls.Add(this.txtObservacao);
            this.gbxEndCli.Controls.Add(this.txtNF);
            this.gbxEndCli.Controls.Add(this.label5);
            this.gbxEndCli.Controls.Add(this.cbxCentroCusto);
            this.gbxEndCli.Controls.Add(this.label4);
            this.gbxEndCli.Controls.Add(this.lblObservacao);
            this.gbxEndCli.Controls.Add(this.label2);
            this.gbxEndCli.Controls.Add(this.txtValorTitulo);
            this.gbxEndCli.Controls.Add(this.lblValorTitulo);
            this.gbxEndCli.Controls.Add(this.txtDescricao);
            this.gbxEndCli.Location = new System.Drawing.Point(6, 164);
            this.gbxEndCli.Name = "gbxEndCli";
            this.gbxEndCli.Size = new System.Drawing.Size(515, 189);
            this.gbxEndCli.TabIndex = 6;
            this.gbxEndCli.TabStop = false;
            this.gbxEndCli.Text = "Lançamentos";
            // 
            // dtpDatVenc
            // 
            this.dtpDatVenc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatVenc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDatVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatVenc.Location = new System.Drawing.Point(361, 80);
            this.dtpDatVenc.Name = "dtpDatVenc";
            this.dtpDatVenc.Size = new System.Drawing.Size(137, 30);
            this.dtpDatVenc.TabIndex = 13;
            this.dtpDatVenc.Value = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            // 
            // lblDatVencimento
            // 
            this.lblDatVencimento.AutoSize = true;
            this.lblDatVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatVencimento.Location = new System.Drawing.Point(201, 81);
            this.lblDatVencimento.Name = "lblDatVencimento";
            this.lblDatVencimento.Size = new System.Drawing.Size(164, 24);
            this.lblDatVencimento.TabIndex = 33;
            this.lblDatVencimento.Text = "Data Vencimento :";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Location = new System.Drawing.Point(68, 122);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(431, 57);
            this.txtObservacao.TabIndex = 14;
            // 
            // txtNF
            // 
            this.txtNF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNF.Location = new System.Drawing.Point(69, 49);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(112, 20);
            this.txtNF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nº NFe:";
            // 
            // cbxCentroCusto
            // 
            this.cbxCentroCusto.FormattingEnabled = true;
            this.cbxCentroCusto.Location = new System.Drawing.Point(288, 48);
            this.cbxCentroCusto.Name = "cbxCentroCusto";
            this.cbxCentroCusto.Size = new System.Drawing.Size(210, 21);
            this.cbxCentroCusto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Centro de Custo:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(36, 125);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(29, 13);
            this.lblObservacao.TabIndex = 28;
            this.lblObservacao.Text = "Obs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descrição:";
            // 
            // txtValorTitulo
            // 
            this.txtValorTitulo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtValorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValorTitulo.Location = new System.Drawing.Point(70, 80);
            this.txtValorTitulo.Name = "txtValorTitulo";
            this.txtValorTitulo.Size = new System.Drawing.Size(111, 30);
            this.txtValorTitulo.TabIndex = 12;
            // 
            // lblValorTitulo
            // 
            this.lblValorTitulo.AutoSize = true;
            this.lblValorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblValorTitulo.Location = new System.Drawing.Point(5, 89);
            this.lblValorTitulo.Name = "lblValorTitulo";
            this.lblValorTitulo.Size = new System.Drawing.Size(63, 13);
            this.lblValorTitulo.TabIndex = 5;
            this.lblValorTitulo.Text = "Valor Titulo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(69, 19);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(430, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // gbxDadosCli
            // 
            this.gbxDadosCli.BackColor = System.Drawing.Color.LightGray;
            this.gbxDadosCli.Controls.Add(this.btnSelecionar);
            this.gbxDadosCli.Controls.Add(this.txtCel);
            this.gbxDadosCli.Controls.Add(this.label1);
            this.gbxDadosCli.Controls.Add(this.txtCNPJ_CPF);
            this.gbxDadosCli.Controls.Add(this.lblRG);
            this.gbxDadosCli.Controls.Add(this.txtRG);
            this.gbxDadosCli.Controls.Add(this.txtTelefone);
            this.gbxDadosCli.Controls.Add(this.lblCPF_CNPJ);
            this.gbxDadosCli.Controls.Add(this.label10);
            this.gbxDadosCli.Controls.Add(this.lblNome);
            this.gbxDadosCli.Controls.Add(this.txtNomeCli);
            this.gbxDadosCli.Location = new System.Drawing.Point(7, 42);
            this.gbxDadosCli.Name = "gbxDadosCli";
            this.gbxDadosCli.Size = new System.Drawing.Size(514, 116);
            this.gbxDadosCli.TabIndex = 5;
            this.gbxDadosCli.TabStop = false;
            this.gbxDadosCli.Text = "Dados Clientes";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionar.Location = new System.Drawing.Point(426, 17);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 20;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(319, 81);
            this.txtCel.Mask = "(00) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(180, 20);
            this.txtCel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cel:";
            // 
            // txtCNPJ_CPF
            // 
            this.txtCNPJ_CPF.Location = new System.Drawing.Point(69, 47);
            this.txtCNPJ_CPF.Name = "txtCNPJ_CPF";
            this.txtCNPJ_CPF.Size = new System.Drawing.Size(192, 20);
            this.txtCNPJ_CPF.TabIndex = 5;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(277, 54);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(41, 13);
            this.lblRG.TabIndex = 12;
            this.lblRG.Text = "RG/IE:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(319, 50);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(182, 20);
            this.txtRG.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(69, 78);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(192, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(4, 51);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(62, 13);
            this.lblCPF_CNPJ.TabIndex = 5;
            this.lblCPF_CNPJ.Text = "CPF/CNPJ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tel:";
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
            this.txtNomeCli.Size = new System.Drawing.Size(354, 20);
            this.txtNomeCli.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbClassificar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtCodContaPagar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpDatContaPagar);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 33);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(297, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Classificar Empresa:";
            // 
            // cbClassificar
            // 
            this.cbClassificar.FormattingEnabled = true;
            this.cbClassificar.Items.AddRange(new object[] {
            "ANGASIL",
            "GRANOBELLO",
            "SILO"});
            this.cbClassificar.Location = new System.Drawing.Point(401, 6);
            this.cbClassificar.Name = "cbClassificar";
            this.cbClassificar.Size = new System.Drawing.Size(121, 21);
            this.cbClassificar.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(121, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Data:";
            // 
            // txtCodContaPagar
            // 
            this.txtCodContaPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodContaPagar.Location = new System.Drawing.Point(41, 6);
            this.txtCodContaPagar.Name = "txtCodContaPagar";
            this.txtCodContaPagar.Size = new System.Drawing.Size(72, 20);
            this.txtCodContaPagar.TabIndex = 1;
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
            // dtpDatContaPagar
            // 
            this.dtpDatContaPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatContaPagar.Location = new System.Drawing.Point(160, 6);
            this.dtpDatContaPagar.Name = "dtpDatContaPagar";
            this.dtpDatContaPagar.Size = new System.Drawing.Size(84, 20);
            this.dtpDatContaPagar.TabIndex = 2;
            this.dtpDatContaPagar.Value = new System.DateTime(2018, 10, 23, 0, 0, 0, 0);
            // 
            // tbgCadCli
            // 
            this.tbgCadCli.Controls.Add(this.tabContaPagar);
            this.tbgCadCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbgCadCli.Location = new System.Drawing.Point(0, 0);
            this.tbgCadCli.Name = "tbgCadCli";
            this.tbgCadCli.SelectedIndex = 0;
            this.tbgCadCli.Size = new System.Drawing.Size(537, 388);
            this.tbgCadCli.TabIndex = 10;
            this.tbgCadCli.Tag = "";
            // 
            // frmContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 420);
            this.Controls.Add(this.tbgCadCli);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Contas a Pagar";
            this.Load += new System.EventHandler(this.frmContaPagar_Load);
            this.panel2.ResumeLayout(false);
            this.tabContaPagar.ResumeLayout(false);
            this.gbxEndCli.ResumeLayout(false);
            this.gbxEndCli.PerformLayout();
            this.gbxDadosCli.ResumeLayout(false);
            this.gbxDadosCli.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbgCadCli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabPage tabContaPagar;
        private System.Windows.Forms.GroupBox gbxEndCli;
        private System.Windows.Forms.Label lblDatVencimento;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCentroCusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTitulo;
        private System.Windows.Forms.Label lblValorTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gbxDadosCli;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNPJ_CPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClassificar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodContaPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDatContaPagar;
        private System.Windows.Forms.TabControl tbgCadCli;
        private System.Windows.Forms.DateTimePicker dtpDatVenc;
    }
}