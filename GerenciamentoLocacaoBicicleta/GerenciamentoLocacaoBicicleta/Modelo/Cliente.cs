using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLocacaoBicicleta.Modelo
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPFCliente { get; set; }
        public string RGCliente { get; set; }
        public Endereco EnderecoCliente { get; set; }
        public Contato ContatoCliente { get; set; }
    }
}
