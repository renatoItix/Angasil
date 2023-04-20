using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DTO
{
    public class MovimentoDTO
    {
        public int codigo { get; set; }
        public int cod_cli { get; set; }
        public string nf { get; set; }
        public string nome_Cli { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string descricao { get; set; }
        public string classificar_empresa { get; set; }
        public string centro_custo { get; set; }
        public double credito { get; set; }
        public double debito { get; set; }
        public double saldo { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataFinal { get; set; }
        public string observacao { get; set; }
    }
}
