using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.ViewModel

{
    public class pedidoDeVendaViewModel
    {
        public string Cliente { get; set; }
        public string Pedido { get; set; }
        public string Data { get; set; }
        public decimal Preço { get; set; }
        public string Produto { get; set; }

        List<Produto>
    }

    public class Produto
    {
        public string CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
    }

}


