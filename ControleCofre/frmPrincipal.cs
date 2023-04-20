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
//using Relatorios;

namespace ControleCofre
{
    public partial class frmPrincipal : Form
    {
        UsuarioDTO usuario;
        AbrirCaixaDTO Fechado;
        DateTime dt1;
        DateTime dt2;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(UsuarioDTO abrir)
        {
            InitializeComponent();
            usuario = abrir;

        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frmCadCliFor frm = new frmCadCliFor(AcaoNaTela.nulo, usuario);
            frm.Show();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento(AcaoNaTela.Credito, null, usuario);

            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGrid();
                carregaCredito();
                carregaDebito();
                carregaSaldo();
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento(AcaoNaTela.Debito, null, usuario);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGrid();
                carregaCredito();
                carregaDebito();
                carregaSaldo();
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dgvCaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            MovimentoDTO movimentoSelecionado = (dgvCaixa.SelectedRows[0].DataBoundItem as MovimentoDTO);

            frmMovimento frm = new frmMovimento(AcaoNaTela.Consultar, movimentoSelecionado, usuario);
            frm.ShowDialog();



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvCaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            MovimentoDTO movimentoSelecionado = (dgvCaixa.SelectedRows[0].DataBoundItem as MovimentoDTO);

            frmMovimento frm = new frmMovimento(AcaoNaTela.Alterar, movimentoSelecionado, usuario);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGrid();
                carregaCredito();
                carregaDebito();
                carregaSaldo();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                MovimentoDTO movi = new MovimentoDTO();
                MovimentoDTO movimentoSelecionado = (dgvCaixa.SelectedRows[0].DataBoundItem as MovimentoDTO);
                MovimentoDAL dal = new MovimentoDAL();
                movi.codigo = new MovimentoDAL().excluiMovimento(movimentoSelecionado);

                int x = new MovimentoDAL().excluiMovimento(movimentoSelecionado);
                if (x > 0)
                {
                    MessageBox.Show("Movimento excluido com sucesso!");
                    carregaGrid();
                    carregaCredito();
                    carregaDebito();
                    carregaSaldo();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Text = "Controle Cofre" + "  |  " + usuario.Nome;
            carregaGrid();
            carregaCredito();
            carregaDebito();
            carregaSaldo();

            // ---verificando se ja foi fechado, se sim, nao podera abrir no dia e nem abrir voltando a data do computador
            UsuarioDAL dal = new UsuarioDAL();
            Fechado = dal.validaFechamento();

            if (Fechado.Flg_Situacao == "F" && Fechado.Dat_Fechamento >= DateTime.Now.Date)
            {
                MessageBox.Show(" Caixa ja foi fechado na data de hoje, por favor contate o suporte !", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        // ---metodo para pegar linha do DataGridWiew
        public int linhadgv()
        {
            Int32 linha = Convert.ToInt32(dgvCaixa.CurrentRow.Index);
            return linha;
        }

        //---metodo para carregar Grid Consulta Nome

        public void carregaGridConsultaNome()
        {
            MovimentoDTO movi = new MovimentoDTO();
            movi.nome_Cli = txtLocalizar.Text;
            IList<MovimentoDTO> listConsultaMovi = new List<MovimentoDTO>();
            MovimentoDAL dal = new MovimentoDAL();
            listConsultaMovi = dal.ConsultaNome(movi);
            dgvCaixa.DataSource = listConsultaMovi;
        }

        //---metodo para carregar o grid
        public void carregaGrid()
        {
            try
            {
                IList<MovimentoDTO> listMovimentoDTO = new List<MovimentoDTO>();
                dgvCaixa.AutoGenerateColumns = false;
                MovimentoDAL dal = new MovimentoDAL();
                listMovimentoDTO = dal.CarregaMovimento();
                dgvCaixa.DataSource = listMovimentoDTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão : " + " " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        // ---metodo para carregar TextBox Credito
        public void carregaCredito()
        {
            MovimentoDAL dal = new MovimentoDAL();
            txtTotalCredito.Text = dal.CarregaTotalCredito().ToString("C2");

        }

        // ---metodo para carregar TextBox Debito
        public void carregaDebito()
        {
            MovimentoDAL dal = new MovimentoDAL();
            txtTotalDebito.Text = dal.CarregaTotalDebito().ToString("C2");

        }

        // ---metodo para carregar TextBox Saldo
        public void carregaSaldo()
        {
            MovimentoDAL dal = new MovimentoDAL();
            txtSaldoCaixa.Text = dal.CarregaSaldo().ToString("C2");

        }


        private void btnPesquisaData_Click(object sender, EventArgs e)
        {
            MovimentoDTO movi = new MovimentoDTO();

            dt1 = dtInicial.Value;
            dt2 = dtFinal.Value;

            movi.Data = dt1.Date;
            movi.DataFinal = dt2.Date.AddDays(1).AddSeconds(-1);

            IList<MovimentoDTO> listConsultaData = new List<MovimentoDTO>();
            MovimentoDAL dal = new MovimentoDAL();
            listConsultaData = dal.ConsultaData(movi);
            dgvCaixa.AutoGenerateColumns = false;

            dgvCaixa.DataSource = listConsultaData;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Form frm = new frmRelCaixa();
            //frm.Show();
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            Form FRM = new frmFecharCaixa(usuario);
            FRM.Show();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            MovimentoDTO movimentoSelecionado = (dgvCaixa.SelectedRows[0].DataBoundItem as MovimentoDTO);

            frmReciboMov frm = new frmReciboMov(movimentoSelecionado);
            frm.ShowDialog();
        }

        private void btnContasPagar_Click_1(object sender, EventArgs e)
        {
            Form frm = new frmContasPagar(usuario);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult != DialogResult.Yes)
            {

                carregaGrid();
                carregaCredito();
                carregaDebito();
                carregaSaldo();
            }


        }
        private void txtLocalizar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
              carregaGridConsultaNome();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente ou Fornecedor não Localizados, digite novamente! " + " " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                                                       
            }

            if (e.KeyCode == Keys.Back)
            {
               txtLocalizar.Clear();
                carregaGrid();
            }

        }
        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            Form frm = new frmContasReceber(usuario);
            DialogResult dialogResult = frm.ShowDialog();

        }


    }
}

