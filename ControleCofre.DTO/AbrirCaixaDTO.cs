using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DTO
{
    public class AbrirCaixaDTO
    {
        public int Cod_Usuario { get; set; }
        public int Cod_abrir { get; set; }
        public DateTime Dat_Abertura { get; set; }
        public DateTime Dat_Fechamento { get; set; }
        public Double Troco_Dia { get; set; }
        public string Flg_Situacao { get; set; }
    }
}
