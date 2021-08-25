using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class DataContext : DbContext // heranã é :
    {
        //construtor
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}
        //lista de propriedades que vão virar tabelas no banco
        public DbSet<Produto> TabelaProduto { get; set;} // smp usa o DB e o obj q ele quer

    }
}