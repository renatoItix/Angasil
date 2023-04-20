using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleCofre.DAL;
using ControleCofre.DTO;


namespace ControleCofre
{
    public partial class frmMovimento : Form
    {
        AcaoNaTela modo;
        MovimentoDTO _movi;
        //CadCliForDTO ClienteSelecionado;
        int cod_selecionado;
        int CodCli_Grid;
        UsuarioDTO usu;

        //---Metodo construtor
        public frmMovimento(AcaoNaTela acaoNaTela, MovimentoDTO movi, UsuarioDTO usuario)
        {
            InitializeComponent();
            this.modo = acaoNaTela;
            this._movi = movi;
            usu = usuario;

            //---Alterar 
            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterando Lançamento" + "  |  " + usu.Nome;

                //---carregando informaçoes no form
                CodCli_Grid = movi.cod_cli;
                txtCodCli.Text = Convert.ToString(movi.codigo);
                txtNomeCli.Text = movi.nome_Cli;
                txtDescricao.Text = movi.descricao;
                txtDebito.Text = Convert.ToString(movi.debito);
                txtCredito.Text = Convert.ToString(movi.credito);
                txtNF.Text = Convert.ToString(movi.nf);
                txtRG.Text = Convert.ToString(movi.rg);
                txtCNPJ_CPF.Text = Convert.ToString(movi.cpf);
                txtTelefone.Text = Convert.ToString(movi.telefone);
                txtCel.Text = Convert.ToString(movi.celular);
                txtObservacao.Text = movi.observacao;
                dtpDataCad.Value = movi.Data;
                cbClassificar.Text = movi.classificar_empresa;
                cbxCentroCusto.Text = movi.centro_custo;

                //btnSelecionar.Visible = false;
                //txtNomeCli.Width = 432;
                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;


                dtpDataCad.Enabled = false;
                txtCodCli.ReadOnly = true;

            }
            //---lançando crédito
            else if (acaoNaTela == AcaoNaTela.Credito)
            {
                this.Text = "Lançando Crédito" + "  |  " + usu.Nome;
                lblDebito.Visible = false;
                txtDebito.Visible = false;
                dtpDataCad.Value = DateTime.Now;
                dtpDataCad.Enabled = false;
                txtCodCli.ReadOnly = true;
                cbClassificar.Focus();

                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;


            }
            //---lançando Débito
            else if (acaoNaTela == AcaoNaTela.Debito)
            {
                this.Text = "Lançando Débito" + "  |  " + usu.Nome;

                //---bloqueando digitação
                lblCredito.Visible = false;
                txtCredito.Visible = false;
                dtpDataCad.Value = DateTime.Now;
                dtpDataCad.Enabled = false;
                txtCodCli.ReadOnly = true;

                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;


            }
            //---Consultando
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultando Lançamento" + "  |  " + usu.Nome;
                desabilitaCampos();
                btnSelecionar.Visible = false;
                //---carregando informaçoes no form
                txtCodCli.Text = Convert.ToString(movi.codigo);
                txtNomeCli.Text = movi.nome_Cli;
                txtDescricao.Text = movi.descricao;
                txtDebito.Text = Convert.ToString(movi.debito);
                txtCredito.Text = Convert.ToString(movi.credito);
                txtNF.Text = Convert.ToString(movi.nf);
                txtRG.Text = Convert.ToString(movi.rg);
                txtCNPJ_CPF.Text = Convert.ToString(movi.cpf);
                txtTelefone.Text = Convert.ToString(movi.telefone);
                txtCel.Text = Convert.ToString(movi.celular);
                txtObservacao.Text = movi.observacao;
                dtpDataCad.Value = movi.Data;
                cbClassificar.Text = movi.classificar_empresa;
                cbxCentroCusto.Text = movi.centro_custo;

