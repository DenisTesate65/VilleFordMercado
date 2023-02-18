using MercadoVilleFord.Banco_de_dados;
using MercadoVilleFord.Entities;
using System;
using System.Globalization;

namespace MercadoVilleFord.Services
{
    public class GerenciarEstoqueServices
    {
        public EstoqueServices _estoqueServices { get; set; }

        public GerenciarEstoqueServices()
        {
            _estoqueServices = new EstoqueServices(new BancoDoEstoque());
        }

        public void AdicioanarProduto(Produto produto)
        {
            _estoqueServices.Adicionar(produto);
        }

        public void RemoverProduto(string nome)
        {
            if (nome == null)
            {
                Console.WriteLine("\n# Não pode ser vazio");
            }

            Console.WriteLine("\n# Removido com sucesso\n");
            _estoqueServices.Remover(nome);

        }

        public void BuscarProduto(string nomeProduto)
        {
            var produto = _estoqueServices.Buscar(nomeProduto);
            if (produto != null)
            {
                Console.WriteLine("\n# Produto Encontrado\n");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Nome    | Preço    | Quantidade |");
                Console.WriteLine("-----------------------------------");
                Console.Write(" " + produto.Nome
                    + "   | " + produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "    | " + produto.Quantidade + "        |\n");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("\n# Pruduto não existe!");
            }
        }

    }
}
