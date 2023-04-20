using ControleCofre.DAL;
using ControleCofre.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCofre
{
    public partial class frmContaQuitar : Form
    {
        ContaPagarDTO movCodPagamento;
        UsuarioDTO usuarioSel;
        AcaoNaTela modo;
        int cod_cli;
        string classificar;


        public frmContaQuitar()
        {
            InitializeComponent();
        }
      
        public frmContaQuitar(ContaPagarDTO movimentoSelecionado, UsuarioDTO usu)
        {
            InitializeComponent();
            usuarioSel = usu;

            cod_cli = movimentoSelecionado.cod_cli;
            classificar = movimentoSelecionado.classificar_empresa;
            movCodPagamento = movimentoSelecionado;

            txtCodContaPagar.Text = movimentoSelecionado.cod_contapagar.ToString();
            txtDescricao.Text = movimentoSelecionado.descricao;
            txtNomeCli.Text = movimentoSelecionado.nome_cli;
            txtNF.Text = movimentoSelecionado.nf;
            txtValorTitulo.Text = movimentoSelecionado.valor_titulo.ToString();
            txtObservacao.Text = movimentoSelecionado.observacao;
            cbxCentroCusto.Text = movimentoSelecionado.centro_custo;

            lblNumeroCheque.Visible = false;
            txtNumeroCheque.Visible = false;


        }
        private void frmContaQuitar_Load(object sender, EventArgs e)
        {
            this.Text = "Pagando Contas" + "  |   " + usuarioSel.Nome;
            dtpDatPagamento.Value = DateTime.Now.Date;
            dtpDatPagamento.Enabled = true;

        }
        //---metodo calcula conta a pagar txtValorPago
        public void calculaContaPagar()
        {
            double Juros = 0;
            double desconto = 0;
            double v_valortitulo;

            if (txtJuros.Text != "" && txtDesconto.Text != "")
            {
                Juros = Convert.ToDouble(txtJuros.Text);
                desconto = Convert.ToDouble(txtDesconto.Text);
            }

            v_valortitulo = Convert.ToDouble(txtValorTitulo.Text);

            txtValorPago.Text = Convert.ToString(v_valortitulo + Juros - desconto);

        }
        //---Carregando dados Combo box
        private void cmbFormaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPgto.Text == "Cheque")
            {
                modo = AcaoNaTela.nulo;

                lblNumeroCheque.Visible = true;
                txtNumeroCheque.Visible = true;
                txtNumeroCheque.Focus();
                txtValorPago.Text = txtValorTitulo.Text;

            }

            else if (cmbFormaPgto.Text == "Caixa")
            {
                modo = AcaoNaTela.Inserir;

                lblNumeroCheque.Visible = false;
                txtNumeroCheque.Visible = false;
                txtNumeroCheque.Text = "0";
                txtDesconto.Text = "0";
                txtJuros.Text = "0";
                txtValorPago.Text = txtValorTitulo.Text;

            }

            else if (cmbFormaPgto.Text == "Internet")
            {
                modo = AcaoNaTela.nulo;

                lblNumeroCheque.Visible = false;
                txtNumeroCheque.Visible = false;
                txtNumeroCheque.Text = "0";
                txtDesconto.Text = "0";
                txtJuros.Text = "0";
                txtValorPago.Text = txtValorTitulo.Text;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ContaPagarDTO insereMov = new ContaPagarDTO();
                insereMov.cod_contapagar = movCodPagamento.cod_contapagar;
                insereMov.dat_baixa = DateTime.Now.Date;
                insereMov.for_pagamento = cmbFormaPgto.Text;
                insereMov.valor_juros = Convert.ToDouble(txtJuros.Text);
                insereMov.valor_desc = Convert.ToDouble(txtDesconto.Text);
                insereMov.valor_pago = Convert.ToDouble(txtValorPago.Text);
                insereMov.num_cheque = Convert.ToInt16(txtNumeroCheque.Text);

                int x = new ContaPagarDAL().InsereContaQuitada(insereMov);
                if (x > 0)
                {
                    MessageBox.Show("Conta Paga com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }

            if (modo == AcaoNaTela.Inserir)
            {
                try
                {
                    MovimentoDTO movi = new MovimentoDTO();
                    movi.cod_cli = cod_cli;
                    movi.nome_Cli = txtNomeCli.Text;
                    movi.descricao = txtDescricao.Text;
                    movi.debito = Convert.ToDouble(txtValorPago .Text);
                    movi.nf = txtNF.Text;
                    movi.observacao = txtObservacao.Text;
                    movi.Data = DateTime.Now.Date;
                    movi.classificar_empresa = classificar;
                    movi.centro_custo = cbxCentroCusto.Text;

                    int x = new MovimentoDAL().insereMovimento(movi);
                    if (x > 0)
                    {
                        MessageBox.Show("Movimento debitado no Caixa com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }
            }

        }
       
       

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {
            calculaContaPagar();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            calculaContaPagar();
        }
    }
}

