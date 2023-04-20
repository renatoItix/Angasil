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
//using Relatorios;

namespace ControleCofre
{
    public partial class frmContasPagar : Form
    {
        DateTime dt1;
        DateTime dt2;
        UsuarioDTO UsuarioSel;
        public frmContasPagar()
        {
            InitializeComponent();
        }
        public frmContasPagar( UsuarioDTO usu)
        {
            InitializeComponent();
            UsuarioSel = usu;

        }

        //---metodo para carregar o grid
        public void carregaGrid()
        {
            IList<ContaPagarDTO> listContaPagar = new List<ContaPagarDTO>();
            dgvContaPagar.AutoGenerateColumns = false;
            ContaPagarDAL dal = new ContaPagarDAL();
            listContaPagar = dal.CarregaContaPagar();
            dgvContaPagar.DataSource = listContaPagar;

        }

        //---metodo para carregar o grid Conta Quitada
        public void carregaGridQuitado()
        {
            IList<ContaPagarDTO> listContaPagar = new List<ContaPagarDTO>();
            dgvContaQuitada.AutoGenerateColumns = false;
            ContaPagarDAL dal = new ContaPagarDAL();
            listContaPagar = dal.CarregaContaPagarQuitado();
            dgvContaQuitada.DataSource = listContaPagar;

        }
        //---metodo para carregar Pesquisa Nome Conta Quitada
        public void carregaPesquisaNomeQuitado()
        {
            ContaPagarDTO ContaPagar = new ContaPagarDTO();
            ContaPagar.nome_cli = txtPesquisaQuitada.Text;
            IList<ContaPagarDTO> listConsultaMovi = new List<ContaPagarDTO>();
            ContaPagarDAL dal = new ContaPagarDAL();
            listConsultaMovi = dal.pesquisaContaQuitadaNome(ContaPagar);
            dgvContaQuitada.DataSource = listConsultaMovi;
        }

        //---metodo para carregar Pesquisa Nome Conta a Pagar
        public void carregaPesquisaNomeContaPagar()
        {
            ContaPagarDTO ContaPagar = new ContaPagarDTO();
            ContaPagar.nome_cli = txtLocalizar.Text;
            IList<ContaPagarDTO> listConsultaMovi = new List<ContaPagarDTO>();
            ContaPagarDAL dal = new ContaPagarDAL();
            listConsultaMovi = dal.pesquisaContaPagarNome(ContaPagar);
            dgvContaPagar.DataSource = listConsultaMovi;

            txtValorPago.Text = dal.CarregaTotalContaPagarPorNome(ContaPagar).ToString("C2");
        }

        //---metodo para carregar Pesquisa Soma Descontos Conta Quitada
        public Double SomaPesquisaDesconto()
        {
            double valor = 0;

            foreach (DataGridViewRow Linha in dgvContaQuitada.Rows)
            {
                valor = valor + Convert.ToDouble(Linha.Cells[10].Value);

            }
            return valor;

        }

        //---metodo para carregar Pesquisa Soma Juros Conta Quitada
        public Double SomaPesquisaJuros()
        {
            double valor = 0;

            foreach (DataGridViewRow Linha in dgvContaQuitada.Rows)
            {
                valor = valor + Convert.ToDouble(Linha.Cells[9].Value);

            }
            return valor;

        }

        //---metodo para carregar Soma da Pesquisa por Nome Conta a Pagar
        public Double SomaPesquisaContaPagar()
        {
            double valor = 0;

            foreach (DataGridViewRow Linha in dgvContaPagar.Rows)
            {
                valor = valor + Convert.ToDouble(Linha.Cells[7].Value);
                valor = valor + Convert.ToDouble(Linha.Cells[6].Value);
            }
            return valor;

        }

        //---metodo para carregar Soma da Pesquisa por Nome Conta Quitada
        public Double SomaPesquisaContaPago()
        {
            double valor = 0;

            foreach (DataGridViewRow Linha in dgvContaPagar.Rows)
            {
                valor = valor + Convert.ToDouble(Linha.Cells[6].Value);
            }
            return valor;

        }

