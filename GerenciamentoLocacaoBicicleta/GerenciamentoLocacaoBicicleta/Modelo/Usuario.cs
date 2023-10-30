using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLocacaoBicicleta.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string? NomeUsuario { get; set; }
        public string? CPFUsuario { get; set; }
        public string? RGUsuario { get; set; }
        public bool SituacaoUsuario { get; set; }

    }
}
