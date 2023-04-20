using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCofre.DTO
{
    public class UsuarioDTO : AbrirCaixaDTO
    {
        public int Cod_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime Dat_Cadastro { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Ativo { get; set; }
        public string Perfil { get; set; }

    }
}
