using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleCofre.DTO;
using ControleCofre.DAL;
using System.IO;

namespace ControleCofre
{
    public partial class frmContaPagar : Form
    {
        AcaoNaTela modo;
        int cod_selecionado;
        UsuarioDTO usuario;

        public frmContaPagar(AcaoNaTela acaoNaTela, ContaPagarDTO contaSelecionada, UsuarioDTO usuarioSel)
        {
            InitializeComponent();
            modo = acaoNaTela;
            usuario = usuarioSel;

            if (modo == AcaoNaTela.Inserir)
            {
                this.Text = "Inserindo Contas a Pagar " + "  |  " + usuario.Nome;

                dtpDatContaPagar.Value = DateTime.Now.Date;
                dtpDatVenc.Value = DateTime.Now.Date;
                dtpDatContaPagar.Enabled = false;
                txtCodContaPagar.ReadOnly = true;
                cbClassificar.Focus();

                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;


            }

            else if (modo == AcaoNaTela.Alterar)
            {
                this.Text = "Alterando Contas a Pagar" + "  |  " + usuario.Nome;

                txtCodContaPagar.Text = Convert.ToString(contaSelecionada.cod_contapagar);
                cbClassificar.Text = contaSelecionada.classificar_empresa;
                cod_selecionado = contaSelecionada.cod_cli;
                txtNomeCli.Text = contaSelecionada.nome_cli;
                txtCNPJ_CPF.Text = contaSelecionada.cpf;
                txtTelefone.Text = contaSelecionada.telefone;
                txtCel.Text = contaSelecionada.celular;
                txtDescricao.Text = contaSelecionada.descricao;
                txtNF.Text = contaSelecionada.nf;
                cbxCentroCusto.Text = contaSelecionada.centro_custo;
                txtValorTitulo.Text = Convert.ToString(contaSelecionada.valor_titulo);
                dtpDatContaPagar.Value = contaSelecionada.dat_lanc;
                dtpDatVenc.Value = contaSelecionada.dat_venc;
                txtObservacao.Text = contaSelecionada.observacao;


                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                dtpDatContaPagar.Enabled = false;
            }

            else if (modo == AcaoNaTela.AlterarQuitada)
            {
                this.Text = "Alterando Contas a Pagar" + "  |  " + usuario.Nome;

                txtCodContaPagar.Text = Convert.ToString(contaSelecionada.cod_contapagar);
                cbClassificar.Text = contaSelecionada.classificar_empresa;
                cod_selecionado = contaSelecionada.cod_cli;
                txtNomeCli.Text = contaSelecionada.nome_cli;
                txtCNPJ_CPF.Text = contaSelecionada.cpf;
                txtTelefone.Text = contaSelecionada.telefone;
                txtCel.Text = contaSelecionada.celular;
                txtDescricao.Text = contaSelecionada.descricao;
                txtNF.Text = contaSelecionada.nf;
                cbxCentroCusto.Text = contaSelecionada.centro_custo;
                txtValorTitulo.Text = Convert.ToString(contaSelecionada.valor_titulo);
                dtpDatContaPagar.Value = contaSelecionada.dat_lanc;
                dtpDatVenc.Value = contaSelecionada.dat_venc;
                txtObservacao.Text = contaSelecionada.observacao;

                txtCodContaPagar.ReadOnly = true;
                btnSelecionar.Visible = false;
                txtNomeCli.ReadOnly = true;
                txtRG.ReadOnly = true;
                txtCNPJ_CPF.ReadOnly = true;
                txtCel.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                dtpDatContaPagar.Enabled = false;
                txtDescricao.ReadOnly = true;
                txtNF.ReadOnly = true;
                txtValorTitulo.ReadOnly = true;
                dtpDatVenc.Enabled = false;

            }



        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmSelCliFor frm = new frmSelCliFor(usuario);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modo == AcaoNaTela.Inserir)
            {
                if (!validaCampos())
                {
                    return;
                }
                try
                {
                    ContaPagarDTO contaPagar = new ContaPagarDTO();
                    contaPagar.cod_cli = cod_selecionado;
                    contaPagar.nome_cli = txtNomeCli.Text;
                    contaPagar.descricao = txtDescricao.Text;
                    contaPagar.valor_titulo = Convert.ToDouble(txtValorTitulo.Text);
                    contaPagar.nf = txtNF.Text;
                    contaPagar.rg = txtRG.Text;
                    contaPagar.cpf = txtCNPJ_CPF.Text;
                    contaPagar.telefone = txtTelefone.Text;
                    contaPagar.celular = txtCel.Text;
                    contaPagar.observacao = txtObservacao.Text;
                    contaPagar.dat_lanc = dtpDatContaPagar.Value;
                    contaPagar.dat_venc = dtpDatVenc.Value;
                    contaPagar.classificar_empresa = cbClassificar.Text;
                    contaPagar.centro_custo = cbxCentroCusto.Text;

                    int x = new ContaPagarDAL().insereContaPagar(contaPagar);
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

            else if (modo == AcaoNaTela.AlterarQuitada)
            {
                try
                {
                    ContaPagarDTO contaPagar = new ContaPagarDTO();
                    contaPagar.cod_contapagar = Convert.ToInt32(txtCodContaPagar.Text);
                    contaPagar.cod_cli = cod_selecionado;
                    contaPagar.nf = txtNF.Text;
                    contaPagar.descricao = txtDescricao.Text;
                    contaPagar.classificar_empresa = cbClassificar.Text;
                    contaPagar.centro_custo = cbxCentroCusto.Text;
                    contaPagar.valor_titulo = Convert.ToDouble(txtValorTitulo.Text);
                    contaPagar.dat_lanc = dtpDatContaPagar.Value;
                    contaPagar.dat_venc = dtpDatVenc.Value;
                    contaPagar.observacao = txtObservacao.Text;

                    int x = new ContaPagarDAL().alteraContaPagar(contaPagar);
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
            else if (modo == AcaoNaTela.Alterar)
            {
                try
                {
                    ContaPagarDTO contaPagar = new ContaPagarDTO();
                    contaPagar.cod_contapagar = Convert.ToInt32(txtCodContaPagar.Text);
                    contaPagar.cod_cli = cod_selecionado;
                    contaPagar.nf = txtNF.Text;
                    contaPagar.descricao = txtDescricao.Text;
                    contaPagar.classificar_empresa = cbClassificar.Text;
                    contaPagar.centro_custo = cbxCentroCusto.Text;
                    contaPagar.valor_titulo = Convert.ToDouble(txtValorTitulo.Text);
                    contaPagar.dat_lanc = dtpDatContaPagar.Value;
                    contaPagar.dat_venc = dtpDatVenc.Value;
                    contaPagar.observacao = txtObservacao.Text;

                    int x = new ContaPagarDAL().alteraContaPagar(contaPagar);
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

        //---metodo para validar os campos Contas a Pagar
        private bool validaCampos()
        {
            if (txtNomeCli.Text == "" || txtDescricao.Text == "" || txtNF.Text == "" || txtValorTitulo.Text == ""
                                                 || txtRG.Text == "" || txtCNPJ_CPF.Text == "" || txtTelefone.Text == "" || txtCel.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbClassificar.Text == "")
            {
                MessageBox.Show("Você deve Classicar uma Empresa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClassificar.Focus();
                return false;
            }
            else if (cbxCentroCusto.Text == "")
            {
                MessageBox.Show("Você deve Selecionar um Centro de Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCentroCusto.Focus();
                return false;
            }

            return true;

        }

        private void frmContaPagar_Load(object sender, EventArgs e)
        {
            //---carregando combo box Centro de Custo
            StreamReader sTR = new StreamReader("ArqCentroCusto.txt");
            while (!sTR.EndOfStream)
            {
                cbxCentroCusto.Items.Add(sTR.ReadLine());
            }
        }



    }
}