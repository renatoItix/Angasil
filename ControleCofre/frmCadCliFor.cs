using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleCofre.DAL;
using ControleCofre.DTO;

namespace ControleCofre
{
    public partial class frmCadCliFor : Form
    {
        //---Variavel Global
        AcaoNaTela modo;
        int CodCliSelecionado = -1;
        int CodUsuSelecionado = -1;
        UsuarioDTO usuSel;

        public CadCliForDTO CliForSelecionado { get; }

        //---Metodo construtor
        public frmCadCliFor(AcaoNaTela acaoNaTela, UsuarioDTO usuario)
        {
            InitializeComponent();
            this.modo = acaoNaTela;
            usuSel = usuario;
            //perfilSelecionado = perfil;
        }
        // ---metodo para pegar linha do DataGridWiew
        public int linhadgv()
        {
            Int32 linha = Convert.ToInt32(dgvCadCliFor.CurrentRow.Index);
            return linha;
        }
        // ---metodo para verificar se Cliente ou Fornecedor ja estao cadastrados
        public bool verificaCadastro()
        {
            string cpf = txtCNPJ_CPF.Text; ;
            CadCliForDTO clifor = new CadCliForDTO();
            clifor.cpf = cpf;
            clifor = new CadCliForDAL().validaCadastroCliente(clifor);

            if (clifor.cpf == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void frmCadCliFor_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro Cliente e Fornecedor" + " | " + usuSel.Nome;
            this.ActiveControl = txtLocalizar;
            txtLocalizar.Focus();
            carregaGrid();

            cbxPfpj.Visible = false;
            label2.Visible = false;

        }

        //---metodo pesquisa por nome e carrega o grid
        public void pesquisaporNomeGrid()
        {
            CadCliForDTO cadCliForDTO = new CadCliForDTO();
            cadCliForDTO.nome_cli = txtLocalizar.Text;
            IList<CadCliForDTO> listConsultaNome = new List<CadCliForDTO>();
            CadCliForDAL dal = new CadCliForDAL();
            listConsultaNome = dal.ConsultaNome(cadCliForDTO);
            dgvCadCliFor.DataSource = listConsultaNome;
        }
        //---metodo pesquisa por nome Usuario
        public void pesquisaporNomeUsuario()
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.Nome = txtPesquisaNomeUsuario.Text;
            IList<UsuarioDTO> listConsultaNomeUsuario = new List<UsuarioDTO>();
            UsuarioDAL dal = new UsuarioDAL();
            listConsultaNomeUsuario = dal.ConsultaNomeUsuario(usuarioDTO);
            dgvUsuario.DataSource = listConsultaNomeUsuario;
        }


        //---metodo para carregar o grid
        public void carregaGrid()
        {
            IList<CadCliForDTO> ListcadCliForDTO = new List<CadCliForDTO>();
            dgvCadCliFor.AutoGenerateColumns = false;
            CadCliForDAL cadCliForDAL = new CadCliForDAL();
            ListcadCliForDTO = cadCliForDAL.CarregaCliFor();
            dgvCadCliFor.DataSource = ListcadCliForDTO;

        }
        //---metodo para carregar o grid Usuario
        public void carregaGridUsuario()
        {
            IList<UsuarioDTO> ListUsuarioDTO = new List<UsuarioDTO>();
            dgvUsuario.AutoGenerateColumns = false;
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            ListUsuarioDTO = usuarioDAL.CarregaUsuario();
            dgvUsuario.DataSource = ListUsuarioDTO;

        }


        //---Metodo para Habilitar campos Cliente e Fornecedor
        public void HabilitaCampos()
        {
            txtNomeCli.ReadOnly = false;
            txtCNPJ_CPF.ReadOnly = false;
            txtRG.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCel.ReadOnly = false;

        }
        //---Metodo para Habilitar campos Usuario
        private void HabilitaCamposUsuario()
        {
            cbxAtivo.Enabled = true;
            cbxPerfil.Enabled = true;
            txtLogin.ReadOnly = false;
            txtNomeUsuario.ReadOnly = false;
            txtSenha.ReadOnly = false;
            mkbEmail.ReadOnly = false;
        }

