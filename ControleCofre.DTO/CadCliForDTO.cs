using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DTO
{
    public class CadCliForDTO
    {
        public int cod_cli { get; set; }
        public string nome_cli { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public DateTime dat_cadastro { get; set; }

    }
}
