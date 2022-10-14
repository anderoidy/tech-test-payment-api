using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Models
{
    public class Vendedor
    {
        //[Key()]
        public int Id { get; set; }
        public int CpfVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public string EmailVendedor { get; set; }
        public int TelefoneVendedor { get; set; }
        public List<Venda> Venda { get; set; }
        //public List<VendaVendedores> VendaVendedores {get; set;} 
    }
}