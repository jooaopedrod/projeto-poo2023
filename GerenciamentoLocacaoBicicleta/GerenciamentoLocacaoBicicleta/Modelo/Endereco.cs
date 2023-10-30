using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLocacaoBicicleta.Modelo
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string CEPEndereco { get; set; }
        public string? RuaEndereco { get; set; }
        public string NumeroEndereco { get; set; }

        public string? ComplementoEndereco { get; set; }
        public string? BairroEndereco { get; set; }
        public string? CidadeEndereco { get; set; }
        public string? EstadoEndereco { get; set; }
        public string? PaisEndereco { get; set; }

    }
}
