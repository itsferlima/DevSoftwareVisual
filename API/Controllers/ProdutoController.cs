using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers

{

    [ApiController] // smp add no controller a anotação
    [Route("api/produto")] // rota de api expecificando 
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context; //variavel global apenas leitura 
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: api/produto/create
        [HttpPost]
        [Route("create")]
        public Produto Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto;
        }

        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public List<Produto> List() => _context.Produtos.ToList();

    }
}