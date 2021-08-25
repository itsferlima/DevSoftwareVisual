using System;

namespace API.Models
{
    public class Produto
    {
//Construtor caso tiver 1 linha pode ser assim
        public Produto() =>CriadoEm = DateTime.Now; // pega data atual
    
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao {get; set; }
        public int Quantidade {get; set; }
        public DateTime CriadoEm {get; set; }

        public override string ToString() =>
        $"Nome: {Nome} | Preço: {Preco.ToString("C2")}|Criado em: {CriadoEm}";
        }
    }
}