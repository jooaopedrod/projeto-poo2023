using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLocacaoBicicleta.Modelo
{
    public class Contato
    {
        public int IdContato { get; set; }
        public string ContatoTelefoneFixo { get; set; }
        public string ContatoTelefoneCelular  { get; set; }

        public string ContatoEmail { get; set; }
    }
}
