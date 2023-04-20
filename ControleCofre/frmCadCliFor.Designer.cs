namespace ControleCofre
{
    partial class frmCadCliFor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliFor));
            this.tabClienteFor = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.lblLocalizarNome = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.dgvCadCliFor = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDadosCli = new System.Windows.Forms.GroupBox();
            this.cbxPfpj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCNPJ_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInserirUsuario = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.btnAlteraUsuario = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Cod_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dat_Cadastros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.cbxAtivo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mkbEmail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisaNomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatUsuario = new System.Windows.Forms.DateTimePicker();
            this.tabClienteFor.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadCliFor)).BeginInit();
            this.gbxDadosCli.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClienteFor
            // 
            this.tabClienteFor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabClienteFor.Controls.Add(this.tabCliente);
            this.tabClienteFor.Controls.Add(this.tabUsuario);
            this.tabClienteFor.Location = new System.Drawing.Point(-4, 1);
            this.tabClienteFor.Name = "tabClienteFor";
            this.tabClienteFor.SelectedIndex = 0;
            this.tabClienteFor.Size = new System.Drawing.Size(545, 429);
            this.tabClienteFor.TabIndex = 7;
            this.tabClienteFor.SelectedIndexChanged += new System.EventHandler(this.tabClienteFor_SelectedIndexChanged);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.panel2);
            this.tabCliente.Controls.Add(this.panel1);
            this.tabCliente.Controls.Add(this.dgvCadCliFor);
            this.tabCliente.Controls.Add(this.gbxDadosCli);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(537, 403);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente / Fornecedor";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnInserir);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 31);
            this.panel2.TabIndex = 9;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(382, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(257, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(60, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(371, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(319, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 23);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtLocalizar);
            this.panel1.Controls.Add(this.lblLocalizarNome);
            this.panel1.Controls.Add(this.txtCodCli);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dtpDataCad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 36);
            this.panel1.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(101, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Data:";
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizar.Location = new System.Drawing.Point(274, 7);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(246, 20);
            this.txtLocalizar.TabIndex = 1;
            this.txtLocalizar.TabStop = false;
            this.txtLocalizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalizar_KeyDown_1);
            // 
            // lblLocalizarNome
            // 
            this.lblLocalizarNome.AutoSize = true;
            this.lblLocalizarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizarNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocalizarNome.Location = new System.Drawing.Point(230, 11);
            this.lblLocalizarNome.Name = "lblLocalizarNome";
            this.lblLocalizarNome.Size = new System.Drawing.Size(43, 13);
            this.lblLocalizarNome.TabIndex = 18;
            this.lblLocalizarNome.Text = "Nome:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodCli.Location = new System.Drawing.Point(39, 8);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ReadOnly = true;
            this.txtCodCli.Size = new System.Drawing.Size(53, 20);
            this.txtCodCli.TabIndex = 1;
            this.txtCodCli.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(10, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cód:";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Enabled = false;
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(135, 7);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(84, 20);
            this.dtpDataCad.TabIndex = 2;
            this.dtpDataCad.TabStop = false;
            // 
            // dgvCadCliFor
            // 
            this.dgvCadCliFor.AllowUserToAddRows = false;
            this.dgvCadCliFor.AllowUserToDeleteRows = false;
            this.dgvCadCliFor.AllowUserToResizeColumns = false;
            this.dgvCadCliFor.AllowUserToResizeRows = false;
            this.dgvCadCliFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCadCliFor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCadCliFor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCadCliFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadCliFor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Dat_Cadastro,
            this.Nome_Cli,
            this.Telefone,
            this.Celular,
            this.CPF,
            this.RG});
            this.dgvCadCliFor.Location = new System.Drawing.Point(5, 174);
            this.dgvCadCliFor.MultiSelect = false;
            this.dgvCadCliFor.Name = "dgvCadCliFor";
            this.dgvCadCliFor.ReadOnly = true;
            this.dgvCadCliFor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCadCliFor.RowHeadersVisible = false;
            this.dgvCadCliFor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadCliFor.Size = new System.Drawing.Size(527, 191);
            this.dgvCadCliFor.TabIndex = 7;
            this.dgvCadCliFor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadCliFor_CellClick_1);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cod_cli";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Dat_Cadastro
            // 
            this.Dat_Cadastro.DataPropertyName = "Dat_Cadastro";
            this.Dat_Cadastro.HeaderText = "Data Cadastro";
            this.Dat_Cadastro.Name = "Dat_Cadastro";
            this.Dat_Cadastro.ReadOnly = true;
            this.Dat_Cadastro.Width = 120;
            // 
            // Nome_Cli
            // 
            this.Nome_Cli.DataPropertyName = "Nome_Cli";
            this.Nome_Cli.HeaderText = "Nome";
            this.Nome_Cli.Name = "Nome_Cli";
            this.Nome_Cli.ReadOnly = true;
            this.Nome_Cli.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Visible = false;
            this.Telefone.Width = 140;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 140;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Visible = false;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Visible = false;
            // 
            // gbxDadosCli
            // 
            this.gbxDadosCli.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDadosCli.Controls.Add(this.cbxPfpj);
            this.gbxDadosCli.Controls.Add(this.label2);
            this.gbxDadosCli.Controls.Add(this.txtCNPJ_CPF);
            this.gbxDadosCli.Controls.Add(this.txtCel);
            this.gbxDadosCli.Controls.Add(this.label1);
            this.gbxDadosCli.Controls.Add(this.lblRG);
            this.gbxDadosCli.Controls.Add(this.txtRG);
            this.gbxDadosCli.Controls.Add(this.txtTelefone);
            this.gbxDadosCli.Controls.Add(this.lblCPF_CNPJ);
            this.gbxDadosCli.Controls.Add(this.label10);
            this.gbxDadosCli.Controls.Add(this.lblNome);
            this.gbxDadosCli.Controls.Add(this.txtNomeCli);
            this.gbxDadosCli.Location = new System.Drawing.Point(6, 45);
            this.gbxDadosCli.Name = "gbxDadosCli";
            this.gbxDadosCli.Size = new System.Drawing.Size(526, 126);
            this.gbxDadosCli.TabIndex = 6;
            this.gbxDadosCli.TabStop = false;
            this.gbxDadosCli.Text = "Dados Clientes";
            // 
            // cbxPfpj
            // 
            this.cbxPfpj.Enabled = false;
            this.cbxPfpj.FormattingEnabled = true;
            this.cbxPfpj.Items.AddRange(new object[] {
            "PF",
            "PJ"});
            this.cbxPfpj.Location = new System.Drawing.Point(444, 25);
            this.cbxPfpj.Name = "cbxPfpj";
            this.cbxPfpj.Size = new System.Drawing.Size(57, 21);
            this.cbxPfpj.TabIndex = 3;
            this.cbxPfpj.SelectedIndexChanged += new System.EventHandler(this.cbxPfpj_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo:";
            // 
            // txtCNPJ_CPF
            // 
            this.txtCNPJ_CPF.Location = new System.Drawing.Point(69, 54);
            this.txtCNPJ_CPF.Name = "txtCNPJ_CPF";
            this.txtCNPJ_CPF.ReadOnly = true;
            this.txtCNPJ_CPF.Size = new System.Drawing.Size(192, 20);
            this.txtCNPJ_CPF.TabIndex = 4;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(319, 87);
            this.txtCel.Mask = "(00) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.ReadOnly = true;
            this.txtCel.Size = new System.Drawing.Size(182, 20);
            this.txtCel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cel:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(277, 60);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(41, 13);
            this.lblRG.TabIndex = 12;
            this.lblRG.Text = "RG/IE:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(319, 56);
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = true;
            this.txtRG.Size = new System.Drawing.Size(182, 20);
            this.txtRG.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(69, 84);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(192, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(5, 57);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(62, 13);
            this.lblCPF_CNPJ.TabIndex = 5;
            this.lblCPF_CNPJ.Text = "CPF/CNPJ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tel:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCli.Location = new System.Drawing.Point(69, 25);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(432, 20);
            this.txtNomeCli.TabIndex = 2;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.panel4);
            this.tabUsuario.Controls.Add(this.dgvUsuario);
            this.tabUsuario.Controls.Add(this.groupBox1);
            this.tabUsuario.Controls.Add(this.panel3);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(537, 403);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "Cadastro Usuario";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnInserirUsuario);
            this.panel4.Controls.Add(this.btnSalvarUsuario);
            this.panel4.Controls.Add(this.btnAlteraUsuario);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 31);
            this.panel4.TabIndex = 10;
            // 
            // btnInserirUsuario
            // 
            this.btnInserirUsuario.Location = new System.Drawing.Point(321, 3);
            this.btnInserirUsuario.Name = "btnInserirUsuario";
            this.btnInserirUsuario.Size = new System.Drawing.Size(60, 23);
            this.btnInserirUsuario.TabIndex = 3;
            this.btnInserirUsuario.Text = "Inserir";
            this.btnInserirUsuario.UseVisualStyleBackColor = true;
            this.btnInserirUsuario.Click += new System.EventHandler(this.btnInserirUsuario_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(373, 3);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuario.TabIndex = 7;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Visible = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // btnAlteraUsuario
            // 
            this.btnAlteraUsuario.Location = new System.Drawing.Point(383, 3);
            this.btnAlteraUsuario.Name = "btnAlteraUsuario";
            this.btnAlteraUsuario.Size = new System.Drawing.Size(60, 23);
            this.btnAlteraUsuario.TabIndex = 0;
            this.btnAlteraUsuario.Text = "Alterar";
            this.btnAlteraUsuario.UseVisualStyleBackColor = true;
            this.btnAlteraUsuario.Click += new System.EventHandler(this.btnAlteraUsuario_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(449, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Usuario,
            this.Dat_Cadastros,
            this.Nome_Usuario,
            this.Perfil,
            this.Login,
            this.email,
            this.Ativo,
            this.Senha,
            this.Nome});
            this.dgvUsuario.Location = new System.Drawing.Point(5, 185);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(527, 182);
            this.dgvUsuario.TabIndex = 8;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // Cod_Usuario
            // 
            this.Cod_Usuario.DataPropertyName = "Cod_Usuario";
            this.Cod_Usuario.HeaderText = "Código";
            this.Cod_Usuario.Name = "Cod_Usuario";
            this.Cod_Usuario.ReadOnly = true;
            this.Cod_Usuario.Width = 50;
            // 
            // Dat_Cadastros
            // 
            this.Dat_Cadastros.DataPropertyName = "Dat_Cadastro";
            this.Dat_Cadastros.HeaderText = "Data Cadastro";
            this.Dat_Cadastros.Name = "Dat_Cadastros";
            this.Dat_Cadastros.ReadOnly = true;
            // 
            // Nome_Usuario
            // 
            this.Nome_Usuario.DataPropertyName = "Nome_Usuario";
            this.Nome_Usuario.HeaderText = "Nome";
            this.Nome_Usuario.Name = "Nome_Usuario";
            this.Nome_Usuario.ReadOnly = true;
            this.Nome_Usuario.Width = 180;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Situação";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome Usuario";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.cbxAtivo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mkbEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxPerfil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNomeUsuario);
            this.groupBox1.Location = new System.Drawing.Point(5, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Usuario";
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(69, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Location = new System.Drawing.Point(69, 50);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(295, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.Enabled = false;
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbxAtivo.Location = new System.Drawing.Point(441, 19);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(62, 21);
            this.cbxAtivo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ativo:";
            // 
            // mkbEmail
            // 
            this.mkbEmail.Location = new System.Drawing.Point(69, 106);
            this.mkbEmail.Name = "mkbEmail";
            this.mkbEmail.ReadOnly = true;
            this.mkbEmail.Size = new System.Drawing.Size(434, 20);
            this.mkbEmail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "E-mail:";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.Enabled = false;
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "GERENCIAL",
            "OPERADOR"});
            this.cbxPerfil.Location = new System.Drawing.Point(409, 50);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(94, 21);
            this.cbxPerfil.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Perfil:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Login:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(69, 19);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.ReadOnly = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(332, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPesquisaNomeUsuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtCodUsu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dtpDatUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 35);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(101, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data:";
            // 
            // txtPesquisaNomeUsuario
            // 
            this.txtPesquisaNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaNomeUsuario.Location = new System.Drawing.Point(274, 7);
            this.txtPesquisaNomeUsuario.Name = "txtPesquisaNomeUsuario";
            this.txtPesquisaNomeUsuario.Size = new System.Drawing.Size(246, 20);
            this.txtPesquisaNomeUsuario.TabIndex = 1;
            this.txtPesquisaNomeUsuario.TabStop = false;
            this.txtPesquisaNomeUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaNomeUsuario_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(230, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nome:";
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodUsu.Location = new System.Drawing.Point(39, 8);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.ReadOnly = true;
            this.txtCodUsu.Size = new System.Drawing.Size(53, 20);
            this.txtCodUsu.TabIndex = 20;
            this.txtCodUsu.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(10, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cód:";
            // 
            // dtpDatUsuario
            // 
            this.dtpDatUsuario.Enabled = false;
            this.dtpDatUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatUsuario.Location = new System.Drawing.Point(135, 7);
            this.dtpDatUsuario.Name = "dtpDatUsuario";
            this.dtpDatUsuario.Size = new System.Drawing.Size(84, 20);
            this.dtpDatUsuario.TabIndex = 21;
            this.dtpDatUsuario.TabStop = false;
            // 
            // frmCadCliFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 425);
            this.Controls.Add(this.tabClienteFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadCliFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente e Fornecedor";
            this.Load += new System.EventHandler(this.frmCadCliFor_Load);
            this.tabClienteFor.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadCliFor)).EndInit();
            this.gbxDadosCli.ResumeLayout(false);
            this.gbxDadosCli.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabClienteFor;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.DataGridView dgvCadCliFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.GroupBox gbxDadosCli;
        private System.Windows.Forms.ComboBox cbxPfpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCNPJ_CPF;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblCPF_CNPJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label lblLocalizarNome;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisaNomeUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodUsu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInserirUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Button btnAlteraUsuario;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox mkbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dat_Cadastros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}