        //---Metodo para desabilitar campos Cliente e Fornecedor
        public void DesabilitaCampos()
        {
            txtNomeCli.ReadOnly = true;
            txtCNPJ_CPF.ReadOnly = true;
            txtRG.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCel.ReadOnly = true;
            cbxAtivo.Enabled = false;
            cbxPerfil.Enabled = false;
            txtLogin.ReadOnly = true;
            txtNomeUsuario.ReadOnly = true;
            txtSenha.ReadOnly = true;
            mkbEmail.ReadOnly = true;

        }
        //---Metodo para desabilitar campos Usuario
        public void DesabilitaCamposUsuario()
        {
            cbxAtivo.Enabled = false;
            cbxPerfil.Enabled = false;
            txtLogin.ReadOnly = true;
            txtNomeUsuario.ReadOnly = true;
            txtSenha.ReadOnly = true;
            mkbEmail.ReadOnly = true;

        }

        //---Metodo para Limpa campos
        private void limpaCampos()
        {
            txtCodCli.Text = "";
            txtNomeCli.Text = "";
            txtCNPJ_CPF.Text = "";
            txtRG.Text = "";
            txtCel.Text = "";
            txtTelefone.Text = "";
        }
        //---Metodo para Limpa campos Cadastro Usuario
        private void limpaCamposUsuarios()
        {
            txtNomeUsuario.Text = "";
            txtLogin.Text = "";
            txtCodUsu.Text = "";
            dtpDatUsuario.Text = "";
            mkbEmail.Text = "";
            txtSenha.Text = "";
            cbxAtivo.Text = "";
            cbxPerfil.Text = "";
        }

