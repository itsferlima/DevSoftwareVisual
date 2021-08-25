using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers

{
    [ApiController] // smp add no controller a anotação
    [Route("api/produto")]// rota de api expecificando 
    public class ProdutoController : ControllerBase
    {
        public ProdutoController(DataContext context)
        {
            
        }
        private DataContext context = new DataContext();
        //POST: api/produto/create
        [HttpPost]
        [Route("create")]

        public Produto Create(Produto produto)
        {
            context.Produtos.Add(produto);
            Console.WriteLine(produto);
            produto.Nome += "Alterado";
            return produto;
        }
    }
}