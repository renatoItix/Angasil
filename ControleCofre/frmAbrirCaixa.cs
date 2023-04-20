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
    public partial class frmAbrirCaixa : Form
    {
        //---variaveis Global
        UsuarioDTO CodigoUsu;
        double Saldo;
        AbrirCaixaDTO Valida; //fechamento

        //---metodo construtor sem parametros
        public frmAbrirCaixa()
        {
            InitializeComponent();
        }

        //---metodo construtor com parametros
        public frmAbrirCaixa(UsuarioDTO codUsu)
        {
            InitializeComponent();
            CodigoUsu = codUsu;
        }


        private void frmAbrirCaixa_Load(object sender, EventArgs e)
        {
           
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Valida = usuarioDAL.validaFechamento();

            if (Valida.Flg_Situacao == "A")
            {
                MessageBox.Show(" Você deve voltar a data do seu Computador e Fechar o caixa do dia Anterior ! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                //frmFecharCaixa fechar = new frmFecharCaixa(CodigoUsu);
                //fechar.Show();
            }
           
            dtpDataAbertura.Text = Convert.ToString(DateTime.Now.Date);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //inserir data de abertura do caixa e troco do dia anterior


            if (txtTrocoDiaAnterior.Text == "")
            {
                MessageBox.Show(" Você deve lançar o troco do dia Anterior ! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            try
            {


                MovimentoDAL dal = new MovimentoDAL();
                Saldo = dal.CarregaSaldo();
                AbrirCaixaDTO ABRIR = new AbrirCaixaDTO();

                ABRIR.Dat_Abertura = dtpDataAbertura.Value;
                ABRIR.Troco_Dia = Convert.ToDouble(txtTrocoDiaAnterior.Text);
                if (Saldo != Convert.ToDouble(ABRIR.Troco_Dia))
                {
                    MessageBox.Show("  Valor troco do dia Anterior, não pode ser diferente do Saldo fechamento anterior! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }




                ABRIR.Cod_Usuario = CodigoUsu.Cod_Usuario;
                int x = new UsuarioDAL().AbrirCaixa(ABRIR);
                if (x > 0)
                {
                    MessageBox.Show("Caixa Aberto com sucesso!");
                }

                Form frm = new frmPrincipal(CodigoUsu);
                frm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }

        }
    }
}
