using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Models
{
    public class Venda
    {
        //[Key()]
        public int Id { get; set; }
        // [ForeignKey("Vendedor")]
        public int VendedorId { get; set; }        
        public string ItensVendidos { get; set; }
        public string StatusDaVenda { get; set; }
        public DateTime DataDaVenda { get; set; }   
        //public List<Vendedor> VendaVendedores {get; set;}    
    }
}