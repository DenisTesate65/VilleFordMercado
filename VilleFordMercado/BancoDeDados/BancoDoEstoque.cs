using MercadoVilleFord.Entities;
using System.Collections.Generic;

namespace MercadoVilleFord.Banco_de_dados
{
    public class BancoDoEstoque : IBancoDoEstoque
    {
        public List<Produto> _listProdutos { get; set; }

        public BancoDoEstoque()
        {
            _listProdutos = new List<Produto>
            {
                new Produto() { Nome = "Batata", Preco = 50.00, Quantidade = "41U" },
                new Produto() { Nome = "Cebola", Preco = 80.09, Quantidade = "92U" },
                new Produto() { Nome = "Tomate", Preco = 12.00, Quantidade = "71U" },
                new Produto() { Nome = "Banana", Preco = 19.80, Quantidade = "17U" },
                new Produto() { Nome = "Cebola", Preco = 17.60, Quantidade = "43C" },
                new Produto() { Nome = "BomBom", Preco = 13.70, Quantidade = "32C" },
                new Produto() { Nome = "Salame", Preco = 10.00, Quantidade = "3KG" },
                new Produto() { Nome = "Queijo", Preco = 16.00, Quantidade = "5kg" },
                new Produto() { Nome = "Ameixa", Preco = 13.10, Quantidade = "55C" },
                new Produto() { Nome = "Cereja", Preco = 19.99, Quantidade = "55C" },
                new Produto() { Nome = "Frango", Preco = 18.90, Quantidade = "5KG" }
            };
        }
    }
}
