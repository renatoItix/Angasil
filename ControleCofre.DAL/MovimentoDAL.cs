using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using ControleCofre.DTO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ControleCofre.DAL
{
    public class MovimentoDAL
    {
        //---metodo para carregar grid
        public IList<MovimentoDTO> CarregaMovimento()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "SELECT A.*, B.* from tbCLIENTE A, tbCAIXA B  WHERE A.Cod_Cli = B.Cod_Cli  ORDER BY Data desc ";
                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<MovimentoDTO> listMovimentoDTO = new List<MovimentoDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        MovimentoDTO movi = new MovimentoDTO();
                        movi.codigo = Convert.ToInt16(DR["Codigo"]);
                        movi.nf = Convert.ToString(DR["NF"]);
                        movi.nome_Cli = Convert.ToString(DR["Nome_Cli"]);
                        movi.cpf = Convert.ToString(DR["CPF"]);
                        movi.rg = Convert.ToString(DR["RG"]);
                        movi.telefone = Convert.ToString(DR["Telefone"]);
                        movi.celular = Convert.ToString(DR["Celular"]);
                        movi.descricao = Convert.ToString(DR["Descricao"]);
                        movi.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        movi.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        movi.credito = Convert.ToDouble(DR["Credito"]);
                        movi.debito = Convert.ToDouble(DR["Debito"]);
                        movi.saldo = Convert.ToDouble(DR["Saldo"]);
                        string data;
                        if (DR["Data"] is DBNull)
                        {
                            data = "01/01/01";
                        }
                        else
                        {
                            data = DR["Data"].ToString();
                        }
                        movi.Data = Convert.ToDateTime(data);
                        movi.observacao = Convert.ToString(DR["Observacao"]);
                        movi.cod_cli = Convert.ToInt32(DR["Cod_Cli"]);

                        listMovimentoDTO.Add(movi);

                    }
                }
                return listMovimentoDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo para carregar Recibo
        public static DataTable CarregaRelatorioRecibo(int codigo)
        {
            SqlDataReader ODR = null;
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.CS1))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT cx.*, cl.*                                    " +
                        "              FROM tbCAIXA cx                                      " +
                        "              INNER JOIN tbCLIENTE cl ON cx.Cod_Cli = cl.Cod_Cli   " +
                        "              WHERE cx.Codigo = " + codigo + ";                    ";

                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet dsum = new DataSet();
                    DataTable oTable = new DataTable();//new DataTable();

                    try
                    {

                        cmd.Connection = cnx;
                        cnx.Open();
                        ODR = cmd.ExecuteReader();
                        bool x = ODR.HasRows;
                        oTable.Load(ODR);

                        cnx.Close();
                        return oTable;
                    }
                    catch (Exception ex)
                    {
                        cnx.Close();
                        throw ex;
                    }
                }
            }
        }

        //---metodo para carregar Relatorio movimentação Caixa
        public static DataTable CarregaRelatorioCaixa(DateTime dt1, DateTime dt2, string empresa, string tipo)
        {
            SqlDataReader ODR = null;
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.CS1))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT cx.Codigo, cx.Cod_Cli, cx.Classificar_Empresa, cx.NF, cx.Descricao, cx.Centro_Custo, cx.Credito, cx.Debito, cx.Data, cx.Observacao, ct.Nome_Cli " +
                                      "FROM tbCaixa cx " +
                                      "INNER JOIN tbCliente ct ON cx.Cod_Cli = ct.Cod_Cli WHERE Data BETWEEN @Datainicial And @Datafinal ";

                    if (empresa != "..Todas")
                    {
                        cmd.CommandText += " AND (cx.Classificar_Empresa) = '" + empresa + "'";
                    }
                    if (tipo != "..Todos")
                    {
                        cmd.CommandText += " AND (cx.Centro_Custo) = '" + tipo + "'";
                    }

                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("Datainicial",  SqlDbType.VarChar).Value = dt1;
                    cmd.Parameters.Add("Datafinal", SqlDbType.VarChar).Value = dt2;
                    cmd.Parameters.AddWithValue("empresaNome", empresa);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    


                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet dsum = new DataSet();
                    DataTable oTable = new DataTable();//new DataTable();

                    try
                    {

                        cmd.Connection = cnx;
                        cnx.Open();
                        ODR = cmd.ExecuteReader();
                        bool x = ODR.HasRows;
                        oTable.Load(ODR);

                        cnx.Close();
                        return oTable;
                    }
                    catch (Exception ex)
                    {
                        cnx.Close();
                        throw ex;
                    }
                }
            }
        }

        //---metodo para consultar por nome
        public IList<MovimentoDTO> ConsultaNome(MovimentoDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbCLIENTE A, tbCAIXA B WHERE Nome_Cli LIKE '%' + @nome_cli + '%'  AND A.Cod_Cli = B.Cod_Cli ORDER BY B.Data Desc ";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("nome_cli", SqlDbType.VarChar).Value = movi.nome_Cli;

                CMD.Connection = CNX;
                SqlDataReader DR;
                IList<MovimentoDTO> listConsultaNome = new List<MovimentoDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        MovimentoDTO movimento = new MovimentoDTO();
                        movimento.codigo = Convert.ToInt16(DR["Codigo"]);
                        movimento.nf = Convert.ToString(DR["NF"]);
                        movimento.nome_Cli = Convert.ToString(DR["Nome_Cli"]);
                        movimento.cpf = Convert.ToString(DR["CPF"]);
                        movimento.rg = Convert.ToString(DR["RG"]);
                        movimento.telefone = Convert.ToString(DR["Telefone"]);
                        movimento.celular = Convert.ToString(DR["Celular"]);
                        movimento.descricao = Convert.ToString(DR["Descricao"]);
                        movimento.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        movimento.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        movimento.credito = Convert.ToDouble(DR["Credito"]);
                        movimento.debito = Convert.ToDouble(DR["Debito"]);
                        movimento.saldo = Convert.ToDouble(DR["Saldo"]);
                        string data;
                        if (DR["Data"] is DBNull)
                        {
                            data = "01/01/01";
                        }
                        else
                        {
                            data = DR["Data"].ToString();
                        }
                        movimento.Data = Convert.ToDateTime(data);
                        movimento.observacao = Convert.ToString(DR["Observacao"]);

                        listConsultaNome.Add(movimento);
                    }
                }
                return listConsultaNome;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //---metodo para consultar por data
        public IList<MovimentoDTO> ConsultaData(MovimentoDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select * From tbCAIXA A, tbCLIENTE B WHERE Data BETWEEN @Datainicial And @Datafinal AND A.Cod_Cli = B.Cod_Cli ORDER BY Data Desc ";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("Datainicial", SqlDbType.Date).Value = movi.Data;
                CMD.Parameters.Add("Datafinal", SqlDbType.Date).Value = movi.DataFinal;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<MovimentoDTO> listConsultaData = new List<MovimentoDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        MovimentoDTO movimentacao = new MovimentoDTO();
                        movimentacao.codigo = Convert.ToInt16(DR["Codigo"]);
                        movimentacao.nf = Convert.ToString(DR["NF"]);
                        movimentacao.nome_Cli = Convert.ToString(DR["Nome_Cli"]);
                        movimentacao.cpf = Convert.ToString(DR["CPF"]);
                        movimentacao.rg = Convert.ToString(DR["RG"]);
                        movimentacao.telefone = Convert.ToString(DR["Telefone"]);
                        movimentacao.celular = Convert.ToString(DR["Celular"]);
                        movimentacao.descricao = Convert.ToString(DR["Descricao"]);
                        movimentacao.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        movimentacao.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        movimentacao.credito = Convert.ToInt32(DR["Credito"]);
                        movimentacao.debito = Convert.ToInt32(DR["Debito"]);
                        movimentacao.saldo = Convert.ToInt32(DR["Saldo"]);
                        string data;
                        if (DR["Data"] is DBNull)
                        {
                            data = "01/01/01";
                        }
                        else
                        {
                            data = DR["Data"].ToString();
                        }
                        movimentacao.Data = Convert.ToDateTime(data);
                        movimentacao.observacao = Convert.ToString(DR["Observacao"]);

                        listConsultaData.Add(movimentacao);

                    }
                }
                return listConsultaData;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //---metodo para inserir movimentacao
        public int insereMovimento(MovimentoDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO tbCAIXA  (Cod_Cli, NF, Descricao, Classificar_Empresa, Centro_Custo, Credito, Debito, Saldo, Data, Observacao)" +
                                                          " VALUES (@codcli, @nf, @descricao, @classificar_empresa, @centro_custo, @credito, @debito, @saldo, @data, @observacao)";

                CMD.Parameters.Add("codcli", SqlDbType.Int).Value = movi.cod_cli;
                CMD.Parameters.Add("nf", SqlDbType.VarChar).Value = movi.nf;
                CMD.Parameters.Add("descricao", SqlDbType.VarChar).Value = movi.descricao;
                CMD.Parameters.Add("classificar_empresa", SqlDbType.VarChar).Value = movi.classificar_empresa;
                CMD.Parameters.Add("centro_custo", SqlDbType.VarChar).Value = movi.centro_custo;
                CMD.Parameters.Add("credito", SqlDbType.Decimal).Value = movi.credito;
                CMD.Parameters.Add("debito", SqlDbType.Decimal).Value = movi.debito;
                CMD.Parameters.Add("saldo", SqlDbType.Decimal).Value = movi.saldo;
                CMD.Parameters.Add("data", SqlDbType.Date).Value = movi.Data;
                CMD.Parameters.Add("observacao", SqlDbType.VarChar).Value = movi.observacao;
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
        public int alteraMovimento(MovimentoDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "UPDATE tbCAIXA SET NF = @nf," +
                                                       "Descricao = @descricao ," +
                                                       "Classificar_Empresa = @classificar_empresa , " +
                                                       "Centro_Custo = @centro_custo ," +
                                                       " Credito = @credito , " +
                                                       "Debito = @debito ," +
                                                       "Data = @data , " +
                                                       "Observacao = @observacao " +
                                                       "WHERE Codigo = @codigo";

                CMD.Parameters.Clear();
                //CMD.Parameters.Add("codcli", SqlDbType.Int).Value = movi.cod_cli;
                CMD.Parameters.Add("nf", SqlDbType.VarChar).Value = movi.nf;
                CMD.Parameters.Add("descricao", SqlDbType.VarChar).Value = movi.descricao;
                CMD.Parameters.Add("classificar_empresa", SqlDbType.VarChar).Value = movi.classificar_empresa;
                CMD.Parameters.Add("centro_custo", SqlDbType.VarChar).Value = movi.centro_custo;
                CMD.Parameters.Add("credito", SqlDbType.Decimal).Value = movi.credito;
                CMD.Parameters.Add("debito", SqlDbType.Decimal).Value = movi.debito;
                CMD.Parameters.Add("data", SqlDbType.Date).Value = movi.Data;
                CMD.Parameters.Add("observacao", SqlDbType.VarChar).Value = movi.observacao;
                CMD.Parameters.Add("codigo", SqlDbType.Int).Value = movi.codigo;
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

        //---metodo para excluir movimentacao
        public int excluiMovimento(MovimentoDTO movi)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "DELETE FROM tbCAIXA  WHERE Codigo = @codigo";

                CMD.Parameters.Add("codigo", SqlDbType.Int).Value = movi.codigo;
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

        //---metodo para carregar Total Credito textBox
        public double CarregaTotalCredito()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select SUM(Credito) From tbCAIXA";
                CMD.Connection = CNX;

                CNX.Open();

                double CreditoTotal = Convert.ToDouble(CMD.ExecuteScalar());

                return CreditoTotal;
            }



            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo para carregar Total Debito textBox
        public double CarregaTotalDebito()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select SUM(Debito) From tbCAIXA";
                CMD.Connection = CNX;

                CNX.Open();

                double DebitoTotal = Convert.ToDouble(CMD.ExecuteScalar());

                return DebitoTotal;
            }



            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo para carregar Saldo Caixa textBox
        public double CarregaSaldo()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select SUM(Credito - Debito) From tbCAIXA";
                CMD.Connection = CNX;

                CNX.Open();

                double SaldoCaixa = Convert.ToDouble(CMD.ExecuteScalar());

                return SaldoCaixa;
            }



            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
