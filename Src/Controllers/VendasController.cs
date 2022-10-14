using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Src.Data;
using Src.Models;

namespace Src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendasController : ControllerBase
    {   
        //Aqui foi criado um atributo privado somente leitura do tipo context e foi chamado de _context
        private readonly Context _vendascontext;

        //Aqui foi criado a construtor pra receber o context
        public VendasController(Context vendascontext)
        {
            //aqui o _context recebe o context do construtor
            _vendascontext = vendascontext;
        }

        [HttpPost]
        public IActionResult CreateVenda(Venda venda)
        {
            _vendascontext.Add(venda);
            _vendascontext.SaveChanges();
            return Ok(venda);
        } 

        [HttpGet("{id}")]
        public IActionResult ObterVendaPorId(int id)
        {
            var venda = _vendascontext.Vendas.Find(id);

            if (venda == null)
                return NotFound();

            return Ok(venda);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarStatus(int id, Venda venda)
        {
            var vendabanco = _vendascontext.Vendas.Find(id);

            if(vendabanco == null)
                return NotFound();

            vendabanco.StatusDaVenda = venda.StatusDaVenda;

            _vendascontext.Vendas.Update(vendabanco);
            _vendascontext.SaveChanges();

            return Ok(vendabanco);
        }
    }
}