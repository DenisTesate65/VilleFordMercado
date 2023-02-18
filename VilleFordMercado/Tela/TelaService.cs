using MercadoVilleFord.Entities;
using MercadoVilleFord.Services;
using System.Globalization;
using System;

namespace MercadoVilleFord.Tela
{
    public class TelaService
    {
        public static void RealizarOperacoes()
        {
            GerenciarEstoqueServices gerenciarEstoqueServices = new GerenciarEstoqueServices();
            Produto produtoproduto;

            Console.Write("- O que Deseja Realizar no Estoque? ");
            string escolha = Console.ReadLine();

            switch (escolha.ToUpper())
            {
                case "A":
                    Console.WriteLine("\n> Adicione um Produto");
                    Console.Write("\nNome: ");
                    string nome = Console.ReadLine();

                    Console.Write("\nPreço:");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("\nQuantidade:");
                    string quantidade = Console.ReadLine();

                    produtoproduto = new Produto(nome, preco, quantidade);
                    gerenciarEstoqueServices.AdicioanarProduto(produtoproduto);
                    break;

                case "B":
                    Console.Write("\n> Busque um Produto pelo Nome: ");
                    string nomeBuscar = Console.ReadLine();

                    gerenciarEstoqueServices.BuscarProduto(nomeBuscar);
                    break;

                case "R":
                    Console.Write("\n> Nome do Produto que será Removido: ");

                    string nomeRemover = Console.ReadLine();
                    gerenciarEstoqueServices.RemoverProduto(nomeRemover);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }
    }
}
