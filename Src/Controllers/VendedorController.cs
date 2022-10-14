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
    public class VendedorController : ControllerBase
    {
        //Aqui foi criado um atributo privado somente leitura do tipo context e foi chamado de _vendedorcontext
        private readonly Context _vendedorcontext;

        //Construtor que recebe o context Vendedor no caso o VendedorContext
        public VendedorController(Context vendedorcontext )
        {
            //esse _vendedorcontext vai receber o vendedorcontext do construtor
            _vendedorcontext = vendedorcontext;  // o que tem o underline recebeu o sem anderline do construtor
        }

        [HttpPost]
        public IActionResult CreateVendedor(Vendedor vendedor)
        {
            _vendedorcontext.Add(vendedor); //passei o vendedor e depois sava
            _vendedorcontext.SaveChanges();
            return Ok(vendedor);
        }
    }
}