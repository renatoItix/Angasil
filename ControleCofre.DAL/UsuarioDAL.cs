using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using ControleCofre.DTO;
using System.Data.SqlClient;

namespace ControleCofre.DAL
{
    public class UsuarioDAL
    {

        //---Metodo para validar usuario
        public UsuarioDTO validaUsuario(UsuarioDTO abrir)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select A.*, B.Dat_Abertura, B.Dat_Fechamento, B.Troco_Dia From tbUSUARIO A, tbABRIRCAIXA B WHERE Nome_Usuario = @nomeusuario AND SENHA = @senha ORDER BY B.Dat_Abertura DESC";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("nomeusuario", SqlDbType.VarChar).Value = abrir.Nome_Usuario;
                CMD.Parameters.Add("senha", SqlDbType.Char).Value = abrir.Senha;

                CMD.Connection = CNX;
                SqlDataReader DR;
                CNX.Open();
                DR = CMD.ExecuteReader();

                UsuarioDTO abre = new UsuarioDTO();
                if (DR.HasRows)
                {

                    DR.Read();

                    abre.Cod_Usuario = Convert.ToInt16(DR["Cod_Usuario"]);
                    abre.Nome_Usuario = Convert.ToString(DR["Nome_Usuario"]);
                    abre.Nome = Convert.ToString(DR["Nome"]);
                    abre.Senha = Convert.ToString(DR["SENHA"]);
                    abre.Dat_Cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);
                    abre.Dat_Abertura = Convert.ToDateTime(DR["Dat_Abertura"]);
                    abre.Dat_Fechamento = Convert.ToDateTime(DR["Dat_Fechamento"]);
                    abre.Perfil = Convert.ToString(DR["Perfil"]);
                    abre.Ativo = Convert.ToString(DR["Ativo"]);
                    abre.Troco_Dia = Convert.ToDouble(DR["Troco_Dia"]);

                }
                return abre;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---Metodo para Abrir Caixa
        public int AbrirCaixa(AbrirCaixaDTO aBRIR)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO  tbABRIRCAIXA (Cod_Usuario, Dat_Abertura, Dat_Fechamento, Troco_Dia, Flg_Situacao)" +
                                                                               " VALUES (@codusuario, @databertura, @datfechamento, @trocodia, @flgsituacao)";

                CMD.Parameters.Add("codusuario", SqlDbType.Int).Value = aBRIR.Cod_Usuario;
                CMD.Parameters.Add("databertura", SqlDbType.Date).Value = aBRIR.Dat_Abertura;
                CMD.Parameters.Add("datfechamento", SqlDbType.Date).Value = DateTime.Now;
                CMD.Parameters.Add("trocodia", SqlDbType.Decimal).Value = aBRIR.Troco_Dia;
                CMD.Parameters.Add("flgsituacao", SqlDbType.VarChar).Value = "A";
                CMD.Connection = CNX;

                CNX.Open();
                int qtdMovi = CMD.ExecuteNonQuery();

