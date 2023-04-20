using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DTO
{
    public class ContaPagarDTO : CadCliForDTO
    {
        public int cod_contapagar { get; set; }
        public int cod_contaquitada { get; set; }
        public int cod_cli { get; set; }
        public string nf { get; set; }
        public string descricao { get; set; }
        public string classificar_empresa { get; set; }
        public string centro_custo { get; set; }
        public double valor_titulo { get; set; }
        public double valor_juros { get; set; }
        public double valor_pago { get; set; }
        public double valor_desc { get; set; }
        public DateTime dat_lanc { get; set; }
        public DateTime dat_venc { get; set; }
        public DateTime dat_baixa { get; set; }
        public string observacao { get; set; }
        public string flg_situacao { get; set; }
        public string for_pagamento { get; set; }
        public  Int32 num_cheque { get; set; }
        public DateTime DataFinal { get; set; }

    }
}
