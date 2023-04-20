using ControleCofre.DAL;
using ControleCofre.DTO;
//using Relatorios;
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
    public partial class frmFecharCaixa : Form
    {
        UsuarioDTO UsuarioSel;
        double Saldo;
        AbrirCaixaDTO Fechado;
        public frmFecharCaixa()
        {
            InitializeComponent();
        }
        public frmFecharCaixa(UsuarioDTO usu)
        {
            InitializeComponent();
            UsuarioSel = usu;
        }
        private void frmFecharCaixa_Load(object sender, EventArgs e)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Fechado = usuarioDAL.validaFechamento();

            if (Fechado.Flg_Situacao == "F" && Fechado.Dat_Fechamento == DateTime.Now.Date)
            {
                MessageBox.Show(" Caixa ja foi fechado na data de hoje, por favor contate o suporte ! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }

            dtpDataFechamento.Text = Convert.ToString(DateTime.Now.Date);


        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {

            //inserir data de fechamento do caixa e troco para o dia posterior

            if (txtTrocoFechamento.Text == "")
            {
                MessageBox.Show(" Você deve lançar o troco do dia ! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            try
            {


                MovimentoDAL dal = new MovimentoDAL();
                Saldo = dal.CarregaSaldo();
                AbrirCaixaDTO FECHAR = new AbrirCaixaDTO();
                FECHAR.Dat_Fechamento = dtpDataFechamento.Value;
                FECHAR.Troco_Dia = Convert.ToDouble(txtTrocoFechamento.Text);

                if (Saldo != Convert.ToDouble(FECHAR.Troco_Dia))
                {
                    MessageBox.Show(" Valor troco do dia, não pode ser diferente do Saldo do Caixa ! ", " Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                FECHAR.Cod_Usuario =UsuarioSel.Cod_Usuario;
                int x = new UsuarioDAL().FecharCaixa(FECHAR);
                if (x > 0)
                {
                    MessageBox.Show("Caixa Fechado com sucesso, Você deve Imprimir o Caixa de hoje! ");

                }
                //frmRelCaixa frm = new frmRelCaixa();
                //DialogResult resultado = frm.ShowDialog();

                //if (resultado == DialogResult.Cancel)
                //{
                //    Application.Exit();
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }




    }

}
