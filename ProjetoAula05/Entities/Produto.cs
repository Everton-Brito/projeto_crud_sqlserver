using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Produto
    {
        //propriedades -> prop + 2x tab
        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int  Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