                return qtdMovi;

            }

            catch (Exception ex)
            {

                throw ex;

            }
        }
        //---Metodo Consultar Usuario por Nome
        public IList<UsuarioDTO> ConsultaNomeUsuario(UsuarioDTO usuario)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "SELECT * from tbUSUARIO WHERE Nome LIKE '%' + @nome + '%'  ORDER BY Nome ";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("nome", SqlDbType.VarChar).Value = usuario.Nome;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<UsuarioDTO> listUsuarioDTO = new List<UsuarioDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        UsuarioDTO USU = new UsuarioDTO();
                        USU.Cod_Usuario = Convert.ToInt16(DR["Cod_Usuario"]);
                        USU.Nome = Convert.ToString(DR["Nome"]);
                        USU.Nome_Usuario = Convert.ToString(DR["Nome_Usuario"]);
                        USU.Senha = Convert.ToString(DR["SENHA"]);
                        USU.Dat_Cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);
                        USU.Email = Convert.ToString(DR["Email"]);
                        USU.Perfil = Convert.ToString(DR["Perfil"]);
                        USU.Ativo = Convert.ToString(DR["Ativo"]);

                        listUsuarioDTO.Add(USU);

                    }
                }
                return listUsuarioDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---Metodo para Fechar Caixa
        public int FecharCaixa(AbrirCaixaDTO FECHAR)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO  tbABRIRCAIXA (Cod_Usuario, Dat_Abertura, Dat_Fechamento, Troco_Dia, Flg_Situacao)" +
                                                                               " VALUES (@codusuario, @databertura, @datfechamento, @trocodia, @flgsituacao)";

                CMD.Parameters.Add("codusuario", SqlDbType.Int).Value = FECHAR.Cod_Usuario;
                CMD.Parameters.Add("databertura", SqlDbType.Date).Value = DateTime.Now;
                CMD.Parameters.Add("datfechamento", SqlDbType.Date).Value = FECHAR.Dat_Fechamento;
                CMD.Parameters.Add("trocodia", SqlDbType.Decimal).Value = FECHAR.Troco_Dia;
                CMD.Parameters.Add("flgsituacao", SqlDbType.VarChar).Value = "F";
                CMD.Connection = CNX;

                CNX.Open();
                int qtdMovi = CMD.ExecuteNonQuery();

                return qtdMovi;

            }

            catch (Exception ex)
            {

                throw ex;

            }
        }

        //---Metodo para validar Fechamento Caixa
        public AbrirCaixaDTO validaFechamento()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbABRIRCAIXA ORDER BY Dat_Abertura DESC";

                CMD.Connection = CNX;
                SqlDataReader DR;
                CNX.Open();
                DR = CMD.ExecuteReader();

                AbrirCaixaDTO valida = new AbrirCaixaDTO();

                if (DR.HasRows)
                {

                    DR.Read();

                    valida.Cod_abrir = Convert.ToInt16(DR["Cod_abrir"]);
                    valida.Cod_Usuario = Convert.ToInt16(DR["Cod_Usuario"]);
                    valida.Dat_Abertura = Convert.ToDateTime(DR["Dat_Abertura"]);
                    valida.Dat_Fechamento = Convert.ToDateTime(DR["Dat_Fechamento"]);
                    valida.Troco_Dia = Convert.ToDouble(DR["Troco_Dia"]);
                    valida.Flg_Situacao = Convert.ToString(DR["Flg_Situacao"]);

                }
                return valida;
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        //---metodo para carregar grid Usuarios
        public IList<UsuarioDTO> CarregaUsuario()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "SELECT * from tbUSUARIO ORDER BY Nome_Usuario ";
                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<UsuarioDTO> listUsuarioDTO = new List<UsuarioDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        UsuarioDTO USU = new UsuarioDTO();
                        USU.Cod_Usuario = Convert.ToInt16(DR["Cod_Usuario"]);
                        USU.Nome = Convert.ToString(DR["Nome"]);
                        USU.Nome_Usuario = Convert.ToString(DR["Nome_Usuario"]);
                        USU.Senha = Convert.ToString(DR["SENHA"]);
                        USU.Dat_Cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);
                        USU.Email = Convert.ToString(DR["Email"]);
                        USU.Perfil = Convert.ToString(DR["Perfil"]);
                        USU.Ativo = Convert.ToString(DR["Ativo"]);

                        listUsuarioDTO.Add(USU);

                    }
                }
                return listUsuarioDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        //---metodo para Inserir Usuarios
        public int insereUsuario(UsuarioDTO usu)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO  tbUSUARIO ( Nome, Nome_Usuario, SENHA, Dat_Cadastro, Email, Perfil, Ativo  )" +
                                                                               " VALUES (@nome, @nomeusuario, @senha, @datcadastro, @email, @perfil , @ativo )";

                CMD.Parameters.Add("nome", SqlDbType.VarChar).Value = usu.Nome;
                CMD.Parameters.Add("nomeusuario", SqlDbType.VarChar).Value = usu.Nome_Usuario;
                CMD.Parameters.Add("senha", SqlDbType.VarChar).Value = usu.Senha;
                CMD.Parameters.Add("datcadastro", SqlDbType.Date).Value = DateTime.Now.Date;
                CMD.Parameters.Add("email", SqlDbType.VarChar).Value = usu.Email;
                CMD.Parameters.Add("perfil", SqlDbType.VarChar).Value = usu.Perfil;
                CMD.Parameters.Add("ativo", SqlDbType.VarChar).Value = usu.Ativo;

                CMD.Connection = CNX;

                CNX.Open();
                int qtdMovi = CMD.ExecuteNonQuery();

                return qtdMovi;

            }

            catch (Exception ex)
            {

                throw ex;

            }
        }
        //---metodo para Alterar Usuarios
        public int alteraUsuario(UsuarioDTO usu)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "UPDATE tbUSUARIO SET Nome = @nome ," +
                                                                                           "  Nome_Usuario = @nomeusuario ," +
                                                                                           "  SENHA =@senha ," +
                                                                                           " Email = @email ," +
                                                                                           " Perfil = @perfil ," +
                                                                                           " Ativo = @ativo " +
                                                                                           " WHERE Cod_Usuario = @codusu";

                CMD.Parameters.Add("nome", SqlDbType.VarChar).Value = usu.Nome;
                CMD.Parameters.Add("nomeusuario", SqlDbType.VarChar).Value = usu.Nome_Usuario;
                CMD.Parameters.Add("senha", SqlDbType.VarChar).Value = usu.Senha;
                CMD.Parameters.Add("email", SqlDbType.VarChar).Value = usu.Email;
                CMD.Parameters.Add("perfil", SqlDbType.VarChar).Value = usu.Perfil;
                CMD.Parameters.Add("ativo", SqlDbType.VarChar).Value = usu.Ativo;
                CMD.Parameters.Add("codusu", SqlDbType.VarChar).Value = usu.Cod_Usuario;

                CMD.Connection = CNX;

                CNX.Open();
                int qtdMovi = CMD.ExecuteNonQuery();

                return qtdMovi;

            }

            catch (Exception ex)
            {

                throw ex;

            }
        }




    }
}
