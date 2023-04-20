using ControleCofre.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DAL
{
    public class ContaPagarDAL
    {
        //---metodo para carregar Grid Contas a Pagar
        public IList<ContaPagarDTO> CarregaContaPagar()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* from tbCLIENTE A, tbCONTAPAGAR B WHERE A.Cod_Cli = B.Cod_Cli AND" +
                                                 " B.Flg_Situacao = 'PAGAR' AND NOT EXISTS( SELECT * FROM tbCONTAQUITADA WHERE Cod_ContaPagar = B.Cod_ContaPagar ) ORDER BY B.Dat_Venc ";

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["Cod_ContaPagar"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.cpf = Convert.ToString(DR["CPF"]);
                        contaPagar.rg = Convert.ToString(DR["RG"]);
                        contaPagar.telefone = Convert.ToString(DR["Telefone"]);
                        contaPagar.celular = Convert.ToString(DR["Celular"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["Flg_Situacao"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);

                        listContaPagarDTO.Add(contaPagar);

                    }
                }
                return listContaPagarDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo para carregar Recibo Conta Quitada
        public static DataTable CarregaRelatorioRecibo(int cod_contapagar)
        {
            SqlDataReader ODR = null;
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.CS1))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT tbCLIENTE.* , tbCONTAPAGAR.* , tbCONTAQUITADA.* FROM (tbCLIENTE INNER JOIN tbCONTAPAGAR ON tbCLIENTE.Cod_Cli = tbCONTAPAGAR.Cod_Cli)" +
                                                    " INNER JOIN tbCONTAQUITADA ON tbCONTAPAGAR.Cod_ContaPagar = tbCONTAQUITADA.Cod_ContaPagar" +
                                                    " WHERE tbCONTAQUITADA.Cod_ContaPagar = " + cod_contapagar + ";                    ";

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

        //---metodo Pesquisa Contas a Pagar por nome
        public IList<ContaPagarDTO> pesquisaContaPagarNome(ContaPagarDTO Conta)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* from tbCLIENTE A, tbCONTAPAGAR B WHERE Nome_Cli LIKE '%' + @nome_cli + '%' AND A.Cod_Cli = B.Cod_Cli AND" +
                                                 " B.Flg_Situacao = 'PAGAR' AND NOT EXISTS( SELECT * FROM tbCONTAQUITADA WHERE Cod_ContaPagar = B.Cod_ContaPagar ) ORDER BY Dat_Venc DESC ";

                CMD.Parameters.Add("nome_cli", SqlDbType.VarChar).Value = Conta.nome_cli;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["Cod_ContaPagar"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.cpf = Convert.ToString(DR["CPF"]);
                        contaPagar.rg = Convert.ToString(DR["RG"]);
                        contaPagar.telefone = Convert.ToString(DR["Telefone"]);
                        contaPagar.celular = Convert.ToString(DR["Celular"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["Flg_Situacao"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);

                        listContaPagarDTO.Add(contaPagar);

                    }
                }
                return listContaPagarDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        //---metodo Pesquisa Contas a Pagar por nome
        public IList<ContaPagarDTO> pesquisaContaPagarData(ContaPagarDTO Conta)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* from tbCLIENTE A, tbCONTAPAGAR B WHERE Dat_Venc BETWEEN @Datainicial And @Datafinal AND A.Cod_Cli = B.Cod_Cli AND" +
                                                 " B.Flg_Situacao = 'PAGAR' AND NOT EXISTS( SELECT * FROM tbCONTAQUITADA WHERE Cod_ContaPagar = B.Cod_ContaPagar ) ORDER BY Dat_Venc DESC ";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("Datainicial", SqlDbType.Date).Value = Conta.dat_venc.Date;
                CMD.Parameters.Add("Datafinal", SqlDbType.Date).Value = Conta.DataFinal.Date;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["Cod_ContaPagar"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.cpf = Convert.ToString(DR["CPF"]);
                        contaPagar.rg = Convert.ToString(DR["RG"]);
                        contaPagar.telefone = Convert.ToString(DR["Telefone"]);
                        contaPagar.celular = Convert.ToString(DR["Celular"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["Flg_Situacao"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);

                        listContaPagarDTO.Add(contaPagar);

                    }
                }
                return listContaPagarDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo Pesquisa total do Contas a Pagar por nome
        public double CarregaTotalContaPagarPorNome(ContaPagarDTO Conta)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT SUM(Valor_Titulo) from tbCLIENTE A , tbCONTAPAGAR B WHERE Nome_Cli LIKE '%' + @nome_cli + '%'  ";
                //  +  " AND NOT EXISTS(SELECT A.* , B.* FROM tbCONTAPAGAR A , tbCONTAQUITADA B WHERE A.Cod_ContaPagar = B.Cod_ContaPagar)";

                CMD.Parameters.Add("nomecli", SqlDbType.VarChar).Value = Conta.nome_cli;

                CMD.Connection = CNX;

                CNX.Open();


                double ContaPagarTotal = Convert.ToDouble(CMD.ExecuteScalar());

                return ContaPagarTotal;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        //---metodo para carregar Relatorio Contas a Pagar
        public static DataTable CarregaRelatorioContaPagar(DateTime dt1, DateTime dt2, string empresa, string tipo)
        {
            SqlDataReader ODR = null;
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.CS1))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT cli.Cod_Cli, cli.Nome_Cli, cp.Classificar_Empresa, cp.NF, cp.Descricao, cp.Centro_Custo, cp.Valor_Titulo, cp.Dat_Venc  " +
                                                    "FROM tbCLIENTE cli INNER JOIN tbCONTAPAGAR cp ON cli.Cod_Cli = cp.Cod_Cli " +
                                                   " WHERE (cp.Dat_Venc) >= #" + dt1.ToString("MM/dd/yyyy") + "# AND (Dat_Venc) <= #" + dt2.ToString("MM/dd/yyyy") + "#  " +
                                                   "AND NOT EXISTS( SELECT * FROM tbCONTAQUITADA WHERE Cod_ContaPagar = cp.Cod_ContaPagar ) ";

                    if (empresa != "..Todas")
                    {
                        cmd.CommandText += " AND (cp.Classificar_Empresa) = '" + empresa + "'";
                    }
                    if (tipo != "..Todos")
                    {
                        cmd.CommandText += " AND (cp.Centro_Custo) = '" + tipo + "'";
                    }

                    cmd.Parameters.Clear();

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

        //---metodo para converter Contas Quitada
        public int reverteContaQuitada(ContaPagarDTO movimentoSelecionado)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "DELETE FROM tbCONTAQUITADA WHERE Cod_ContaQuitada = @codcontaquitada";

                CMD.Parameters.Add("codcontaquitada", SqlDbType.Int).Value = movimentoSelecionado.cod_contaquitada;
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

        //---metodo para carregar Relatorio Contas a Pagar Quitada
        public static DataTable CarregaRelatorioContaQuitada(DateTime dt1, DateTime dt2, string empresa, string tipo)
        {
            SqlDataReader ODR = null;
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.CS1))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT tbCLIENTE.* , tbCONTAPAGAR.* , tbCONTAQUITADA.* FROM (tbCLIENTE INNER JOIN tbCONTAPAGAR ON tbCLIENTE.Cod_Cli = tbCONTAPAGAR.Cod_Cli)" +
                                                    " INNER JOIN tbCONTAQUITADA ON tbCONTAPAGAR.Cod_ContaPagar = tbCONTAQUITADA.Cod_ContaPagar" +
                                                    " WHERE(tbCONTAQUITADA.Dat_Baixa) >= #" + dt1.ToString("MM/dd/yyyy") + "# AND (tbCONTAQUITADA.Dat_Baixa) <= #" + dt2.ToString("MM/dd/yyyy") + "# ";
                    
                    if (empresa != "..Todas")
                    {
                        cmd.CommandText += " AND (tbCONTAPAGAR.Classificar_Empresa) = '" + empresa + "'";
                    }
                    if (tipo != "..Todos")
                    {
                        cmd.CommandText += " AND (tbCONTAPAGAR.Centro_Custo) = '" + tipo + "'";
                    }

                    cmd.Parameters.Clear();

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

        //---metodo para carregar Grid Contas a Pagar Quitado
        public IList<ContaPagarDTO> CarregaContaPagarQuitado()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* , C.* from tbCLIENTE A, tbCONTAPAGAR B, tbCONTAQUITADA C  WHERE" +
                                                 " A.Cod_Cli = B.Cod_Cli AND B.Cod_ContaPagar = C.Cod_ContaPagar AND C.Flg_Situacao = 'PAGO' ORDER BY C.Dat_Baixa DESC ";
                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarQuitadoDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["B.Cod_ContaPagar"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["C.Cod_ContaPagar"]);
                        contaPagar.valor_juros = Convert.ToDouble(DR["Valor_Juro"]);
                        contaPagar.valor_desc = Convert.ToDouble(DR["Valor_Desc"]);
                        contaPagar.valor_pago = Convert.ToDouble(DR["Valor_Pago"]);
                        contaPagar.dat_baixa = Convert.ToDateTime(DR["Dat_Baixa"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["C.Flg_Situacao"]);
                        contaPagar.for_pagamento = Convert.ToString(DR["For_Pagamento"]);
                        contaPagar.num_cheque = Convert.ToInt32(DR["Num_Cheque"]);
                        contaPagar.cod_contaquitada = Convert.ToInt32(DR["Cod_ContaQuitada"]);


                        listContaPagarQuitadoDTO.Add(contaPagar);

                    }
                }
                return listContaPagarQuitadoDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo Pesquisa Contas Quitada por nome
        public IList<ContaPagarDTO> pesquisaContaQuitadaNome(ContaPagarDTO conta)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* , C.*  from tbCLIENTE A, tbCONTAPAGAR B, tbCONTAQUITADA C  WHERE Nome_Cli LIKE '%' + @nome_cli + '%' AND " +
                                                 " A.Cod_Cli = B.Cod_Cli AND B.Cod_ContaPagar = C.Cod_ContaPagar AND C.Flg_Situacao = 'PAGO'  ORDER BY C.Dat_Baixa DESC ";

                CMD.Parameters.Add("nome_cli", SqlDbType.VarChar).Value = conta.nome_cli;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarQuitadoDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["B.Cod_ContaPagar"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["C.Cod_ContaPagar"]);
                        contaPagar.valor_juros = Convert.ToDouble(DR["Valor_Juro"]);
                        contaPagar.valor_desc = Convert.ToDouble(DR["Valor_Desc"]);
                        contaPagar.valor_pago = Convert.ToDouble(DR["Valor_Pago"]);
                        contaPagar.dat_baixa = Convert.ToDateTime(DR["Dat_Baixa"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["C.Flg_Situacao"]);
                        contaPagar.for_pagamento = Convert.ToString(DR["For_Pagamento"]);
                        contaPagar.num_cheque = Convert.ToInt32(DR["Num_Cheque"]);


                        listContaPagarQuitadoDTO.Add(contaPagar);

                    }
                }
                return listContaPagarQuitadoDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo Pesquisa Contas Quitada por nome
        public IList<ContaPagarDTO> pesquisaContaQuitadaData(ContaPagarDTO conta)
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = " SELECT A.* , B.* , C.*  from tbCLIENTE A, tbCONTAPAGAR B, tbCONTAQUITADA C  WHERE Dat_Baixa BETWEEN @Datainicial And @Datafinal AND " +
                                                 " A.Cod_Cli = B.Cod_Cli AND B.Cod_ContaPagar = C.Cod_ContaPagar AND C.Flg_Situacao = 'PAGO'  ORDER BY C.Dat_Baixa DESC ";

                CMD.Parameters.Clear();

                CMD.Parameters.Add("Datafinal", SqlDbType.Date).Value = conta.DataFinal;
                CMD.Parameters.Add("Datainicial", SqlDbType.Date).Value = conta.dat_baixa;

                CMD.Connection = CNX;
                SqlDataReader DR;

                IList<ContaPagarDTO> listContaPagarQuitadoDTO = new List<ContaPagarDTO>();

                CNX.Open();
                DR = CMD.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        ContaPagarDTO contaPagar = new ContaPagarDTO();
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["B.Cod_ContaPagar"]);
                        contaPagar.cod_cli = Convert.ToInt16(DR["A.Cod_Cli"]);
                        contaPagar.nf = Convert.ToString(DR["NF"]);
                        contaPagar.descricao = Convert.ToString(DR["Descricao"]);
                        contaPagar.nome_cli = Convert.ToString(DR["Nome_Cli"]);
                        contaPagar.classificar_empresa = Convert.ToString(DR["Classificar_Empresa"]);
                        contaPagar.centro_custo = Convert.ToString(DR["Centro_Custo"]);
                        contaPagar.valor_titulo = Convert.ToDouble(DR["Valor_Titulo"]);
                        contaPagar.dat_lanc = Convert.ToDateTime(DR["Dat_Lanc"]);
                        contaPagar.dat_venc = Convert.ToDateTime(DR["Dat_Venc"]);
                        contaPagar.observacao = Convert.ToString(DR["Observacao"]);
                        contaPagar.cod_contapagar = Convert.ToInt16(DR["C.Cod_ContaPagar"]);
                        contaPagar.valor_juros = Convert.ToDouble(DR["Valor_Juro"]);
                        contaPagar.valor_desc = Convert.ToDouble(DR["Valor_Desc"]);
                        contaPagar.valor_pago = Convert.ToDouble(DR["Valor_Pago"]);
                        contaPagar.dat_baixa = Convert.ToDateTime(DR["Dat_Baixa"]);
                        contaPagar.flg_situacao = Convert.ToString(DR["C.Flg_Situacao"]);
                        contaPagar.for_pagamento = Convert.ToString(DR["For_Pagamento"]);
                        contaPagar.num_cheque = Convert.ToInt32(DR["Num_Cheque"]);


                        listContaPagarQuitadoDTO.Add(contaPagar);

                    }
                }
                return listContaPagarQuitadoDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---Metodo para Alterar conta pagar
        public int alteraContaPagar(ContaPagarDTO contaPagar)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "UPDATE tbCONTAPAGAR SET Cod_Cli = @codcli," +
                                                       "NF = @nf , " +
                                                       "Descricao = @descricao ," +
                                                       "Classificar_Empresa = @classificar_empresa , " +
                                                       "Centro_Custo = @centro_custo ," +
                                                       " Valor_Titulo = @valortitulo , " +
                                                       "Dat_Lanc = @datlanc ," +
                                                       "Dat_Venc = @datvenc , " +
                                                       "Observacao = @observacao " +
                                                       "WHERE Cod_ContaPagar = @codcontapagar";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("codcli", SqlDbType.Int).Value = contaPagar.cod_cli;
                CMD.Parameters.Add("nf", SqlDbType.VarChar).Value = contaPagar.nf;
                CMD.Parameters.Add("descricao", SqlDbType.VarChar).Value = contaPagar.descricao;
                CMD.Parameters.Add("classificar_empresa", SqlDbType.VarChar).Value = contaPagar.classificar_empresa;
                CMD.Parameters.Add("centro_custo", SqlDbType.VarChar).Value = contaPagar.centro_custo;
                CMD.Parameters.Add("valortitulo", SqlDbType.Decimal).Value = contaPagar.valor_titulo;
                CMD.Parameters.Add("datlanc", SqlDbType.Date).Value = contaPagar.dat_lanc;
                CMD.Parameters.Add("datvenc", SqlDbType.Date).Value = contaPagar.dat_venc;
                CMD.Parameters.Add("observacao", SqlDbType.VarChar).Value = contaPagar.observacao;
                CMD.Parameters.Add("codcontapagar", SqlDbType.Int).Value = contaPagar.cod_contapagar;
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

        //---metodo para Excluir conta pagar
        public int excluiContaPagar(ContaPagarDTO MovContaPagar)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "DELETE FROM tbCONTAPAGAR WHERE Cod_ContaPagar = @codcontapagar";

                CMD.Parameters.Add("codcontapagar", SqlDbType.Int).Value = MovContaPagar.cod_contapagar;
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

        //---metodo para inserir conta pagar
        public int insereContaPagar(ContaPagarDTO contaPagar)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT  INTO tbCONTAPAGAR (Cod_Cli, NF, Descricao, Classificar_Empresa, Centro_Custo, Valor_Titulo, Dat_Lanc, Dat_Venc, Flg_Situacao, Observacao)" +
                                                                          " VALUES (@codcli, @nf, @descricao, @classificar_empresa, @centro_custo, @valortitulo, @datlanc, @datvenc, @flgsituacao, @observacao)";

                CMD.Parameters.Add("codcli", SqlDbType.Int).Value = contaPagar.cod_cli;
                CMD.Parameters.Add("nf", SqlDbType.VarChar).Value = contaPagar.nf;
                CMD.Parameters.Add("descricao", SqlDbType.VarChar).Value = contaPagar.descricao;
                CMD.Parameters.Add("classificar_empresa", SqlDbType.VarChar).Value = contaPagar.classificar_empresa;
                CMD.Parameters.Add("centro_custo", SqlDbType.VarChar).Value = contaPagar.centro_custo;
                CMD.Parameters.Add("valortitulo", SqlDbType.Decimal).Value = contaPagar.valor_titulo;
                CMD.Parameters.Add("datlanc", SqlDbType.Date).Value = contaPagar.dat_lanc;
                CMD.Parameters.Add("datvenc", SqlDbType.Date).Value = contaPagar.dat_venc;
                CMD.Parameters.Add("flgsituacao", SqlDbType.VarChar).Value = "PAGAR";
                CMD.Parameters.Add("observacao", SqlDbType.VarChar).Value = contaPagar.observacao;
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

        //---metodo para Pagar Conta
        public int InsereContaQuitada(ContaPagarDTO insereMov)
        {
            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "INSERT INTO tbContaQuitada (Dat_Baixa, For_Pagamento, Valor_Juro, Valor_Desc, Valor_Pago, Num_Cheque, Cod_ContaPagar, Flg_Situacao)" +
                                                                              "VALUES (@datbaixa , @forpagamento , @valorjuro , @valordesc , @valorpago , @numcheque, @codcontapagar, @flgsituacao)";

                CMD.Parameters.Clear();
                CMD.Parameters.Add("datbaixa", SqlDbType.Date).Value = insereMov.dat_baixa;
                CMD.Parameters.Add("forpagamento", SqlDbType.VarChar).Value = insereMov.for_pagamento;
                CMD.Parameters.Add("valorjuro", SqlDbType.Decimal).Value = insereMov.valor_juros;
                CMD.Parameters.Add("valordesc", SqlDbType.Decimal).Value = insereMov.valor_desc;
                CMD.Parameters.Add("valorpago", SqlDbType.Decimal).Value = insereMov.valor_pago;
                CMD.Parameters.Add("numcheque", SqlDbType.Int).Value = insereMov.num_cheque;
                CMD.Parameters.Add("codcontapagar", SqlDbType.Int).Value = insereMov.cod_contapagar;
                CMD.Parameters.Add("flgsituacao", SqlDbType.VarChar).Value = "PAGO";

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

        //---metodo para carregar Total Contas a Pagar textBox
        public double CarregaTotalContaPagar()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select SUM(Valor_Titulo) from tbCONTAPAGAR A WHERE " +
                                                 " A.Flg_Situacao = 'PAGAR' AND NOT EXISTS( SELECT * FROM tbCONTAQUITADA WHERE Cod_ContaPagar = A.Cod_ContaPagar )";
                CMD.Connection = CNX;

                CNX.Open();

                double ContaPagarTotal = Convert.ToDouble(CMD.ExecuteScalar());

                return ContaPagarTotal;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---metodo para carregar Total Contas quitadas no textBox
        public double CarregaTotalContaQuitada()
        {

            try
            {
                SqlConnection CNX = new SqlConnection();
                CNX.ConnectionString = Properties.Settings.Default.CS1;
                SqlCommand CMD = new SqlCommand();
                CMD.CommandType = CommandType.Text;
                CMD.CommandText = "Select SUM(Valor_Pago) From tbCONTAQUITADA WHERE Flg_Situacao = 'PAGO' ";
                CMD.Connection = CNX;

                CNX.Open();

                double ContaQuitada = Convert.ToDouble(CMD.ExecuteScalar());

                return ContaQuitada;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}