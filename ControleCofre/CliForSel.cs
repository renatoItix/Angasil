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
    public partial class frmSelCliFor : Form
    {
        UsuarioDTO usuario;
        public CadCliForDTO CliForSelecionado { get; set; }

        public frmSelCliFor()
        {
            InitializeComponent();

        }
        public frmSelCliFor( UsuarioDTO usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        //---metodo pesquisa por nome e carrega o grid
        public void pesquisaporNomeGrid()
        {
            try
            {

                CadCliForDTO cadCliForDTO = new CadCliForDTO();
                cadCliForDTO.nome_cli = txtSelCliFor.Text;
                IList<CadCliForDTO> listConsultaNome = new List<CadCliForDTO>();
                CadCliForDAL dal = new CadCliForDAL();
                listConsultaNome = dal.ConsultaNome(cadCliForDTO);
                dgvSelCliFor.DataSource = listConsultaNome;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão" + ex.Message);
            }
        }

        //---metodo para carregar o grid
        public void carregaGrid()
        {
            IList<CadCliForDTO> ListcadCliForDTO = new List<CadCliForDTO>();
            dgvSelCliFor.AutoGenerateColumns = false;
            CadCliForDAL cadCliForDAL = new CadCliForDAL();
            ListcadCliForDTO = cadCliForDAL.CarregaCliFor();
            dgvSelCliFor.DataSource = ListcadCliForDTO;

        }

        private void frmSelCliFor_Load(object sender, EventArgs e)
        {
            this.Text = "Selecionar Cliente ou Fornecedor" + "  |  " + usuario.Nome;
            this.ActiveControl = txtSelCliFor;
            txtSelCliFor.Focus();
            carregaGrid();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            CliForSelecionado = dgvSelCliFor.SelectedRows[0].DataBoundItem as CadCliForDTO;
            DialogResult = DialogResult.OK;

        }

        private void dgvSelCliFor_DoubleClick(object sender, EventArgs e)
        {
            CliForSelecionado = dgvSelCliFor.SelectedRows[0].DataBoundItem as CadCliForDTO;
            DialogResult = DialogResult.OK;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadCliFor frm = new frmCadCliFor(AcaoNaTela.nulo, usuario);
            frm.Show();
        }

        private void txtSelCliFor_KeyDown(object sender, KeyEventArgs e)
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
    }

}
