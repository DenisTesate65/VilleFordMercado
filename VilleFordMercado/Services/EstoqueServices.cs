using MercadoVilleFord.Banco_de_dados;
using MercadoVilleFord.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MercadoVilleFord.Services
{
    public class EstoqueServices
    {
        public IBancoDoEstoque _bancoDoEstoque { get; set; }
        public EstoqueServices(IBancoDoEstoque bancoDoEstoque)
        {
            _bancoDoEstoque = bancoDoEstoque;
        }

        public void Adicionar(Produto produto)
        {
            _bancoDoEstoque._listProdutos.Add(produto);
            Console.WriteLine("\n# Produto Adicionado com Sucesso\n");
            Console.WriteLine("--------  Lista Atualizada  -------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Nome    | Preço    | Quantidade |");
            Console.WriteLine("-----------------------------------");

            foreach (var prod in _bancoDoEstoque._listProdutos)
            {
                Console.Write(" " + prod.Nome
                    + "   | " + prod.Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "    | " + prod.Quantidade + "        |\n");
            }
            Console.WriteLine("-----------------------------------");
        }
        public void Remover(string nomePruduto)
        {
            var produto = _bancoDoEstoque._listProdutos.Find(nome => nome.Nome == nomePruduto);

            _bancoDoEstoque._listProdutos.Remove(produto);
            Console.WriteLine("--------  Lista Atualizada  -------\n");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Nome    | Preço    | Quantidade |");
            Console.WriteLine("-----------------------------------");

            foreach (var prod in _bancoDoEstoque._listProdutos)
            {
                Console.Write(" " + prod.Nome
                    + "   | " + prod.Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "    | " + prod.Quantidade + "        |\n");
            }
            Console.WriteLine("-----------------------------------");
        }

        public Produto Buscar(string nomeProduto)
        {
            var produto = _bancoDoEstoque._listProdutos.Find(nome => nome.Nome == nomeProduto);
            
            return produto;
        }
    }
}