                //---bloqueando digitação
                txtNomeCli.Width = 432;
                btnCancelar.Text = "Fechar";
                btnSalvar.Visible = false;
                btnCancelar.Focus();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmSelCliFor frm = new frmSelCliFor(usu);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtNomeCli.Text = frm.CliForSelecionado.nome_cli;
                txtRG.Text = frm.CliForSelecionado.rg;
                txtCNPJ_CPF.Text = frm.CliForSelecionado.cpf;
                txtCel.Text = frm.CliForSelecionado.celular;
                txtTelefone.Text = frm.CliForSelecionado.telefone;
                cod_selecionado = frm.CliForSelecionado.cod_cli;

            }

        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            StreamReader sTR = new StreamReader("ArqCentroCusto.txt");
            while (!sTR.EndOfStream)
            {
                cbxCentroCusto.Items.Add(sTR.ReadLine());
            }

        }
        //---metodo para desabilitar os campos
        private void desabilitaCampos()
        {
            txtCodCli.ReadOnly = true;
            txtNomeCli.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            txtDebito.ReadOnly = true;
            txtCredito.ReadOnly = true;
            txtNF.ReadOnly = true;
            txtRG.ReadOnly = true;
            txtCNPJ_CPF.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCel.ReadOnly = true;
            txtObservacao.Enabled = false;
            dtpDataCad.Enabled = false;
            cbClassificar.Enabled = false;
            cbxCentroCusto.Enabled = false;
            btnCancelar.Focus();

        }

        //---metodo para validar os campos Crédito
        private bool validaCamposCredito()
        {
            if (txtNomeCli.Text == "" || txtDescricao.Text == "" || txtCredito.Text == "" || txtNF.Text == ""
                                                 || txtRG.Text == "" || txtCNPJ_CPF.Text == "" || txtTelefone.Text == "" || txtCel.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Todos os campos devem ser preenchidos! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (cbClassificar.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Você deve Classicar uma Empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClassificar.Focus();
                return false;
            }
            else if (cbxCentroCusto.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Você deve Selecionar um Centro de Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCentroCusto.Focus();
                return false;
            }
            return true;
        }

        //---metodo para validar os campos Débito
        private bool validaCamposDebito()
        {
            if (txtNomeCli.Text == "" || txtDescricao.Text == "" || txtDebito.Text == "" || txtNF.Text == ""
                                                 || txtRG.Text == "" || txtCNPJ_CPF.Text == "" || txtTelefone.Text == "" || txtCel.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Todos os campos devem ser preenchidos! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbClassificar.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Você deve Classicar uma Empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClassificar.Focus();
                return false;
            }

            else if (cbxCentroCusto.Text == "")
            {
                MessageBox.Show(usu.Nome + " , " + "Você deve Selecionar um Centro de Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCentroCusto.Focus();
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modo == AcaoNaTela.Credito)
            {
                if (!validaCamposCredito())
                {
                    return;
                }

                try
                {
                    MovimentoDTO movi = new MovimentoDTO();
                    movi.cod_cli = cod_selecionado;
                    movi.nome_Cli = txtNomeCli.Text;
                    movi.descricao = txtDescricao.Text;
                    movi.credito = Convert.ToDouble(txtCredito.Text);
                    movi.nf = txtNF.Text;
                    movi.rg = txtRG.Text;
                    movi.cpf = txtCNPJ_CPF.Text;
                    movi.telefone = txtTelefone.Text;
                    movi.celular = txtCel.Text;
                    movi.observacao = txtObservacao.Text;
                    movi.Data = dtpDataCad.Value;
                    movi.classificar_empresa = cbClassificar.Text;
                    movi.centro_custo = cbxCentroCusto.Text;

                    int x = new MovimentoDAL().insereMovimento(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Gravado com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }

            }
            else if (modo == AcaoNaTela.Debito)
            {
                if (!validaCamposDebito())
                {
                    return;
                }

                try
                {
                    MovimentoDTO movi = new MovimentoDTO();
                    movi.cod_cli = cod_selecionado;
                    movi.nome_Cli = txtNomeCli.Text;
                    movi.descricao = txtDescricao.Text;
                    movi.debito = Convert.ToDouble(txtDebito.Text);
                    movi.nf = txtNF.Text;
                    movi.rg = txtRG.Text;
                    movi.cpf = txtCNPJ_CPF.Text;
                    movi.telefone = txtTelefone.Text;
                    movi.celular = txtCel.Text;
                    movi.observacao = txtObservacao.Text;
                    movi.Data = dtpDataCad.Value;
                    movi.classificar_empresa = cbClassificar.Text;
                    movi.centro_custo = cbxCentroCusto.Text;

                    int x = new MovimentoDAL().insereMovimento(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Movimento inserido com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }

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
                    MovimentoDTO movi = new MovimentoDTO();
                    movi.cod_cli = CodCli_Grid;
                    movi.nf = txtNF.Text;
                    movi.descricao = txtDescricao.Text;
                    movi.classificar_empresa = cbClassificar.Text;
                    movi.centro_custo = cbxCentroCusto.Text;
                    movi.credito = Convert.ToDouble(txtCredito.Text);
                    movi.debito = Convert.ToDouble(txtDebito.Text);
                    movi.Data = dtpDataCad.Value;
                    movi.observacao = txtObservacao.Text;
                    movi.codigo = Convert.ToInt16(txtCodCli.Text);


                    int x = new MovimentoDAL().alteraMovimento(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Movimento alterado com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }


            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            frmReciboMov frmR = new frmReciboMov(_movi);
            frmR.ShowDialog();
        }

        private void cbClassificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassificar.Text == "GRANOBELLO" && modo != AcaoNaTela.Alterar && modo != AcaoNaTela.Consultar && modo != AcaoNaTela.Credito)
            {
                MessageBox.Show("Você deve lançar primeiro no 'CONTAS A PAGAR' e DEPOIS QUITAR o pagamento via CAIXA! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClassificar.Text = "";
                return;
            }
        }


    }
}
