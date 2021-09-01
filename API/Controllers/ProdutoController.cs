using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Create([FromBody] Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        //GET: api/produto/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok (_context.Produtos.ToList());

        //GET: api/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById ([FromRoute] int id) // usar task importar  do 'using System.Threading.Tasks;'
//public Produto GetById(int id) assim tbm funciona, mas o outro exemp diz da onde o obj vem [from...]
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto==null)
            {
                return NotFound();
            }
            return Ok(produto);
        }   

        //DELETE: api/produto/delete/Bala
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Nome == name);
            
            if(produto == null)
            {
                return NotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(_context.Produtos.ToList());
        } 

        //PUT: api/produto/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }  
    }
}
