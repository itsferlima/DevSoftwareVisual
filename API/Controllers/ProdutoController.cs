using Microsoft.AspNetCore.Mvc;

namespace API.Controllers

{
    [ApiController] // smp add no controller a anotação
    [Route("api/produto")]// rota de api expecificando 
    public class ProdutoController : ControllerBase
    {
        public Produto create
    }
}