        //---metodo para carregar Soma da Pesquisa por Nome Conta Quitada
        public Double SomaPesquisaContaQuitada()
        {
            double valor = 0;

            foreach (DataGridViewRow Linha in dgvContaQuitada.Rows)
            {
                valor = valor + Convert.ToDouble(Linha.Cells[11].Value);
            }
            return valor;

        }

        // ---metodo para pegar linha do DataGridWiew
        public int linhadgv()
        {
            Int32 linha = Convert.ToInt32(dgvContaPagar.CurrentRow.Index);
            return linha;
        }

        // ---metodo para carregar TextBox Total Contas a pagar
        public void carregaContaPagar()
        {
            ContaPagarDAL dal = new ContaPagarDAL();
            txtTotalPagar.Text = dal.CarregaTotalContaPagar().ToString("C2");

        }

        // ---metodo para carregar TextBox Total Contas Quitadas
        public void carregaTotalContaQuitada()
        {
            ContaPagarDAL dal = new ContaPagarDAL();
            txtTotalPago.Text = dal.CarregaTotalContaQuitada().ToString("C2");
            txtTotalDesconto.Text = SomaPesquisaDesconto().ToString("C2");
            txtTotalJuros.Text = SomaPesquisaJuros().ToString("C2");
        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            this.Text = "Contas a Pagar / A Pagar Quitadas"  + "  |  "  + UsuarioSel.Nome;
            carregaGrid();
            carregaContaPagar();
        }

        private void dgvContaPagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvContaPagar.CurrentRow.Index;
            txtObservacao.Text = Convert.ToString(dgvContaPagar["Observacao", linha].Value);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGridQuitado();
            carregaTotalContaQuitada();
        }

        private void dgvContaQuitada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvContaQuitada.CurrentRow.Index;
            txtContaOuitadaObs.Text = Convert.ToString(dgvContaQuitada["obsQuitado", linha].Value);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form frm = new frmContaPagar(AcaoNaTela.Inserir, null, UsuarioSel);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                carregaGrid();
                carregaContaPagar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvContaPagar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            ContaPagarDTO movimentoSelecionado = (dgvContaPagar.SelectedRows[0].DataBoundItem as ContaPagarDTO);