        //---Metodo para validar os campos
        public bool ValidaCampos()
        {
            if (txtNomeCli.Text == "" || txtCNPJ_CPF.Text == "" || txtCel.Text == "" || txtRG.Text == "" || cbxPfpj.Text == "")
            {
                MessageBox.Show( usuSel.Nome + ", " + "Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        //---Metodo para validar os campos Usuario
        public bool ValidaCamposUsuario()
        {
            if (txtNomeUsuario.Text == "" || txtLogin.Text == "" || txtSenha.Text == "" || cbxPerfil.Text == "" || cbxAtivo.Text == "")
            {
                MessageBox.Show( usuSel.Nome + ", " + "Todos os campos devem ser preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }


        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            modo = AcaoNaTela.Inserir;
            limpaCampos();
            HabilitaCampos();
            txtNomeCli.Focus();

            txtNomeCli.Width = 337;
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnInserir.Visible = false;
            cbxPfpj.Enabled = true;
            dgvCadCliFor.Enabled = false;

            cbxPfpj.Visible = true;
            label2.Visible = true;
        }

        private void cbxPfpj_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxPfpj.Text == "PF")
            {
                txtCNPJ_CPF.Mask = "###,###,###-##";
            }
            if (cbxPfpj.Text == "PJ")
            {
                txtCNPJ_CPF.Mask = "##,###,###/####-##";
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (CodCliSelecionado < 0)
            {
                MessageBox.Show("Selecione um Cliente ou Fornecedor !");
                return;
            }

            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                CadCliForDTO movi = new CadCliForDTO();
                movi.cod_cli = CodCliSelecionado;
                CadCliForDAL dal = new CadCliForDAL();
                int x = new CadCliForDAL().excluiMovimento(movi);
                if (x > 0)
                {
                    MessageBox.Show("Cliente ou Fornecedor, excluido com sucesso!");
                    carregaGrid();
                }
            }

            catch (Exception ex)
            {

                throw ex;

            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (CodCliSelecionado < 0)
            {
                MessageBox.Show( usuSel.Nome + ", " + "Selecione um Cliente ou Fornecedor para fazer alteração ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            HabilitaCampos();
            txtNomeCli.Focus();
            modo = AcaoNaTela.Alterar;
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnInserir.Visible = false;
            dgvCadCliFor.Enabled = false;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (modo == AcaoNaTela.Inserir)
            {
                if (!ValidaCampos())
                {
                    return;
                }

                if (verificaCadastro() == true)
                {
                    MessageBox.Show("Cliente ou Fornecedor ja cadastrado, verifique! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaCampos();
                    HabilitaCampos();
                    txtNomeCli.Focus();
                    return;
                }

                try
                {
                    CadCliForDTO movi = new CadCliForDTO();

                    movi.nome_cli = txtNomeCli.Text;
                    movi.cpf = txtCNPJ_CPF.Text;
                    movi.rg = txtRG.Text;
                    movi.telefone = txtTelefone.Text;
                    movi.celular = txtCel.Text;
                    movi.dat_cadastro = dtpDataCad.Value;

                    int x = new CadCliForDAL().insereCliFor(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                    }
                    carregaGrid();
                    limpaCampos();
                    DesabilitaCampos();
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    btnInserir.Visible = true;
                    btnSalvar.Visible = false;
                    dgvCadCliFor.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }

            }
            else if (modo == AcaoNaTela.Alterar)
            {
                try
                {
                    CadCliForDTO movi = new CadCliForDTO();
                    movi.cod_cli = CodCliSelecionado;
                    movi.nome_cli = txtNomeCli.Text;
                    movi.rg = txtRG.Text;
                    movi.cpf = txtCNPJ_CPF.Text;
                    movi.telefone = txtTelefone.Text;
                    movi.celular = txtCel.Text;

                    int x = new CadCliForDAL().alteraCliFor(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Cliente ou Fornecedor alterado com sucesso!");
                    }
                    carregaGrid();
                    DesabilitaCampos();
                    limpaCampos();
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    btnInserir.Visible = true;
                    btnSalvar.Visible = false;
                    dgvCadCliFor.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }
            }

        }
        private void txtLocalizar_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                pesquisaporNomeGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão" + ex.Message);
            }

        }
        //---Carrega as linhas do grid nos textbox
        private void dgvCadCliFor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvCadCliFor.CurrentRow.Index;
            CodCliSelecionado = Convert.ToInt32(dgvCadCliFor["Codigo", linha].Value);
            txtCodCli.Text = Convert.ToString(dgvCadCliFor["Codigo", linha].Value);
            dtpDataCad.Value = Convert.ToDateTime(dgvCadCliFor["Dat_Cadastro", linha].Value);
            txtNomeCli.Text = Convert.ToString(dgvCadCliFor["Nome_Cli", linha].Value);
            txtCNPJ_CPF.Text = Convert.ToString(dgvCadCliFor["CPF", linha].Value);
            txtRG.Text = Convert.ToString(dgvCadCliFor["RG", linha].Value);
            txtCel.Text = Convert.ToString(dgvCadCliFor["Celular", linha].Value);
            txtTelefone.Text = Convert.ToString(dgvCadCliFor["Telefone", linha].Value);
        }
        //---Carrega as linhas do grid nos textbox
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvUsuario.CurrentRow.Index;
            txtNomeUsuario.Text = Convert.ToString(dgvUsuario["Nome", linha].Value);
            txtLogin.Text = Convert.ToString(dgvUsuario["Nome_Usuario", linha].Value);
            txtCodUsu.Text = Convert.ToString(dgvUsuario["Cod_Usuario", linha].Value);
            CodUsuSelecionado = Convert.ToInt32(dgvUsuario["Cod_Usuario", linha].Value);
            dtpDatUsuario.Text = Convert.ToString(dgvUsuario["Dat_Cadastros", linha].Value);
            mkbEmail.Text = Convert.ToString(dgvUsuario["email", linha].Value);
            txtSenha.Text = Convert.ToString(dgvUsuario["Senha", linha].Value);
            cbxAtivo.Text = Convert.ToString(dgvUsuario["Ativo", linha].Value);
            cbxPerfil.Text = Convert.ToString(dgvUsuario["Perfil", linha].Value);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabClienteFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesabilitaCampos();
            carregaGridUsuario();

            if (tabClienteFor.SelectedTab == tabUsuario)
            {
                this.Text = "Cadastro de Usuarios" + " |  " + usuSel.Nome;
                if (usuSel.Perfil != "ADMINISTRADOR")
                {
                    // ((Control)this.tabUsuario).Enabled = false;
                    btnAlteraUsuario.Visible = false;
                    btnInserirUsuario.Visible = false;

                }
                else
                {
                    btnAlteraUsuario.Visible = true;
                    btnInserirUsuario.Visible = true;
                }

            }
            else if (tabClienteFor.SelectedTab == tabCliente)
            {
                this.Text = "Cadastro Cliente e Fornecedor" + " |  " + usuSel.Nome;
            }

        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            modo = AcaoNaTela.InserirUsuario;
            HabilitaCamposUsuario();
            limpaCamposUsuarios();
            dgvUsuario.Enabled = false;
            txtNomeUsuario.Focus();
            btnSalvarUsuario.Visible = true;
            btnAlteraUsuario.Visible = false;
            btnInserirUsuario.Visible = false;

        }
        private void btnAlteraUsuario_Click(object sender, EventArgs e)
        {
            if (CodUsuSelecionado < 0)
            {
                MessageBox.Show("Selecione um Usuario para fazer alteração ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            modo = AcaoNaTela.AlteraUsuario;
            HabilitaCamposUsuario();
            dgvUsuario.Enabled = false;
            btnSalvarUsuario.Visible = true;
            btnAlteraUsuario.Visible = false;
            btnInserirUsuario.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            //---Inserindo Usuario
            if (modo == AcaoNaTela.InserirUsuario)
            {
                if (!ValidaCamposUsuario())
                {
                    return;
                }
                try
                {
                    UsuarioDTO usu = new UsuarioDTO();

                    usu.Nome = txtNomeUsuario.Text;
                    usu.Nome_Usuario = txtLogin.Text;
                    usu.Senha = txtSenha.Text;
                    usu.Email = mkbEmail.Text;
                    usu.Perfil = cbxPerfil.Text;
                    usu.Ativo = cbxAtivo.Text;
                    usu.Dat_Cadastro = dtpDataCad.Value;


                    int x = new UsuarioDAL().insereUsuario(usu);
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com sucesso!", "Cadastrando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    carregaGridUsuario();
                    DesabilitaCamposUsuario();
                    btnSalvarUsuario.Visible = false;
                    btnAlteraUsuario.Visible = true;
                    btnInserirUsuario.Visible = true;
                    dgvUsuario.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }
            }
            //---Alterando Usuario
            if (modo == AcaoNaTela.AlteraUsuario)
            {
                try
                {
                    UsuarioDTO usu = new UsuarioDTO();

                    usu.Nome = txtNomeUsuario.Text;
                    usu.Nome_Usuario = txtLogin.Text;
                    usu.Senha = txtSenha.Text;
                    usu.Email = mkbEmail.Text;
                    usu.Perfil = cbxPerfil.Text;
                    usu.Ativo = cbxAtivo.Text;
                    usu.Cod_Usuario = Convert.ToInt32(txtCodUsu.Text);

                    int x = new UsuarioDAL().alteraUsuario(usu);
                    if (x > 0)
                    {
                        MessageBox.Show("Usuario Alterado com sucesso!", "Alterando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    carregaGridUsuario();
                    DesabilitaCamposUsuario();
                    btnSalvarUsuario.Visible = false;
                    btnAlteraUsuario.Visible = true;
                    btnInserirUsuario.Visible = true;
                    dgvUsuario.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }
            }
        }

        private void txtPesquisaNomeUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                pesquisaporNomeUsuario();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão" + ex.Message);
            }
        }
    }
}



