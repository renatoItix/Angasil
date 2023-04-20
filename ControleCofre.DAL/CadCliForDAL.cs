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
    public class CadCliForDAL
    {
        //---Metodo para carrega grid
        public IList<CadCliForDTO> CarregaCliFor()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbCliente ORDER BY Nome_Cli";
                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<CadCliForDTO> listCadCliForDTO = new List<CadCliForDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        CadCliForDTO clifor = new CadCliForDTO();
                        clifor.cod_cli = Convert.ToInt16(DR["Cod_Cli"]);
                        clifor.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        clifor.cpf = Convert.ToString(DR["CPF"]);
                        clifor.rg = Convert.ToString(DR["RG"]);
                        clifor.telefone = Convert.ToString(DR["Telefone"]);
                        clifor.celular = Convert.ToString(DR["Celular"]);
                        clifor.dat_cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);

                        listCadCliForDTO.Add(clifor);

                    }
                }
                return listCadCliForDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        //---Metodo para verificar se cliente ja esta cadastrado
        public CadCliForDTO validaCadastroCliente(CadCliForDTO clifor)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbCliente WHERE CPF = @cpf  ";

                CMD.Parameters.Add("cpf", SqlDbType.VarChar).Value = clifor.cpf;

                CMD.Connection = CNX;
                SqlDataReader DR;

                CNX.Open();
                DR = CMD.ExecuteReader();

                CadCliForDTO Clifor = new CadCliForDTO();

                if (DR.HasRows)
                {
                    {
                        DR.Read();
                        
                        Clifor.cod_cli = Convert.ToInt32(DR["Cod_Cli"]);
                        Clifor.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        Clifor.cpf = Convert.ToString(DR["CPF"]);
                        Clifor.rg = Convert.ToString(DR["RG"]);
                        Clifor.telefone = Convert.ToString(DR["Telefone"]);
                        Clifor.celular = Convert.ToString(DR["Celular"]);
                        Clifor.dat_cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);
                    }
                }
                return Clifor;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //---Mtodo para consultar por nome
        public IList<CadCliForDTO> ConsultaNome(CadCliForDTO cadCliFor)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbCliente WHERE Nome_Cli LIKE '%' + @nome_cli + '%'  ";

                CMD.Parameters.Add("@nome_cli", SqlDbType.VarChar).Value = cadCliFor.nome_cli;

                CMD.Connection = CNX;
                SqlDataReader DR;
                IList<CadCliForDTO> listConsultaNome = new List<CadCliForDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        CadCliForDTO clifor = new CadCliForDTO();
                        clifor.cod_cli = Convert.ToInt32(DR["Cod_Cli"]);
                        clifor.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        clifor.cpf = Convert.ToString(DR["CPF"]);
                        clifor.rg = Convert.ToString(DR["RG"]);
                        clifor.telefone = Convert.ToString(DR["Telefone"]);
                        clifor.celular = Convert.ToString(DR["Celular"]);
                        clifor.dat_cadastro = Convert.ToDateTime(DR["Dat_Cadastro"]);

                        listConsultaNome.Add(clifor);

                    }
                }
                return listConsultaNome;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //---Metodo para inserir cliente e fornecedor
        public int insereCliFor(CadCliForDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO  tbCliente (Nome_Cli, CPF, RG, Telefone, Celular, Dat_Cadastro)" +
                                                          " VALUES (@nome_cli, @cpf, @rg, @telefone, @celular, @dat_cadastro)";


                CMD.Parameters.Add("nome_cli", SqlDbType.VarChar).Value = movi.nome_cli;
                CMD.Parameters.Add("cpf", SqlDbType.VarChar).Value = movi.cpf;
                CMD.Parameters.Add("rg", SqlDbType.VarChar).Value = movi.rg;
                CMD.Parameters.Add("telefone", SqlDbType.VarChar).Value = movi.telefone;
                CMD.Parameters.Add("celular", SqlDbType.VarChar).Value = movi.celular;
                CMD.Parameters.Add("data", SqlDbType.Date).Value = movi.dat_cadastro;
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

        //---metodo para alterar movimentacao
        public int alteraCliFor(CadCliForDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "UPDATE tbCliente  SET  Nome_Cli = @nomecli, CPF = @cpf , RG = @rg , Telefone= @telefone , Celular = @celular , Dat_Cadastro = @datcad   WHERE Cod_Cli = @codcli ";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("nomecli", SqlDbType.VarChar).Value = movi.nome_cli;
                CMD.Parameters.Add("cpf", SqlDbType.VarChar).Value = movi.cpf;
                CMD.Parameters.Add("rg", SqlDbType.VarChar).Value = movi.rg;
                CMD.Parameters.Add("telefone", SqlDbType.VarChar).Value = movi.telefone;
                CMD.Parameters.Add("celular", SqlDbType.VarChar).Value = movi.celular;
                CMD.Parameters.Add("datcad", SqlDbType.Date).Value = movi.dat_cadastro;
                CMD.Parameters.Add("codcli", SqlDbType.Int).Value = movi.cod_cli;
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

        //---metodo para Excluir movimentacao
        public int excluiMovimento(CadCliForDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "DELETE FROM tbCliente  WHERE Cod_Cli = @codcli";

                CMD.Parameters.Add("codcli", SqlDbType.Int).Value = movi.cod_cli;
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