            Form frm = new frmContaPagar(AcaoNaTela.Alterar, movimentoSelecionado, UsuarioSel);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGrid();
                carregaContaPagar();
            }
        }

        private void btnPagarConta_Click(object sender, EventArgs e)
        {
            ContaPagarDTO movimentoSelecionado = (dgvContaPagar.SelectedRows[0].DataBoundItem as ContaPagarDTO);
            frmContaQuitar frm = new frmContaQuitar(movimentoSelecionado, UsuarioSel);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                carregaGrid();
                carregaContaPagar();
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
                ContaPagarDTO ContaPagar = new ContaPagarDTO();
                ContaPagarDTO movimentoSelecionado = (dgvContaPagar.SelectedRows[0].DataBoundItem as ContaPagarDTO);
                ContaPagarDAL dal = new ContaPagarDAL();
                ContaPagar.cod_contapagar = new ContaPagarDAL().excluiContaPagar(movimentoSelecionado);

                int x = new ContaPagarDAL().excluiContaPagar(movimentoSelecionado);
                if (x > 0)
                {
                    MessageBox.Show("Movimento excluido com sucesso!");
                    carregaGrid();
                    carregaContaPagar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

        private void txtLocalizar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                carregaPesquisaNomeContaPagar();
                txtTotalPagar.Text = SomaPesquisaContaPagar().ToString("C2");
                txtValorPago.Text = SomaPesquisaContaPago().ToString("C2");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão" + ex.Message);
            }

        }

        private void txtPesquisaQuitada_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                carregaPesquisaNomeQuitado();
                txtTotalPago.Text = SomaPesquisaContaQuitada().ToString("C2");
                txtTotalDesconto.Text = SomaPesquisaDesconto().ToString("C2");
                txtTotalJuros.Text = SomaPesquisaJuros().ToString("C2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão" + ex.Message);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //frmRelContaPagar frm = new frmRelContaPagar();
            //frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //frmRelContaQuitada frm = new frmRelContaQuitada();
            //frm.ShowDialog();
        }

        private void btnPesquisaData_Click(object sender, EventArgs e)
        {
            ContaPagarDTO conta = new ContaPagarDTO();

            dt1 = dtInicial.Value;
            dt2 = dtFinal.Value;

            conta.dat_venc = dt1.Date;
            conta.DataFinal = dt2.Date.AddDays(1).AddSeconds(-1);

            IList<ContaPagarDTO> listConsultaData = new List<ContaPagarDTO>();
            ContaPagarDAL dal = new ContaPagarDAL();
            listConsultaData = dal.pesquisaContaPagarData(conta);
            dgvContaPagar.AutoGenerateColumns = false;

            dgvContaPagar.DataSource = listConsultaData;

            txtTotalPagar.Text = SomaPesquisaContaPagar().ToString("C2");

        }

        private void btnRevertePagamento_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja Reverter esse pagamento ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    return;
                }
                ContaPagarDTO ContaPagar = new ContaPagarDTO();
                ContaPagarDTO movimentoSelecionado = (dgvContaQuitada.SelectedRows[0].DataBoundItem as ContaPagarDTO);
                ContaPagarDAL dal = new ContaPagarDAL();
                ContaPagar.cod_contaquitada = new ContaPagarDAL().reverteContaQuitada(movimentoSelecionado);

                int x = new ContaPagarDAL().reverteContaQuitada(movimentoSelecionado);
                if (x > 0)
                {
                    MessageBox.Show("Conta revertida com sucesso, Se a forma de pagamento for 'CAIXA', Você precisa excluir do caixa a saida do dinheiro !", "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    carregaContaPagar();
                    carregaGridQuitado();
                    carregaTotalContaQuitada();
                    carregaGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

        //---Botão pesquisa por Data
        private void button1_Click(object sender, EventArgs e)
        {
            dt1 = dtInicialQuitada.Value;
            dt2 = dtFinalQuitada.Value;

            ContaPagarDTO conta = new ContaPagarDTO();

            conta.dat_baixa = dt1.Date;
            conta.DataFinal = dt2.Date.AddDays(1).AddSeconds(-1);

            IList<ContaPagarDTO> listConsultaData = new List<ContaPagarDTO>();
            ContaPagarDAL dal = new ContaPagarDAL();
            listConsultaData = dal.pesquisaContaQuitadaData(conta);
            dgvContaQuitada.AutoGenerateColumns = false;

            dgvContaQuitada.DataSource = listConsultaData;

            txtTotalPago.Text = SomaPesquisaContaQuitada().ToString("C2");
            txtTotalDesconto.Text = SomaPesquisaDesconto().ToString("C2");
            txtTotalJuros.Text = SomaPesquisaJuros().ToString("C2");


        }

        private void btnReciboContaQuitada_Click(object sender, EventArgs e)
        {
            //ContaPagarDTO ContaSelecionada = (dgvContaQuitada.SelectedRows[0].DataBoundItem as ContaPagarDTO);

            //frmReciboContaQuitada frm = new frmReciboContaQuitada(ContaSelecionada);
            //frm.ShowDialog();
        }

        private void btnAlterarCentroCusto_Click(object sender, EventArgs e)
        {
            if (dgvContaQuitada.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            ContaPagarDTO movimentoSelecionado = (dgvContaQuitada.SelectedRows[0].DataBoundItem as ContaPagarDTO);

            Form frm = new frmContaPagar(AcaoNaTela.AlterarQuitada, movimentoSelecionado, UsuarioSel);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                carregaGrid();
                carregaGridQuitado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



