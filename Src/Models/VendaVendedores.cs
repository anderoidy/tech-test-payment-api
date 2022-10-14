using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Models
{
    public class VendaVendedores
    {
        public int IdVenda { get; set; }
        public int IdVendedor { get; set; }

        public Venda Vendas { get; set; }     
        public Vendedor Vendedores { get; set; }
    }
}