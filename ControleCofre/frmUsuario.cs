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
    public partial class frmUsuario : Form
    {
        //---Variaveis Global
        int codusuario;
        string ativo;
        UsuarioDTO abrir = new UsuarioDTO();

        public frmUsuario()

        {
            InitializeComponent();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {

            try
            {
                abrir.Nome_Usuario = txtUsuario.Text;
                abrir.Senha = txtSenha.Text;
                abrir = new UsuarioDAL().validaUsuario(abrir);
                codusuario = abrir.Cod_Usuario;
                ativo = abrir.Ativo;
                if (abrir.Nome_Usuario == null)
                {
                    MessageBox.Show("Login ou senha invalidos, digite novamente ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                    return;
                }
                else if (ativo != "ATIVO")
                {
                    MessageBox.Show("Usuario Inativo ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                    return;
                }
                
                else if (abrir.Dat_Abertura < DateTime.Now.Date)
                {
                    Form frmAbrir = new frmAbrirCaixa(abrir);
                    frmAbrir.Show();
                    this.Hide();
                    return;
                }

                Form frm = new frmPrincipal(abrir);
                frm.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }
        private void frmAbrirCaixa_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    abrir.Nome_Usuario = txtUsuario.Text;
                    abrir.Senha = txtSenha.Text;
                    abrir = new UsuarioDAL().validaUsuario(abrir);
                    codusuario = abrir.Cod_Usuario;
                    ativo = abrir.Ativo;
                    if (abrir.Nome_Usuario == null)
                    {
                        MessageBox.Show("Login ou senha invalidos, digite novamente ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        txtSenha.Text = "";
                        return;
                    }
                    else if (ativo != "ATIVO")
                    {
                        MessageBox.Show("Usuario Inativo ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        txtSenha.Text = "";
                        return;
                    }
                    else if (abrir.Dat_Abertura < DateTime.Now.Date)
                    {
                        Form frmAbrir = new frmAbrirCaixa(abrir);
                        frmAbrir.Show();
                        this.Hide();
                        return;
                    }

                    Form frm = new frmPrincipal(abrir);
                    frm.Show();
                    this.Hide();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
        }
    }

}





